using kandl.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace kandl
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("teamdetail", typeof(TeamDetailPage));
            Routing.RegisterRoute("jobdetail", typeof(JobDetailPage));
        }
        private void RateApp_Click(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            DisplayAlert("Rate!", "You selected the Rate This App menu item.", "Ok");
        }

        private void OpenUrl(string url)
        {
            Shell.Current.FlyoutIsPresented = false;
            Launcher.OpenAsync(new Uri(url));
        }

        private void Help_Click(object sender, EventArgs e)
        {
            OpenUrl("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/shell/");
        }

        private void Tos_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.pluralsight.com/terms");
        }

        private void Privacy_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.pluralsight.com/privacy");
        }
    }
}
