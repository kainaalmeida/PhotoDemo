using PhotoDemo.Views;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhotoDemo.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly INavigation _navigation;

        public Command BackCommand { get; }
        public Command LoginCommand { get; }
        public LoginViewModel(INavigation navigation)
        {
            _navigation = navigation;
            BackCommand = new Command(async () => await ExecuteBackCommand());
            LoginCommand = new Command(async () => await ExecuteLoginCommand());
        }

        private async Task ExecuteBackCommand()
        {
            await _navigation.PopAsync();
        }

        private async Task ExecuteLoginCommand()
        {
            await _navigation.PushAsync(new DiscoverPage());
        }
    }
}
