
using OnlineShop.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Models
{
   
    public partial class ProductModelProductDescriptionDto
    {
        public int ProductModelID { get; set; }
     
        public int ProductDescriptionID { get; set; }
        public string Culture { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ProductDescriptionDto ProductDescription { get; set; }
        public virtual ProductDto ProductModel { get; set; }
    }
}