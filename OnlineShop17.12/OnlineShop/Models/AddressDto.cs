using System;
using System.Collections.Generic;

namespace OnlineShop.Models
{
    public partial class AddressDto
    {
        public AddressDto()
        {
            CustomerAddresses = new HashSet<CustomerAddressDto>();
            SalesOrderHeaderBillToAddresses = new HashSet<SalesOrderHeaderDto>();
            SalesOrderHeaderShipToAddresses = new HashSet<SalesOrderHeaderDto>();
        }

        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }
        public string PostalCode { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<CustomerAddressDto> CustomerAddresses { get; set; }
        public virtual ICollection<SalesOrderHeaderDto> SalesOrderHeaderBillToAddresses { get; set; }
        public virtual ICollection<SalesOrderHeaderDto> SalesOrderHeaderShipToAddresses { get; set; }
    }
}