using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorefrontRetail.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StorefrontRetail.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailPage : ContentPage
    {
        private readonly Product selectedProduct;
        public ProductDetailPage(Product selectedProduct)
        {
            InitializeComponent();
            this.selectedProduct = selectedProduct;
        }

        protected override void OnAppearing()
        {
            //Fetch product details
        }
    }
}