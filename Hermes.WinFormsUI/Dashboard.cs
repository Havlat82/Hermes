namespace Hermes.WinFormsUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void callApiButton_Click(object sender, EventArgs e)
        {
            //TODO: Validate API Url

            try
            {
                systemStatus.Text = "Calling API..";

                //TODO: Make async API call..
                await Task.Delay(2000);

                systemStatus.Text = "API Call Successful..";
            }
            catch (Exception ex)
            {
                resultsText.Text = $"Error: {ex.Message}";
                systemStatus.Text = "Error";
            }
        }
    }
}
