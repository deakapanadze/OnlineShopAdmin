using BusinessLayer.Repository;
using DataAccessLayer.DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementations
{
	public class CustomerRepository : Repository<Customer>, ICustomerRepository
	{
		public CustomerRepository(DataAccess context) : base(context)
		{
		}

		public int AddCustomer(Customer customer)
		{
			throw new NotImplementedException();
		}

		public int EditCustomer(Customer customer)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Customer> GetCustomerListFullInfo()
		{
			var customers = _Context.Set<Customer>().ToList();

				return customers.ToList();
		}

		public int UpdateCustomer(Customer customer)
		{
			throw new NotImplementedException();
		}
	}
}
