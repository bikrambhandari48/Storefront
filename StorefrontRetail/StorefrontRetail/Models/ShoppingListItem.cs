using System;
using System.Collections.Generic;
using System.Text;

namespace StorefrontRetail.Models
{
  public  class ShoppingListItem
    {
        public int Id { get; set; }
        public string Warehouse { get; set; }
        public string ProductCode { get; set; }

        public int ShoppingListId { get; set; }
        public ShoppingList ShoppingList { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public decimal Quantity { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string FormattedPrice { get; set; }

        public bool AlternateUnitUsed { get; set; }
    }
}
