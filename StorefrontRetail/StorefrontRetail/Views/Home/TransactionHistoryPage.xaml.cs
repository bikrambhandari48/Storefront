using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StorefrontRetail.Models;
using StorefrontRetail.Services;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace StorefrontRetail.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransactionHistoryPage : ContentPage
    {
        private readonly Product selectedProduct;
        

        public TransactionHistoryPage(Product selectedProduct)
        {
            InitializeComponent();
            this.selectedProduct = selectedProduct;
            BindingContext = this;
            Title = "Transaction History";
            TransactionHistoryStore transactionHistoryStore = new TransactionHistoryStore();
            TransactionHistory transactionHistory = transactionHistoryStore.GetTransactions();

            if (transactionHistory == null) return;
            BindingContext = transactionHistory;
        }

        protected override void OnAppearing()
        {
           
 
        }


        private void BtnClose_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
    }
}