using Xamarin.Forms;
using kandl.Services;

namespace kandl
{
    public partial class App : Application
    {
        ITeamsDataStore _TeamsDataStore;
        private ITeamsDataStore GetTeamsDataStore()
        {
            if (_TeamsDataStore == null)
                _TeamsDataStore = new TeamsDataStore();
            return _TeamsDataStore;
        }

        public ITeamsDataStore TeamsDataStore => GetTeamsDataStore();

        IJobsDataStore _JobsDataStore;
        private IJobsDataStore GetJobsDataStore()
        {
            if (_JobsDataStore == null)
                _JobsDataStore = new JobsDataStore(TeamsDataStore.GetItemsAsync(true).Result);
            return _JobsDataStore;
        }
        public IJobsDataStore JobsDataStore => GetJobsDataStore();

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
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
