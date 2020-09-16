using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace StorefrontRetail.Services.ProductMenu
{
    public class ProductMenuService: IProductMenuService
    {
        public Task<List<Models.ProductMenu>> GetProductMenu()
        {
            return Task.FromResult(GetProductMenus());
        }

        public Task<ObservableCollection<Models.ProductMenu>> GetFreezerMenu()
        {
            return Task.FromResult(GetFreezerMenus());
        }
        
        private List<Models.ProductMenu> GetProductMenus()
        {
            return new List<Models.ProductMenu>
            {
                new Models.ProductMenu
                {
                    Name = "PROMOTION",
                    Count = "4"
                },
                new Models.ProductMenu
                {
                    Name = "BAKEWELL",
                    Count = "1",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "BEVERAGES",
                    Count = "6",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "CHILLER",
                    Count = "517",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "FLOUR NUTS ETC",
                    Count = "1",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "FOOD AMB/DRY",
                    Count = "1726"
                },
                new Models.ProductMenu
                {
                    Name = "FREEZER",
                    Count = "818"
                },
            };
        }

        private ObservableCollection<Models.ProductMenu> GetFreezerMenus()
        {
            return new ObservableCollection<Models.ProductMenu>
            {
                new Models.ProductMenu
                {
                    Name = "BREAD PROD -FREEZER",
                    Count = "76",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "BURGERS/RISSOLE/PATT",
                    Count = "17",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "CAKES/TORTE FREEZER",
                    Count = "68",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "CHICKEN CKD -FREEZER",
                    Count = "5",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "CHICKEN F/PRCD -FREE",
                    Count = "14",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "CHIPS -FREEZER",
                    Count = "20",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "CONFECTIONERY",
                    Count = "1",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "CREATED BY STOCK IMP",
                    Count = "2",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "CREATED BY STOCK IMP",
                    Count = "2",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "CREATED BY STOCK IMP",
                    Count = "1",
                    HasChildrenItems = true
                },
                new Models.ProductMenu
                {
                    Name = "CREATED BY STOCK IMP",
                    Count = "1",
                    HasChildrenItems = true
                },
            };
        }
    }
}