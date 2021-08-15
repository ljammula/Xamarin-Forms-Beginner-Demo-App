using Xamarin.Forms;

namespace FirstAwesomeXmApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int _count = 0;
        void Button_Clicked(object sender, System.EventArgs e)
        {
            _count++;
            ((Button)sender).Text = $"You clicked {_count} times.";
        }
    }
}
