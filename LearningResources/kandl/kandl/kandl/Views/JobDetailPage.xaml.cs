using kandl.Models;
using kandl.Services;
using kandl.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kandl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("ID", "id")]
    public partial class JobDetailPage : ContentPage
    {
        JobDetailViewModel viewModel;

        public string ID
        {
            set
            {
                ITeamsDataStore TeamDataStore = ((App)App.Current).TeamsDataStore;
                IJobsDataStore DataStore = ((App)App.Current).JobsDataStore;

                var job = DataStore.GetItemAsync(System.Uri.UnescapeDataString(value)).Result;
                var team = TeamDataStore.GetItemAsync(job.TeamID).Result;
                var teamjob = new TeamJob(job, team);

                BindingContext = viewModel = new JobDetailViewModel(teamjob);
            }
        }
        public JobDetailPage()
        {
            InitializeComponent();
        }

        public JobDetailPage(JobDetailViewModel viewModel) : this()
        {
            BindingContext = viewModel;
        }

    }
}