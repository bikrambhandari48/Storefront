using System;
using System.Collections.Generic;
using System.Text;

namespace StorefrontRetail.Models
{
    public class ProductMenu
    {
        public  string Name { get; set; }
        public  string Count { get; set; }

        public bool HasChildrenItems { get; set; }
    }
}
