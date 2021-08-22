using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using kandl.Models;
using kandl.Views;
using kandl.Services;

namespace kandl.ViewModels
{
    public class TeamsViewModel : BaseViewModel
    {
        public ITeamsDataStore DataStore => ((App)App.Current).TeamsDataStore;
        public ObservableCollection<Team> Teams { get; set; }
        public Command LoadTeamsCommand { get; set; }

        public TeamsViewModel()
        {
            Title = "Browse Teams";
            Teams = new ObservableCollection<Team>();
            LoadTeamsCommand = new Command(async () => await ExecuteLoadTeamsCommand());
        }
        async Task ExecuteLoadTeamsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Teams.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Teams.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
