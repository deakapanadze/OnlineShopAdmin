using System;
using System.Collections.Generic;

namespace OnlineShop.Models
{
    public partial class CustomerAddressDto
    {
        public int CustomerID { get; set; }
        public int AddressID { get; set; }
        public string AddressType { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual AddressDto Address { get; set; }
        public virtual CustomerDto Customer { get; set; }
    }
}