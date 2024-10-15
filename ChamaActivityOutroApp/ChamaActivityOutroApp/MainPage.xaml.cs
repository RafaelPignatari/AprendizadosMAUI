using Android.App;
using Android.Content;

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
            var intent = new Intent("android.intent.action.VIEW");
            intent.SetClassName("com.companyname.outroapp", "com.companyname.outroapp.MyExternalActivity");
            intent.AddFlags(ActivityFlags.NewTask | ActivityFlags.ClearTop);
            Platform.AppContext.StartActivity(intent);
#endif
        }
    }

}
