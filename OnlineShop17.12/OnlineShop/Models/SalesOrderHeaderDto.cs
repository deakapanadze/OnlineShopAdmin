using DataAccessLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
	public class SalesOrderHeaderDto
	{

        public SalesOrderHeaderDto()
        {
            SalesOrderDetails = new HashSet<SalesOrderDetailDto>();
        }

        [Key]
        public int SalesOrderID { get; set; }

        public byte RevisionNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ShipDate { get; set; }

        public byte Status { get; set; }

        public bool OnlineOrderFlag { get; set; }

        [Required]
        [StringLength(25)]
        public string SalesOrderNumber { get; set; }

        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }

        [StringLength(15)]
        public string AccountNumber { get; set; }

        public int CustomerID { get; set; }

        public int? ShipToAddressID { get; set; }

        public int? BillToAddressID { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipMethod { get; set; }

        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }

        public decimal SubTotal { get; set; }

        public decimal TaxAmt { get; set; }

        public decimal Freight { get; set; }

        public decimal TotalDue { get; set; }

        public string Comment { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual CustomerDto Customer { get; set; }

        public virtual ICollection<SalesOrderDetailDto> SalesOrderDetails { get; set; }
    }
}
