using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using StorefrontRetail.Services.Navigation;
using StorefrontRetail.ViewModels.Base;
using Xamarin.Forms;

namespace StorefrontRetail.ViewModels
{
    public class ForgotPasswordViewModel: BaseViewModel
    {
        public Command ResetPasswordCommand { get; }

        public ICommand CloseForgotPasswordPageCommand { get; }

        private readonly INavigationService navigationService;
        
        public ForgotPasswordViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            ResetPasswordCommand = new Command(ResetPasswordBtnClick);
            CloseForgotPasswordPageCommand = new Command(CloseForgotPasswordPageClicked);
        }

        private void CloseForgotPasswordPageClicked()
        {
            navigationService.PopModalAsync();
        }

        private void ResetPasswordBtnClick(object obj)
        {
            
        }
    }
}
