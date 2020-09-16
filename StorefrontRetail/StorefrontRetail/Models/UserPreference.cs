using System;
using System.Collections.Generic;
using System.Text;

namespace StorefrontRetail.Models
{
   public  class UserPreference
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
