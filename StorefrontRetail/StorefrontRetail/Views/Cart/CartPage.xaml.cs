using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StorefrontRetail.Views.Cart
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
            Title = "Cart";
        }
    }
}