using System;
using System.Collections.Generic;
using System.Text;

namespace StorefrontRetail.Models
{
    public class TransactionHistory
    {
        public bool ShowTransactionNumberColumn { get; set;  }
        public bool ShowDescriptionColumn { get; set;  }
        public bool ShowQuantityColumn { get; set;  }
        public bool ShowDateRaisedColumn { get; set;  }
        public bool ShowExtensionColumn { get; set;  }
 
        public List<History> TransactionHistories { get; set; }
    }
}
