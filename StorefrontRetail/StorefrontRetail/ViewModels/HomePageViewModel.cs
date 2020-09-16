using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using StorefrontRetail.Models;
using StorefrontRetail.Services.Navigation;
using StorefrontRetail.Services.ProductMenu;
using StorefrontRetail.ViewModels.Base;
using StorefrontRetail.Views;
using StorefrontRetail.Views.Home;
using Xamarin.Forms;

namespace StorefrontRetail.ViewModels
{
    public class HomePageViewModel: BaseViewModel
    {
        
        private List<ProductMenu> productMenus;
        public List<ProductMenu> ProductMenus
        {
            get => productMenus;
            set => SetProperty(ref productMenus, value);
        }


        private ProductMenu selectedMenu;

        public ProductMenu SelectedMenu
        {
            get => selectedMenu;
            set
            {
                selectedMenu = value;
                if(selectedMenu == null) return;
                OnMenuItemSelected(selectedMenu);
            }
        }
        private readonly IProductMenuService productMenuService;
        private readonly INavigationService navigationService;
        public HomePageViewModel(IProductMenuService productMenuService,
            INavigationService navigationService)
        {
            this.productMenuService = productMenuService;
            this.navigationService = navigationService;
        }

        public override async Task InitialiseDataAsync(object navigationData)
        {
            ProductMenus = await productMenuService.GetProductMenu();
            await base.InitialiseDataAsync(navigationData);
        }

        private void OnMenuItemSelected(ProductMenu selectedMenu)
        {
            navigationService.PushDetailPageAsync<ProductListPageViewModel>(selectedMenu);
        }
    }
}
