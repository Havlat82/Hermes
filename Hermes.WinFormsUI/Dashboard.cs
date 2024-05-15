using Hermes.Abstractions;
using System.Text.Json;

namespace Hermes.WinFormsUI
{
    public partial class Dashboard : Form
    {
        private readonly IApiHelper apiHelper = new ApiHelper(new());

        public Dashboard()
        {
            InitializeComponent();
            callApiButton.Enabled = false;
        }

        private async void callApiButton_Click(object sender, EventArgs e)
        {
            systemStatus.Text = "Calling API..";
            resultsText.Text = "";

            if (!apiHelper.IsValidUrl(apiText.Text))
            {
                systemStatus.Text = "Error: Invalid URL";
                return;
            }

            try
            {
                


                resultsText.Text = await apiHelper.CallApiAsync(apiText.Text);
                
                systemStatus.Text = "API Call Successful..";
                 
            }
            catch (Exception ex)
            {
                resultsText.Text = $"Error: {ex.Message}";
                systemStatus.Text = "Error";
            }
            

        }

        private void apiText_TextChanged(object sender, EventArgs e)
        {
            systemStatus.Text = "Ready";
            callApiButton.Enabled = !string.IsNullOrEmpty(apiText.Text);            
        }
    }
}
