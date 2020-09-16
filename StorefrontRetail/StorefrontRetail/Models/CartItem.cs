using System.Collections.Generic;

namespace StorefrontRetail.Models
{
    public class CartItem
    {
        public string FormattedCartTotal { get; set; }
        public int CartHeaderId { get; set; }
        public List<Product> Products { get; set; }
        public CartDetailComment CartDetailCommentViewModel { get; set; }
        public bool OnAccount { get; set; }
        public decimal CartTotal { get; set; }
        public decimal CartTotalTax { get; set; }
        public bool ShowGoToCheckoutBtn { get; set; } = true;
        public string MinimumOrderMessage { get; set; }
        public bool ShowMinimumOrderMessage { get; set; } 
        
        public decimal TotalExcGst => CartTotal - CartTotalTax;
    }
}