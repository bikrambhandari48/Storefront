using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using StorefrontRetail.Models;
using StorefrontRetail.ViewModels.Base;

namespace StorefrontRetail.ViewModels
{
    public class ProductMenuViewModel : BaseViewModel
    {
       

        public ProductMenu SelectedMenu
        {
            get => SelectedMenu;
            set
            {
                if (SelectedMenu != value)
                {
                    SelectedMenu = value;
                    OnPropertyChanged(nameof(MenuItemSelected));
                }
            }
        }
        public ProductMenuViewModel()
        {
            
        }

        private void MenuItemSelected()
        {
            // Alert
            
        }

        
    }
}
