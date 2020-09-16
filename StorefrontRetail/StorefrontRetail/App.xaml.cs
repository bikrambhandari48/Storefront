using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StorefrontRetail.Services;
using StorefrontRetail.Services.Navigation;
using StorefrontRetail.ViewModels;
using StorefrontRetail.ViewModels.Base;
using StorefrontRetail.Views;
using StorefrontRetail.Views.Home;

namespace StorefrontRetail
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent(); 
        }

        private Task InitNavigation()
        {
            INavigationService navigationService = ViewModelLocator.Resolve<INavigationService>();

            return navigationService.NavigateToAsync<MainTabPageViewModel>(null, true);
        }
        protected override async void OnStart()
        {
            base.OnStart();
            await InitNavigation();
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
