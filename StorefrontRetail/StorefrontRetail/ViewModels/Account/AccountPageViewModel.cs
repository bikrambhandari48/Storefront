using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using StorefrontRetail.Models;
using StorefrontRetail.Services.Navigation;
using StorefrontRetail.ViewModels.Base;
using Xamarin.Forms;

namespace StorefrontRetail.ViewModels.Account
{
    public class AccountPageViewModel : BaseViewModel
    {
        private List<AccountSetting> accountSettings;

        public List<AccountSetting> AccountSettings
        {
            get => accountSettings;
            set => SetProperty(ref accountSettings, value);
        }

        private bool isUserLoggedIn;
        public  bool IsUserLoggedIn
        {
            get => isUserLoggedIn;
            set => SetProperty(ref isUserLoggedIn, value);
        }

        public ICommand GoToLoginPageCommand { get; }
        private readonly INavigationService navigationService;

        public AccountPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            this.GoToLoginPageCommand = new Command(GoToLoginPageAction);
        }

        private void GoToLoginPageAction(object obj)
        {
            navigationService.PushModalAsync<LoginPageViewModel>();
        }

        public override Task InitialiseDataAsync(object navigationData)
        {
            AccountSettings = new List<AccountSetting> {new AccountSetting {Name = "Login", Visible = true}};

            return base.InitialiseDataAsync(navigationData);
        }
    }
}