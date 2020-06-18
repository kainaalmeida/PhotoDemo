using PhotoDemo.Models;
using PhotoDemo.Views;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhotoDemo.ViewModels
{
    public class DiscoverViewModel : BaseViewModel
    {
        private readonly INavigation _navigation;
        public IList<DiscoverModel> Discovers { get; set; }
        public IList<BrowseModel> Browses { get; set; }
        public Command<DiscoverModel> DiscoverCommand { get; }
        public DiscoverViewModel(INavigation navigation)
        {
            _navigation = navigation;
            DiscoverCommand = new Command<DiscoverModel>(async (item) => await ExecuteDiscoverCommand(item));
            LoadUsers();
            LoadBrowsers();
        }

        private async Task ExecuteDiscoverCommand(DiscoverModel item)
        {
            try
            {
                if (IsBusy) return;

                IsBusy = true;
                await _navigation.PushModalAsync(new GalleryPage(item));
            }
            catch (System.Exception ex)
            {
                var msg = ex.Message;
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void LoadUsers()
        {
            Discovers = new List<DiscoverModel>
            {
                new DiscoverModel("imgUser01.png","user01.png","Ridhwan Nordin", "@ridzjcob"),
                new DiscoverModel("imgUser02.png","user02.png","Clem Onojeghuo", "@clemono2"),
                new DiscoverModel("imgUser03.png","user03.png","Jon Tyson", "@jontyson"),
                new DiscoverModel("imgUser04.png","user04.png","Simon Zhu", "@smnzhu"),
            };
        }

        public void LoadBrowsers()
        {
            Browses = new List<BrowseModel>
            {
                new BrowseModel("img01.png",SizeImageEnum.Medium),
                new BrowseModel("img02.png",SizeImageEnum.Large),
                new BrowseModel("img03.png",SizeImageEnum.Large, true),
                new BrowseModel("img04.png",SizeImageEnum.Large),
                new BrowseModel("img05.png",SizeImageEnum.Medium, true),
                new BrowseModel("img06.png",SizeImageEnum.Medium),
                new BrowseModel("img07.png",SizeImageEnum.Large, true),
                new BrowseModel("img08.png",SizeImageEnum.Large),
                new BrowseModel("img09.png",SizeImageEnum.Large, true),
                new BrowseModel("img10.png",SizeImageEnum.Medium),
            };
        }
    }
}
