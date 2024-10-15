using Android;
using Android.Content.PM;
using AndroidX.Core.App;
using AndroidX.Core.Content;
using static Android.Media.MediaDrm;

namespace OutroApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string logMessage = "Eu sou uma Activity do aplicativo {0}";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            RequestStoragePermission();

            string filePath = Path.Combine(FileSystem.AppDataDirectory, "activity_log1.txt");
            File.AppendAllText(filePath, string.Format(logMessage, Platform.AppContext.PackageName) + System.Environment.NewLine);

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void RequestStoragePermission()
        {
            if (ContextCompat.CheckSelfPermission(Platform.CurrentActivity, Manifest.Permission.WriteExternalStorage) != (int)Permission.Granted)
            {
                ActivityCompat.RequestPermissions(Platform.CurrentActivity, new string[] { Manifest.Permission.WriteExternalStorage }, 1);
            }
        }
    }

}
