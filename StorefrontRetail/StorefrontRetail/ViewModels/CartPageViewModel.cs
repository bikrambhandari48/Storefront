using System.Threading.Tasks;
using System.Windows.Input;
using StorefrontRetail.Models;
using StorefrontRetail.Services.Cart;
using StorefrontRetail.Services.Navigation;
using StorefrontRetail.ViewModels.Base;
using StorefrontRetail.ViewModels.Checkout;
using Xamarin.Forms;

namespace StorefrontRetail.ViewModels
{
    public class CartPageViewModel: BaseViewModel
    {
        private CartItem cartItem;

        public CartItem CartItem
        {
            get => cartItem;
            set => SetProperty(ref cartItem, value);
        }
        public ICommand ProceedToCheckoutPageCommand { get; }
        public ICommand UpdateCartCommand { get; }
        public ICommand RemoveCartItemCommand { get; }
        public ICommand AddCommentCommand { get; }
        

        private readonly ICartService cartService;
        private readonly INavigationService navigationService;
        public CartPageViewModel(ICartService cartService, INavigationService navigationService)
        {
            this.cartService = cartService;
            this.navigationService = navigationService;
            ProceedToCheckoutPageCommand = new Command(ProceedToCheckout);
            UpdateCartCommand = new Command<object>(UpdateCartClicked);
            RemoveCartItemCommand = new Command(RemoveCartItemClicked);
            AddCommentCommand = new Command(AddCommentClicked);
        }

        private async void AddCommentClicked()
        {
            await navigationService.ShowAlertAsync("Comment", "Add a comment", "Ok");
        }

        private async void RemoveCartItemClicked()
        {
            await navigationService.ShowAlertAsync("Remove Action", "Remove cart item", "Ok");
        }

        private async void UpdateCartClicked(object cartItem)
        {
            await navigationService.ShowAlertAsync("Update Action", "Update cart quantity", "Ok");
        }

        private void ProceedToCheckout()
        {
            navigationService.NavigateToAsync<CheckoutPageViewModel>();
        }

        public override async Task InitialiseDataAsync(object navigationData)
        {
            CartItem = await cartService.GetCartItemsAsync();
            await base.InitialiseDataAsync(navigationData);
        }
    }
}