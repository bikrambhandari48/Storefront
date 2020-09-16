using StorefrontRetail.Views;
using System;
using System.Collections.Generic;
using System.Text;
using StorefrontRetail.ViewModels.Base;
using Xamarin.Forms;
using StorefrontRetail.Services.Navigation;
using System.Windows.Input;

namespace StorefrontRetail.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        private string email = "test@test.com";

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        private string password = "test1234";

        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public ICommand LoginCommand { get; }
        public ICommand ForgotPasswordCommand { get; }
        public ICommand CreateAccountCommand { get; }

        private readonly INavigationService navigationService;

        public LoginPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            LoginCommand = new Command(OnLoginClicked);
            ForgotPasswordCommand = new Command(OnForgotPasswordClicked);
            CreateAccountCommand = new Command(OnCreateAccountClicked);
        }


        // private void OnCreateAccountClicked(object obj)
        // {
        //     navigation.PushModalAsync(new RegisterPage(), true);
        // }
        //
        // private void OnForgotPasswordClicked(object obj)
        // {
        //     navigation.PushAsync(new ForgotPasswordPage());
        // }

        private void OnLoginClicked()
        {
            if (email == "test@test.com" && password == "test1234")
            {
                navigationService.NavigateToAsync<MainTabPageViewModel>(null, true);
            }
        }

        private void OnForgotPasswordClicked()
        {
            navigationService.PushModalAsync<ForgotPasswordViewModel>();
        }

        private void OnCreateAccountClicked()
        {
            navigationService.PushModalAsync<RegisterPageViewModel>();
        }
    }
}