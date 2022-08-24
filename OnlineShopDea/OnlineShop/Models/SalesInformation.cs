using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class SalesInformation
    {
        public List<SalesByProducts> Sales { get; set; }
        public decimal Total { get; set; }
    }
}