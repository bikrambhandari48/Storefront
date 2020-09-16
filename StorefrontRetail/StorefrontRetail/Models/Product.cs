using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorefrontRetail.Models
{
    public class Product
    {
        
        public int Id { get; set; }
        public string Code { get; set; }
        public string Warehouse { get; set; }
        public string Description { get; set; }
        public string ProductDescriptions { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Units { get; set; }

        public decimal Price { get; set; }
        public string FormattedPrice { get; set; }
        public string FormattedBrand { get; set; }
        public string Brand { get; set; }

        public decimal Quantity { get; set; }

        public bool IsPromotional { get; set; }
        public bool IsWeightSensitive { get; set; }
        public bool IsProfileItem { get; set; }
        public bool ShouldShowTaxInformation { get; set; }
        public bool IsStockAvailable { get; set; }
        public bool DisplayStockUnavailableMessage { get; set; }
        public bool DisplayNextAvailablePurchaseDate { get; set; }
        public bool HasValidNextAvailableEta { get; set; }
        public bool ShowWeeklyHistory { get; set; }
        public bool ShowAvailableQuantity { get; set; }
        public bool ShowAddToCartBtn { get; set; }
        public string NextAvailablePurchaseDate { get; set; }
        public decimal Week1Sales { get; set; }
        public decimal Week2Sales { get; set; }
        public decimal Week3Sales { get; set; }
        public decimal Week4Sales { get; set; }
        public decimal Week5Sales { get; set; }
        public string TransactionHistoryLink { get; set; }
        public decimal AvailableQuantity { get; set; }

        public bool IsSubstituteEnabled { get; set; }

        public string SubstituteStockCode { get; set; }
        public string ColorCode { get; set; }
        public bool ShowProductColor { get; set; }
        public string ColorDescription { get; set; }
        public bool ShowAlternateUnit { get; set; }

        public List<SelectListItem> AlternateUnitOptions { set; get; }
        public decimal ConversionFactorBase { get; set; }
        public decimal AlternateDecimalPlaces { get; set; }
        public string DefaultUnit { get; set; }
        public decimal BaseDecimalPlaces { get; set; }
        public bool ShowProductHistory { get; set; }
        public string AlternateUnit { get; set; }
        public bool IsAlternateUnitUsed { get; set; }

        public List<CartDetailComment> CartDetailComments { get; set; }
        public bool ShowAddItemToProfileButton { get; set; }
        public bool ShowItemDeleteButton { get; set; }

        public bool CanUpdatePrice { get; set; }

        public bool DisplayNextEtaDate => DisplayStockUnavailableMessage
                                          && !IsStockAvailable
                                          && DisplayNextAvailablePurchaseDate
                                          && HasValidNextAvailableEta;

        public bool DisplayOutOfStockMessage => DisplayStockUnavailableMessage
                                                && !IsStockAvailable;

        public bool ShowStockAvailableLabel => IsStockAvailable 
                                               && ShowAvailableQuantity;

        public bool ShowWeeklySalesContainer => IsProfileItem
                                       && ShowWeeklyHistory;

        public bool ShowAlternateUnitOption => ShowAddItemToProfileButton
                                               && ShowAlternateUnit;

        public bool ShowAddToProfileBtn => ShowAddItemToProfileButton
                                           && ShowAddItemToProfileButton;

        public bool ShowDeleteProfileItemBtn => ShowAddToCartBtn
                                                && ShowItemDeleteButton;

        public  string FormattedAvailableQuantity => AvailableQuantity + " available";

        public string DefaultSelectedUnit => DefaultUnit == "B" ? Units : AlternateUnit;

        public bool ShowBaseUnit => !ShowAlternateUnit;

        public SelectListItem SelectedItem 
        {
            get
            {
                if (!ShowAlternateUnit || AlternateUnitOptions == null) return null;
                SelectListItem item = AlternateUnitOptions.FirstOrDefault(option => option.Selected);
                return item;
            }
        }

        

    }
}