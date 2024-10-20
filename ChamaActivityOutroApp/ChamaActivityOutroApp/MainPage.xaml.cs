
namespace ChamaActivityOutroApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
#if ANDROID
            try
            {
                var sendIntent = new Android.Content.Intent(Android.Content.Intent.ActionSend);

                sendIntent.AddFlags(Android.Content.ActivityFlags.FromBackground |
                                    Android.Content.ActivityFlags.SingleTop);
                sendIntent.SetClassName("com.companyname.outroapp", "crc64e27ef97303a8e274.MyExternalActivity");
                sendIntent.PutExtra(Android.Content.Intent.ExtraText, "Olá do aplicativo ChamaActivityOutroApp!");
                sendIntent.SetType("text/plain");

                Platform.CurrentActivity?.StartActivity(Android.Content.Intent.CreateChooser(sendIntent, "Share"));
            }
            catch (Android.Content.ActivityNotFoundException ex)
            {
                // Nenhuma atividade foi encontrada com a ação ACTION_SEND e a classe de atividade MyExternalActivity.
            }
#endif
        }
    }

}
