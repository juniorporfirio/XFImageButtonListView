using Xamarin.Forms;

namespace XFlImageButtonListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new ViewModel.PalestranteVM();
            
            InitializeComponent();
        }
    }
}
