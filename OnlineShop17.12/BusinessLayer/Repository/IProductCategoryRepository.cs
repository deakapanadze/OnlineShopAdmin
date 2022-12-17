using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository
{
	public interface  IProductCategoryRepository : IRepository<ProductCategory>
	{
		public int AddProductCategory(ProductCategory ProductCategory);
		public int EditProductCategory(ProductCategory ProductCategory);
		public IEnumerable<ProductCategory> GetAll();
		public int UpdateProductCategory(ProductCategory ProductCategory);
	}
}
