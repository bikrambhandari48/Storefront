using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace StorefrontRetail.Services.Product
{
    public interface IProductService
    {
        Task<ObservableCollection<Models.Product>> GetMockProductsAsync();
    }
}