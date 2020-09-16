using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorefrontRetail.Models;
using StorefrontRetail.Services;
using StorefrontRetail.Services.Product;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StorefrontRetail.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductListPage : ContentPage
    {
        public ProductListPage()
        {
            InitializeComponent();
        }

        private void ProductsCollectionView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product selectedProduct = e.CurrentSelection.FirstOrDefault() as Product;
            if (selectedProduct is null) return;
            //Show product detail page
            Navigation.PushAsync(new ProductDetailPage(selectedProduct));
        }

        private void BtnHistory_OnClicked(object sender, EventArgs e)
        {
            Button historyButton = (Button) sender;
            Product selectedProduct = (Product) historyButton.BindingContext;

            if (selectedProduct is null) return;

            Navigation.PushModalAsync(new NavigationPage(new TransactionHistoryPage(selectedProduct)));
        }
    }
}