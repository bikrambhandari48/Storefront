using System;
using System.Collections.Generic;
using System.Text;

namespace StorefrontRetail.Models
{
    public class History
    {
        public string TransactionNumber { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public string DateRaised { get; set; }
        public decimal Extension { get; set; }

        public string FormattedExtension { get; set; }
    }

}
