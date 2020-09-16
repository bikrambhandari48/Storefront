using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorefrontRetail.Models;
using StorefrontRetail.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace StorefrontRetail.Views.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : MasterDetailPage
    {
        // private ProductMenu lastSelectedMenu;
        public HomePage()
        {
            InitializeComponent();
        }
 
        // private void ListViewProductMenu_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        // {
        //     ProductMenu selectedMenu = e.SelectedItem as ProductMenu;
        //     if (selectedMenu is null) return;
        //     lastSelectedMenu = selectedMenu;
        //     BtnGoBack.Opacity = 1;
        //     Detail = new NavigationPage( new ProductListPage());
        //     IsPresented = false;
        // }
        //
        // private void BtnGoBack_OnClicked(object sender, EventArgs e)
        // {
        //     BtnGoBack.Opacity = 0;
        //     Detail = new NavigationPage(new ProductListPage());
        //     IsPresented = true;
        // }
    }
}