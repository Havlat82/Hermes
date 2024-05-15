using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Abstractions
{
    public interface IApiHelper
    {
        Task<string> CallApiAsync(string url, bool needFormattedOutput = true);
        bool IsValidUrl(string url);
    }
}
