using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository
{
	public  interface ICustomerRepository : IRepository<Customer>
	{
		public int AddCustomer(Customer customer);
		public int EditCustomer(Customer customer);
		public IEnumerable<Customer> GetAll();
		public int UpdateCustomer(Customer customer);
	}
}
