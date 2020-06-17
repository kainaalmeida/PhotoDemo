using PhotoDemo.Views;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhotoDemo.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }

        private readonly INavigation _navigation;
        public HomeViewModel(INavigation navigation)
        {
            _navigation = navigation;
            LoginCommand = new Command(async () => await ExecuteLoginCommand());
            RegisterCommand = new Command(async () => await ExecuteRegisterCommand());
        }

        private async Task ExecuteLoginCommand()
        {
            await _navigation.PushAsync(new LoginPage());
        }

        private async Task ExecuteRegisterCommand()
        {
            await _navigation.PushAsync(new RegisterPage());
        }
    }
}
