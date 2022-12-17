using Core.Application.Interfaces;
using Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.dbcontext
{
	internal class CustomerRepository : Repository<Customer>, ICustomerRepository
	{
		public CustomerRepository(DBContext context) : base(context)
		{
		}
	}
}
