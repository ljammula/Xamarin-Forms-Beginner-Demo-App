using kandl.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kandl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        readonly HomeViewModel viewModel;
        public HomePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new HomeViewModel();
            viewModel.LoadDataCommand.Execute(null);
        }
    }
}