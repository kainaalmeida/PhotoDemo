using PhotoDemo.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel(Navigation);
        }
    }
}