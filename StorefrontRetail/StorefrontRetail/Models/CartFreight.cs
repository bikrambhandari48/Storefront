using System;
using System.Collections.Generic;
using System.Text;

namespace StorefrontRetail.Models
{
  public  class CartFreight
    {
        public int Id { get; set; }
        public string ChargeType { get; set; }
        public decimal Rate { get; set; }
        public decimal MinTransactionValue { get; set; }
        public decimal FreightAmountIncTax { get; set; }
        public decimal TaxTotal { get; set; }
        public int CartHeaderId { get; set; }
        public string DebtorCode { get; set; }
        public CartHeader CartHeader { get; set; }
    }
}
