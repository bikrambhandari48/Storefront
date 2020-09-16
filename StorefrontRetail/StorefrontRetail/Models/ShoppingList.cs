using System;
using System.Collections.Generic;
using System.Text;

namespace StorefrontRetail.Models
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DebtorCode { get; set; }
        public string Comment { get; set; }
        public int UseCount { get; set; }
        public int SiteId { get; set; }
        public List<ShoppingListItem> ShoppingListItems { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
