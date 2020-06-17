using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhotoDemo.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly INavigation _navigation;

        public Command BackCommand { get; }
        public LoginViewModel(INavigation navigation)
        {
            _navigation = navigation;
            BackCommand = new Command(async () => await ExecuteBackCommand());
        }

        private async Task ExecuteBackCommand()
        {
            await _navigation.PopAsync();
        }
    }
}
