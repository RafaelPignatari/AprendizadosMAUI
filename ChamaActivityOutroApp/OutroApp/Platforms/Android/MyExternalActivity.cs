using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace OutroApp.Platforms.Android
{
    [Activity(Label = "MyExternalActivity")]
    public class MyExternalActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Loga mensagem
            //string logMessage = "Eu sou uma Activity do aplicativo ";

            //// Escreve em arquivo
            //string filePath = Path.Combine(FileSystem.AppDataDirectory, "activity_log.txt");
            //File.AppendAllText(filePath, logMessage + System.Environment.NewLine);

            ExecuteCode();

            // Close the activity
            Finish();
        }

        private void ExecuteCode()
        {
            // Your code logic here
            //Toast.MakeText(this, "Executing code in MyExternalActivity", ToastLength.Short).Show();
        }
    }
}
