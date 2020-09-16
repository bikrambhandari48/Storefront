using System;
using System.Collections.Generic;
using System.Text;

namespace StorefrontRetail.Models
{
   public  class User
    {
        public bool? AccountEnabled { get; set; }
        public string DebtorCode { get; set; }
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Warehouse { get; set; }
        public string Address1 { get; set; }

        public string Address2 { get; set; }


        //Maps to armaster.ADDRESS3
        public string State { get; set; }

        //Maps to armaster.SUBURB
        public string City { get; set; }
        public string PostCode { get; set; }

        //0 => ARMASTER >1 ARDELIV
        public int DefaultDeliveryAddressNumber { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string EwayCustomerToken { get; set; }

        public bool OnAccount { get; set; }
        public Guid Guid { get; set; }

        public string ParentGuid { get; set; }

        public int SiteId { get; set; }

        public string VerifyEmailConfirmationToken { get; set; }

        public List<UserPermission> UserPermissions { get; set; }

        //
        public List<CartHeader> CartHeaders { get; set; }

        public List<SalesOrderHistory> SalesOrderHistories { get; set; }
        public List<CartDetail> CartDetails { get; set; }

        public List<UserPreference> UserPreferences { get; set; }

        public List<ShoppingList> ShoppingLists { get; set; }
        public List<ShoppingListItem> ShoppingListItems { get; set; }
    }
}
