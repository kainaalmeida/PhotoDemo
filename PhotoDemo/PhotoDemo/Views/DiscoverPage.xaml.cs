using PhotoDemo.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoverPage : ContentPage
    {
        public DiscoverPage()
        {
            InitializeComponent();
            BindingContext = new DiscoverViewModel(Navigation);
            
        }
    }
}