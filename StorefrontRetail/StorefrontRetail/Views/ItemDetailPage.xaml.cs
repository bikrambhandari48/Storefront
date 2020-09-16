using System.ComponentModel;
using Xamarin.Forms;
using StorefrontRetail.ViewModels;

namespace StorefrontRetail.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}