using System;
using System.Collections.Generic;
using System.Text;

namespace StorefrontRetail.Models
{
    public class CartDetail
    {
        public int Id { get; set; }

        public string DebtorCode { get; set; }
        public string ProductCode { get; set; }
        public string Warehouse { get; set; }
        public string ProductDescription { get; set; }
        public string ProductBrand { get; set; }
        public string WeightSensitive { get; set; } = "N";
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public decimal Quantity { get; set; }
        public decimal ConversionFactorBase { get; set; }
        public decimal ConversionFactor { get; set; }
        public decimal Price { get; set; }
        public bool AlternateUnitUsed { get; set; }

        public string FormattedPrice
        {
            get => Price.ToString("c");
            set => FormattedPrice = value;
        }

        public int CartHeaderId { get; set; }
        public CartHeader CartHeader { get; set; }

        public List<CartDetailComment> CartDetailComments { get; set; }
        public string FormattedProductBrand { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
