namespace WebTester
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnWebLocal_Clicked(object sender, EventArgs e)
        {
            string htmlSource = "<head></head><body><h1>Olá, eu sou um teste em html!</h1></body>";

            webView.Source = new HtmlWebViewSource
            {
                Html = htmlSource
            };
        }

        private void btnWebLocalArquivo_Clicked(object sender, EventArgs e)
        {
            var diretorio = FileSystem.AppDataDirectory;
            var arquivo = Path.Combine(diretorio, "teste.html");

            if (File.Exists(arquivo))
            {
                var htmlContent = File.ReadAllText(arquivo);
                webView.Source = new HtmlWebViewSource
                {
                    Html = htmlContent
                };
            }
            else
            {
                // Handle the case where the file doesn't exist
            }
        }

        private void btnWebSite_Clicked(object sender, EventArgs e)
        {
            webView.Source = "https://www.google.com.br";
        }

        private async void btnFilePicker_Clicked(object sender, EventArgs e)
        {
            try
            {
                var result = await FilePicker.PickAsync();

                if (result != null)
                {
                    var stream = await result.OpenReadAsync();
                    var reader = new StreamReader(stream);
                    var htmlSource = await reader.ReadToEndAsync();

                    File.WriteAllText(Path.Combine(FileSystem.AppDataDirectory, "teste.html"), htmlSource);

                    webView.Source = new HtmlWebViewSource
                    {
                        Html = htmlSource
                    };
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
            }
        }
    }

}
