using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileShop.Models
{
    public class Request_token
    {
        public string consumer_key { get; set; }
        public string callback { get; set; }
    }
}