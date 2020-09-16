using System.Threading.Tasks;
using StorefrontRetail.ViewModels.Account;
using StorefrontRetail.ViewModels.Base;

namespace StorefrontRetail.ViewModels
{
    public class MainTabPageViewModel : BaseViewModel
    {
        private TestPageViewModel testPageViewModel;

        public TestPageViewModel TestPageViewModel
        {
            get => testPageViewModel;
            set => SetProperty(ref testPageViewModel, value);
        }

        private HomePageViewModel homePageViewModel;

        public HomePageViewModel HomePageViewModel
        {
            get => homePageViewModel;
            set => SetProperty(ref homePageViewModel, value);
        }

        private CartPageViewModel cartPageViewModel;

        public CartPageViewModel CartPageViewModel
        {
            get => cartPageViewModel;
            set => SetProperty(ref cartPageViewModel, value);
        }

        private AccountPageViewModel accountPageViewModel;

        public AccountPageViewModel AccountPageViewModel
        {
            get => accountPageViewModel;
            set => SetProperty(ref accountPageViewModel, value);
        }

        public MainTabPageViewModel(HomePageViewModel homePageViewModel,
            CartPageViewModel cartPageViewModel,
            AccountPageViewModel accountPageViewModel,
            TestPageViewModel testPageViewModel)
        {
            HomePageViewModel = homePageViewModel;
            CartPageViewModel = cartPageViewModel;
            AccountPageViewModel = accountPageViewModel;
            TestPageViewModel = testPageViewModel;
        }

        public override Task InitialiseDataAsync(object navigationData)
        {
            return Task.WhenAny(base.InitialiseDataAsync(navigationData),
                HomePageViewModel.InitialiseDataAsync(null),
                AccountPageViewModel.InitialiseDataAsync(null),
                CartPageViewModel.InitialiseDataAsync(null),
                TestPageViewModel.InitialiseDataAsync(null));
        }
    }
}