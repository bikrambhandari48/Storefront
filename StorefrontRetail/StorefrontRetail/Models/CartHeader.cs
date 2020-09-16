using System;
using System.Collections.Generic;
using System.Text;

namespace StorefrontRetail.Models
{
    public class CartHeader
    {
        public int Id { get; set; }
        public string DebtorCode { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public int SiteId { get; set; }

        public int DefaultDeliveryAddressNumber { get; set; }

        //P => Pickup, D => Delivery
        public string DeliveryType { get; set; }
        public DateTime DeliveryDate { get; set; }
        public List<CartDetail> CartDetails { get; set; }

        public CartFreight Freight { get; set; }
    }
}
