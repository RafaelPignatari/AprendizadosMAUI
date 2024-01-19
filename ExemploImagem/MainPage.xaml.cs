using ExemploImagem.Helpers;
using ExemploImagem.TO;
using Newtonsoft.Json;

namespace ExemploImagem
{
    public partial class MainPage : ContentPage
    {
        private static string _chave = string.Empty;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            if (_chave == string.Empty)
            {
                await ConfiguraChave();
            }

            MainThread.BeginInvokeOnMainThread(async() => await DisplayAlert("Wait", "Acquiring data...", "Ok"));

            DisposeImage();

            var task = new Task(async() =>
            {                
                var requisicao = await HttpRequester.Get(string.Format(Constantes.URL_APOD, _chave));

                if (requisicao == null)
                {
                    MainThread.BeginInvokeOnMainThread(() => DisplayAlert("Error", "Request failed", "OK"));
                    return;
                }

                var apod = JsonConvert.DeserializeObject<List<ApodTO>>(requisicao);

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    imageTest.Source = new UriImageSource
                    {
                        Uri = new Uri(apod[0].Url),
                        CachingEnabled = false
                    };

                    lbTitulo.Text = "Title: " + apod[0].Title;
                    lbDescricao.Text = "Explanation: " + apod[0].Explanation;
                });                
            });

            task.Start();            
        }

        private async Task ConfiguraChave()
        {
            var chave = await DisplayPromptAsync("Prompt", "Write your apod key above: ");

            if (chave == null || chave == string.Empty)
            {
                await DisplayAlert("Error", "Invalid Key", "OK");
                return;
            }

            _chave = chave;
        }

        private void DisposeImage()
        {            
            imageTest.Source?.RemoveBinding(Image.SourceProperty);
            imageTest.RemoveBinding(Image.SourceProperty);
            imageTest.Source = null;
        }
    }

}
