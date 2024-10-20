using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace OutroApp.Platforms.Android
{
    [Activity(Label = "MyExternalActivity", Exported = true)]
    public class MyExternalActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var intentRecebido = this.Intent;
            
            var textoRecebido = intentRecebido.GetStringExtra(Intent.ExtraText);

            ExecuteCode(textoRecebido);

            Finish();
        }

        private void ExecuteCode(string textoRecebido)
        {
            // Your code logic here
            Toast.MakeText(this, textoRecebido, ToastLength.Long).Show();
        }
    }
}
