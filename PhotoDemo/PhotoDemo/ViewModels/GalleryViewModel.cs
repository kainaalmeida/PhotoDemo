﻿using PhotoDemo.Models;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhotoDemo.ViewModels
{
    public class GalleryViewModel : BaseViewModel
    {

        private DiscoverModel _discoverModel;

        public DiscoverModel DiscoverModel
        {
            get { return _discoverModel; }
            set { SetProperty(ref _discoverModel, value); }
        }

        public Command CloseCommand { get; }

        private readonly INavigation _navigation;
        public GalleryViewModel(INavigation navigation)
        {
            _navigation = navigation;
            CloseCommand = new Command(async () => await ExecuteCloseCommand());
        }

        private async Task ExecuteCloseCommand()
        {
            await _navigation.PopModalAsync();
        }
    }
}
