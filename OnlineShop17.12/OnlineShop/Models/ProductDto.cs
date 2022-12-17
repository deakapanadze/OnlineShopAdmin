using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
	public partial class ProductDto
	{
        public ProductDto()
        {
            SalesOrderDetails = new HashSet<SalesOrderDetailDto>();
        }

        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        [StringLength(15)]
        public string Color { get; set; }

        [Range(1, 1000 * 1000)]
        public decimal StandardCost { get; set; }

        [Range(0, 1000 * 1000)]
        public decimal ListPrice { get; set; }

        [StringLength(5)]
        public string Size { get; set; }

        public decimal? Weight { get; set; }

        public int? ProductCategoryID { get; set; }

        public int? ProductModelID { get; set; }

        public DateTime SellStartDate { get; set; }

        public DateTime? SellEndDate { get; set; }

        public DateTime? DiscontinuedDate { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual ProductCategoryDto ProductCategory { get; set; }

        public virtual ICollection<SalesOrderDetailDto> SalesOrderDetails { get; set; }

    }
}
