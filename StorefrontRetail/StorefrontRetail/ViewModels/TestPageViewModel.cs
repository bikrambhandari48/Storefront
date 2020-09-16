using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StorefrontRetail.Models;
using StorefrontRetail.Services.ProductMenu;
using StorefrontRetail.ViewModels.Base;
using Xamarin.Forms;

namespace StorefrontRetail.ViewModels
{
    public class TestPageViewModel: BaseViewModel
    {
        private Command AddNewMenuCommand { get; }

        private List<ProductMenu> productMenus;
        public List<ProductMenu> ProductMenus
        {
            get => productMenus;
            set => SetProperty(ref productMenus, value);
        }

        private string name;
        public string Name
        {
            get => name; set => SetProperty(ref name, value);
        }

        private readonly IProductMenuService productMenuService;

        public TestPageViewModel(IProductMenuService productMenuService)
        {
            this.productMenuService = productMenuService;
            AddNewMenuCommand = new Command(Execute);
        }

        private void Execute()
        {
            throw new NotImplementedException();
        }

        public override async Task InitialiseDataAsync(object navigationData)
        {
            ProductMenus = await productMenuService.GetProductMenu();
            await base.InitialiseDataAsync(navigationData);
        }
    }
}
