using System.Collections.Generic;
using System.Threading.Tasks;
using StorefrontRetail.Models;

namespace StorefrontRetail.Services.Cart
{
    public class CartService : ICartService
    {
        public Task<CartItem> GetCartItemsAsync()
        {
            CartItem item = new CartItem
            {
                CartTotal = 200,
                OnAccount = true,
                CartHeaderId = 200,
                CartTotalTax = 10,
                FormattedCartTotal = "$200.00",
                MinimumOrderMessage = "",
                ShowMinimumOrderMessage = false,
                ShowGoToCheckoutBtn = true,
                Products = new List<Models.Product>
                {
                    new Models.Product
                    {
                        Id = 0,
                        Code = "0015",
                        Warehouse = "00",
                        Description = "CHIP CHICKEN Smiths 45gmx36@",
                        ProductDescriptions = null,
                        Picture1 = "test_image_7.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "EACH",
                        Price = 49.64M,
                        FormattedPrice = "$49.64",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=0015'> (0015)</a>",
                        Brand = "SMITH",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = true,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 10,
                        Week2Sales = 20,
                        Week3Sales = 30,
                        Week4Sales = 40,
                        Week5Sales = 50,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = true,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 1",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 1",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Code = "001690",
                        Warehouse = "00",
                        Description = "NAPISAN 1kg (12)",
                        ProductDescriptions = null,
                        Picture1 = "test_image_14.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "UNT",
                        Price = 10.41M,
                        FormattedPrice = "$10.41",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                        Brand = "NO BRAND",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = false,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 0,
                        Week2Sales = 0,
                        Week3Sales = 0,
                        Week4Sales = 0,
                        Week5Sales = 0,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = false,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 2",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 2",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Code = "001690",
                        Warehouse = "00",
                        Description = "NAPISAN 1kg (12)",
                        ProductDescriptions = null,
                        Picture1 = "test_image_14.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "UNT",
                        Price = 10.41M,
                        FormattedPrice = "$10.41",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                        Brand = "NO BRAND",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = false,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 0,
                        Week2Sales = 0,
                        Week3Sales = 0,
                        Week4Sales = 0,
                        Week5Sales = 0,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = false,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 2",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 2",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Code = "001690",
                        Warehouse = "00",
                        Description = "NAPISAN 1kg (12)",
                        ProductDescriptions = null,
                        Picture1 = "test_image_14.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "UNT",
                        Price = 10.41M,
                        FormattedPrice = "$10.41",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                        Brand = "NO BRAND",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = false,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 0,
                        Week2Sales = 0,
                        Week3Sales = 0,
                        Week4Sales = 0,
                        Week5Sales = 0,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = false,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 2",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 2",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Code = "001690",
                        Warehouse = "00",
                        Description = "NAPISAN 1kg (12)",
                        ProductDescriptions = null,
                        Picture1 = "test_image_14.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "UNT",
                        Price = 10.41M,
                        FormattedPrice = "$10.41",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                        Brand = "NO BRAND",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = false,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 0,
                        Week2Sales = 0,
                        Week3Sales = 0,
                        Week4Sales = 0,
                        Week5Sales = 0,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = false,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 2",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 2",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Code = "001690",
                        Warehouse = "00",
                        Description = "NAPISAN 1kg (12)",
                        ProductDescriptions = null,
                        Picture1 = "test_image_14.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "UNT",
                        Price = 10.41M,
                        FormattedPrice = "$10.41",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                        Brand = "NO BRAND",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = false,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 0,
                        Week2Sales = 0,
                        Week3Sales = 0,
                        Week4Sales = 0,
                        Week5Sales = 0,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = false,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 2",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 2",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Code = "001690",
                        Warehouse = "00",
                        Description = "NAPISAN 1kg (12)",
                        ProductDescriptions = null,
                        Picture1 = "test_image_14.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "UNT",
                        Price = 10.41M,
                        FormattedPrice = "$10.41",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                        Brand = "NO BRAND",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = false,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 0,
                        Week2Sales = 0,
                        Week3Sales = 0,
                        Week4Sales = 0,
                        Week5Sales = 0,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = false,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 2",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 2",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Code = "001690",
                        Warehouse = "00",
                        Description = "NAPISAN 1kg (12)",
                        ProductDescriptions = null,
                        Picture1 = "test_image_14.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "UNT",
                        Price = 10.41M,
                        FormattedPrice = "$10.41",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                        Brand = "NO BRAND",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = false,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 0,
                        Week2Sales = 0,
                        Week3Sales = 0,
                        Week4Sales = 0,
                        Week5Sales = 0,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = false,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 2",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 2",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Code = "001690",
                        Warehouse = "00",
                        Description = "NAPISAN 1kg (12)",
                        ProductDescriptions = null,
                        Picture1 = "test_image_14.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "UNT",
                        Price = 10.41M,
                        FormattedPrice = "$10.41",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                        Brand = "NO BRAND",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = false,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 0,
                        Week2Sales = 0,
                        Week3Sales = 0,
                        Week4Sales = 0,
                        Week5Sales = 0,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = false,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 2",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 2",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Code = "001690",
                        Warehouse = "00",
                        Description = "NAPISAN 1kg (12)",
                        ProductDescriptions = null,
                        Picture1 = "test_image_14.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "UNT",
                        Price = 10.41M,
                        FormattedPrice = "$10.41",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                        Brand = "NO BRAND",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = false,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 0,
                        Week2Sales = 0,
                        Week3Sales = 0,
                        Week4Sales = 0,
                        Week5Sales = 0,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = false,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 2",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 2",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Code = "001690",
                        Warehouse = "00",
                        Description = "NAPISAN 1kg (12)",
                        ProductDescriptions = null,
                        Picture1 = "test_image_14.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "UNT",
                        Price = 10.41M,
                        FormattedPrice = "$10.41",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                        Brand = "NO BRAND",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = false,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 0,
                        Week2Sales = 0,
                        Week3Sales = 0,
                        Week4Sales = 0,
                        Week5Sales = 0,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = false,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 2",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 2",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Code = "001690",
                        Warehouse = "00",
                        Description = "NAPISAN 1kg (12)",
                        ProductDescriptions = null,
                        Picture1 = "test_image_14.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "UNT",
                        Price = 10.41M,
                        FormattedPrice = "$10.41",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                        Brand = "NO BRAND",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = false,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 0,
                        Week2Sales = 0,
                        Week3Sales = 0,
                        Week4Sales = 0,
                        Week5Sales = 0,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = false,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 2",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 2",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Code = "001690",
                        Warehouse = "00",
                        Description = "NAPISAN 1kg (12)",
                        ProductDescriptions = null,
                        Picture1 = "test_image_14.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "UNT",
                        Price = 10.41M,
                        FormattedPrice = "$10.41",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                        Brand = "NO BRAND",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = false,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 0,
                        Week2Sales = 0,
                        Week3Sales = 0,
                        Week4Sales = 0,
                        Week5Sales = 0,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = false,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 2",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 2",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    },
                    new Models.Product
                    {
                        Id = 2,
                        Code = "001690",
                        Warehouse = "00",
                        Description = "NAPISAN 1kg (12)",
                        ProductDescriptions = null,
                        Picture1 = "test_image_14.jpg",
                        Picture2 = "/images/products/medium/",
                        Units = "UNT",
                        Price = 10.41M,
                        FormattedPrice = "$10.41",
                        FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                        Brand = "NO BRAND",
                        Quantity = 12,
                        IsPromotional = true,
                        IsWeightSensitive = false,
                        IsProfileItem = false,
                        ShouldShowTaxInformation = false,
                        IsStockAvailable = false,
                        DisplayStockUnavailableMessage = true,
                        DisplayNextAvailablePurchaseDate = true,
                        HasValidNextAvailableEta = false,
                        ShowWeeklyHistory = false,
                        ShowAvailableQuantity = true,
                        ShowAddToCartBtn = true,
                        NextAvailablePurchaseDate = "13/12/2017",
                        Week1Sales = 0,
                        Week2Sales = 0,
                        Week3Sales = 0,
                        Week4Sales = 0,
                        Week5Sales = 0,
                        TransactionHistoryLink = "/TransactionHistory/GetTransactionHistoryOfAProduct",
                        AvailableQuantity = -52.02M,
                        IsSubstituteEnabled = true,
                        SubstituteStockCode = "000015-12",
                        ColorCode = "#008080",
                        ShowProductColor = true,
                        ColorDescription = "Teal",
                        ShowAlternateUnit = true,
                        AlternateUnitOptions = new List<SelectListItem>
                        {
                            new SelectListItem
                            {
                                Disabled = false,
                                Selected = true,
                                Text = "EACH",
                                Value = "B"
                            }
                        },
                        ConversionFactorBase = 1,
                        AlternateDecimalPlaces = 2,
                        DefaultUnit = "B",
                        BaseDecimalPlaces = 2,
                        ShowProductHistory = false,
                        AlternateUnit = null,

                        IsAlternateUnitUsed = false,
                        CartDetailComments = new List<CartDetailComment>
                        {
                            new CartDetailComment
                            {
                                Comment = "This is a first comment for item 2",
                                CartDetailId = 2
                            },
                            new CartDetailComment
                            {
                                Comment = "This is a second comment for item 2",
                                CartDetailId = 2
                            }
                        },
                        ShowAddItemToProfileButton = false,
                        ShowItemDeleteButton = false,
                        CanUpdatePrice = false
                    }
                }
            };
            return Task.FromResult(item);
        }
    }
}