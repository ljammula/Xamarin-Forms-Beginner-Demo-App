using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BethanysPieShopMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            bool alreadyRegistered = false;
            //MainPage = new LoginView();
            //MainPage = new RegisterView();
            //MainPage = new ContactView();
            //MainPage = new SettingsView();
            //MainPage = new WebPageView();
            //MainPage = new PieDetailView(); 
            //MainPage = new PieOverview();

            if (alreadyRegistered)
                MainPage = new MainView();
            else
                MainPage = new NavigationPage(new LoginView());


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
