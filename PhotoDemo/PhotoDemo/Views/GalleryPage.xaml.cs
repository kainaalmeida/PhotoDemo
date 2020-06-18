using PhotoDemo.Models;
using PhotoDemo.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GalleryPage : ContentPage
    {
        private readonly GalleryViewModel ViewModel;
        public GalleryPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new GalleryViewModel(Navigation);
        }

        public GalleryPage(BrowseModel browseModel) : this()
        {
            ViewModel.BrowseModel = browseModel;
        }

        public GalleryPage(DiscoverModel discoverModel) : this()
        {
            ViewModel.DiscoverModel = discoverModel;
        }
    }
}