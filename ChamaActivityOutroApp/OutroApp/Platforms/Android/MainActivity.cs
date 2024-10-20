using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using OutroApp.Platforms.Android;

namespace OutroApp
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            try
            {
                var intent = new Intent(Intent.ActionSend);

                intent.SetClass(this, typeof(MyExternalActivity));
                intent.SetType("text/plain");
                intent.PutExtra(Intent.ExtraText, "Olá do aplicativo OutroApp!");


                StartActivity(Intent.CreateChooser(intent, "Share"));
            }
            catch (ActivityNotFoundException ex)
            {
                // Nenhuma atividade foi encontrada com a ação ACTION_SEND e a classe de atividade MyExternalActivity.
            }
        }
    }
}
