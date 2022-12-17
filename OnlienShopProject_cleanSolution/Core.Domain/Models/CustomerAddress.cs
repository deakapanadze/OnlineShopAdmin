﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Core.Domain.Models
{
    /// <summary>
    /// Cross-reference table mapping customers to their address(es).
    /// </summary>
    public partial class CustomerAddress
    {
        /// <summary>
        /// Primary key. Foreign key to Customer.CustomerID.
        /// </summary>
        public int CustomerID { get; set; }
        /// <summary>
        /// Primary key. Foreign key to Address.AddressID.
        /// </summary>
        public int AddressID { get; set; }
        /// <summary>
        /// The kind of Address. One of: Archive, Billing, Home, Main Office, Primary, Shipping
        /// </summary>
        public string AddressType { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual Address Address { get; set; }
        public virtual Customer Customer { get; set; }
    }
}