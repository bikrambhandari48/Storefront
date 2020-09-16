using StorefrontRetail.Services.Navigation;
using StorefrontRetail.ViewModels.Base;
using StorefrontRetail.ViewModels.Payment;
using Xamarin.Forms;

namespace StorefrontRetail.ViewModels.Checkout
{
    public class CheckoutPageViewModel : BaseViewModel
    {
        public Command ProceedToPaymentPageCommand { get; }

        private readonly INavigationService navigationService;

        public CheckoutPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            ProceedToPaymentPageCommand = new Command(ProceedToPaymentPage);
        }

        private void ProceedToPaymentPage()
        {
            navigationService.NavigateToAsync<PaymentPageViewModel>();
        }
    }
}