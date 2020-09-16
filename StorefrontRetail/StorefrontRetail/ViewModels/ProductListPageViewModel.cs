using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using StorefrontRetail.Models;
using StorefrontRetail.Services.Product;
using StorefrontRetail.ViewModels.Base;

namespace StorefrontRetail.ViewModels
{
    public class ProductListPageViewModel: BaseViewModel
    {
        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get => products;
            set => SetProperty(ref products, value);
        }
         
        private readonly IProductService productService;
        public ProductListPageViewModel(IProductService productService)
        {
            this.productService = productService;
        }

        public override async Task InitialiseDataAsync(object navigationData)
        {
            Products = await productService.GetMockProductsAsync();
            await base.InitialiseDataAsync(navigationData);
        }
    }
}
