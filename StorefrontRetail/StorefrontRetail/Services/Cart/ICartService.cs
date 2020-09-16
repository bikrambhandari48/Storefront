using System.Threading.Tasks;
using StorefrontRetail.Models;

namespace StorefrontRetail.Services.Cart
{
    public interface ICartService
    {
        Task<CartItem> GetCartItemsAsync();
    }
}