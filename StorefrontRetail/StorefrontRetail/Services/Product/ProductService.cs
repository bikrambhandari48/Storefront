using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using StorefrontRetail.Helpers;
using StorefrontRetail.Models;
using StorefrontRetail.Services.Navigation;
using StorefrontRetail.Services.RequestProvider;

namespace StorefrontRetail.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IRequestProvider requestProvider;

        public ProductService(IRequestProvider requestProvider)
        {
            this.requestProvider = requestProvider;
        }

        private ObservableCollection<Models.Product> GetProducts()
        {
            return new ObservableCollection<Models.Product>
            {
                new Models.Product
                {
                    Code = "0015",
                    Warehouse = "00",
                    Description = "CHIP CHICKEN Smiths 45gmx36@",
                    ProductDescriptions = null,
                    Picture1 = "/images/products/small/test_image_10.jpg",
                    Picture2 = "/images/products/medium/",
                    Units = "EACH",
                    Price = 49.64M,
                    FormattedPrice = "$49.64",
                    FormattedBrand = "<a  href='/ViewProduct?productCode=0015'> (0015)</a>",
                    Brand = "SMITH",
                    Quantity = 0,
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
                    Id = 0,
                    IsAlternateUnitUsed = false,
                    CartDetailComments = null,
                    ShowAddItemToProfileButton = false,
                    ShowItemDeleteButton = false,
                    CanUpdatePrice = false
                },
                new Models.Product
                {
                    Code = "001690",
                    Warehouse = "00",
                    Description = "NAPISAN 1kg (12)",
                    ProductDescriptions = null,
                    Picture1 = "/images/products/small/test_image_8.jpg",
                    Picture2 = "/images/products/medium/",
                    Units = "UNT",
                    Price = 10.41M,
                    FormattedPrice = "$10.41",
                    FormattedBrand = "<a  href='/ViewProduct?productCode=001690'>NO BRAND (001690)</a>",
                    Brand = "NO BRAND",
                    Quantity = 0,
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
                    Id = 0,
                    IsAlternateUnitUsed = false,
                    CartDetailComments = null,
                    ShowAddItemToProfileButton = false,
                    ShowItemDeleteButton = false,
                    CanUpdatePrice = false
                }
            };
        }

        public Task<ObservableCollection<Models.Product>> GetMockProductsAsync()
        {
            // ObservableCollection<Models.Product> products =
            //     await requestProvider.GetAsync<ObservableCollection<Models.Product>>(
            //         GlobalSetting.PromotionalProductUrl);
            return Task.FromResult(GetProducts());

            // return products;
        }
    }
}