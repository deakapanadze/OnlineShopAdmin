using System;
using System.Collections.Generic;

namespace OnlineShop.Models
{
    public partial class ProductDescriptionDto
    {
        public ProductDescriptionDto()
        {
            ProductModelProductDescriptions = new HashSet<ProductModelProductDescriptionDto>();
        }
        public int ProductDescriptionID { get; set; }
        public string Description { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductModelProductDescriptionDto> ProductModelProductDescriptions { get; set; }
    }
}