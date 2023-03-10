using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository
{
	public interface IAddressRepository: IRepository<Address>
	{
		
		public IEnumerable<Address> GetAll();
	}
}
