using Hermes.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hermes
{
    public class ApiHelper : IApiHelper
    {
        private readonly HttpClient _client;

        public ApiHelper(HttpClient client)
        {
            _client = client;
        }

        public bool IsValidUrl(string url)
        {
            if(string.IsNullOrEmpty(url)) 
                    return false; 

            var output = Uri.TryCreate(url, UriKind.Absolute, out Uri? uriOutput) && (uriOutput.Scheme == Uri.UriSchemeHttps);
            return output;
        }
        
        public async Task<string> CallApiAsync(string url, bool needFormatedOutput = true)
        {
            var response = await _client.GetAsync(url);
            
            if (!response.IsSuccessStatusCode) 
            {                
                return $"Error: {response.ReasonPhrase}";
            }

            var json = await response.Content.ReadAsStringAsync();

            if (needFormatedOutput) 
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                return JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
            }     

            return json;
        }
    }
}
