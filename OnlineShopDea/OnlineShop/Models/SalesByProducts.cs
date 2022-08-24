using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class SalesByProducts
    {
        public string Category { get; set; }
        public int Year { get; set; }
        public decimal SalesAmount { get; set; }
        public decimal PercentableMax { get; set; }
    }
}