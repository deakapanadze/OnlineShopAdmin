using BusinessLayer.Implementations;
using BusinessLayer.Repository;
using DataAccessLayer.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly DataAccess _Context;
		public ICustomerRepository Customer { get; set; }

		public UnitOfWork(DataAccess context)
		{
			_Context = context;
			Customer = new CustomerRepository(_Context);
		}
		public void Dispose()
		{
			_Context.Dispose();
		}
		public int Complete()
		{
			return _Context.SaveChanges();	
		}

	}
}
