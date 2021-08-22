using kandl.Services;
using kandl.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kandl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("ID", "id")]
    public partial class TeamDetailPage : ContentPage
    {
        TeamDetailViewModel viewModel;

        public string ID
        {
            set
            {
                ITeamsDataStore DataStore = ((App)App.Current).TeamsDataStore;
                var team = DataStore.GetItemAsync(System.Uri.UnescapeDataString(value)).Result;

                BindingContext = viewModel = new TeamDetailViewModel(team);
            }
        }

        public TeamDetailPage()
        {
            InitializeComponent();
        }

        // define first
        public TeamDetailPage(TeamDetailViewModel viewModel) : this()
        {
            BindingContext = viewModel;
        }
    }
}