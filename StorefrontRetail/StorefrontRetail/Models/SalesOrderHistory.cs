using System;
using System.Collections.Generic;
using System.Text;

namespace StorefrontRetail.Models
{
  public  class SalesOrderHistory
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }

        public decimal TotalAmount { get; set; }

        public string DebtorCode { get; set; }
        
        public string Status { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
