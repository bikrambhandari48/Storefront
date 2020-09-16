using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace StorefrontRetail.Services.ProductMenu
{
    public interface IProductMenuService
    {
        Task<List<Models.ProductMenu>> GetProductMenu();

        Task<ObservableCollection<Models.ProductMenu>> GetFreezerMenu();
    }
}