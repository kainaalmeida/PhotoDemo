using PhotoDemo.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PhotoDemo.ViewModels
{
    public class DiscoverViewModel : BaseViewModel
    {
        private readonly INavigation _navigation;
        public IList<DiscoverModel> Discovers { get; set; }
        public DiscoverViewModel(INavigation navigation)
        {
            _navigation = navigation;
            LoadUsers();
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
    }
}
