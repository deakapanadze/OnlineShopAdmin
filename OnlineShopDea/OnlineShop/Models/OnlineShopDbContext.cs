using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OnlineShop.Models
{
	public partial class OnlineShopDbContext : DbContext
	{
		public OnlineShopDbContext()
			: base("name=OnlineShopDbContext")
		{
		}

		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<ProductCategory> ProductCategories { get; set; }
		public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
		public virtual DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Customer>()
				.Property(e => e.PasswordHash)
				.IsUnicode(false);

			modelBuilder.Entity<Customer>()
				.Property(e => e.PasswordSalt)
				.IsUnicode(false);

			modelBuilder.Entity<Customer>()
				.HasMany(e => e.CustomerAddresses)
				.WithRequired(e => e.Customer)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Customer>()
				.HasMany(e => e.SalesOrderHeaders)
				.WithRequired(e => e.Customer)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Product>()
				.Property(e => e.StandardCost)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Product>()
				.Property(e => e.ListPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Product>()
				.Property(e => e.Weight)
				.HasPrecision(8, 2);

			modelBuilder.Entity<Product>()
				.HasMany(e => e.SalesOrderDetails)
				.WithRequired(e => e.Product)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ProductCategory>()
				.HasMany(e => e.ProductCategory1)
				.WithOptional(e => e.ProductCategory2)
				.HasForeignKey(e => e.ParentProductCategoryID);

			modelBuilder.Entity<SalesOrderDetail>()
				.Property(e => e.UnitPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<SalesOrderDetail>()
				.Property(e => e.UnitPriceDiscount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<SalesOrderDetail>()
				.Property(e => e.LineTotal)
				.HasPrecision(38, 6);

			modelBuilder.Entity<SalesOrderHeader>()
				.Property(e => e.CreditCardApprovalCode)
				.IsUnicode(false);

			modelBuilder.Entity<SalesOrderHeader>()
				.Property(e => e.SubTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<SalesOrderHeader>()
				.Property(e => e.TaxAmt)
				.HasPrecision(19, 4);

			modelBuilder.Entity<SalesOrderHeader>()
				.Property(e => e.Freight)
				.HasPrecision(19, 4);

			modelBuilder.Entity<SalesOrderHeader>()
				.Property(e => e.TotalDue)
				.HasPrecision(19, 4);
		}
	}
}
