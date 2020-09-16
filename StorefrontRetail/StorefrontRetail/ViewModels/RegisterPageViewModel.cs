using System;
using System.Collections.Generic;
using System.Text;
using StorefrontRetail.Services.Navigation;
using StorefrontRetail.ViewModels.Base;
using Xamarin.Forms;

namespace StorefrontRetail.ViewModels
{
    public class RegisterPageViewModel: BaseViewModel
    {
        public Command DismissRegisterPageCommand { get; }

        private readonly INavigationService navigationService;
        public RegisterPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            this.DismissRegisterPageCommand = new Command(OnDismissRegisterPageClick);
        }

        private void OnDismissRegisterPageClick()
        {
            navigationService.PopModalAsync();
        }
    }
}
