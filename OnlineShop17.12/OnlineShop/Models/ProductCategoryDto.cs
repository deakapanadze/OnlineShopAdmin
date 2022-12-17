using OnlineShop.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Models
{
    public partial class ProductCategoryDto
    {
        public ProductCategoryDto()
        {
            InverseParentProductCategory = new HashSet<ProductCategoryDto>();
            Products = new HashSet<ProductDto>();
        }
        public int ProductCategoryID { get; set; }
        public int? ParentProductCategoryID { get; set; }
        public string Name { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ProductCategoryDto ParentProductCategory { get; set; }
        public virtual ICollection<ProductCategoryDto> InverseParentProductCategory { get; set; }
        public virtual ICollection<ProductDto> Products { get; set; }
    }
}