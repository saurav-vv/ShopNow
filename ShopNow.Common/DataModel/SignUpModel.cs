﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Common.DataModel
{
   public class SignUpModel
    {
        public int SignUpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Re_Password { get; set; }
        public int UserStatus { get; set; }
        public string Address { get; set; }
    }
}
