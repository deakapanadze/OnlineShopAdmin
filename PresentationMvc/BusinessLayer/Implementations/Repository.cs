using BusinessLayer.Repository;
using DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementations
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		protected DataContext _Context;
		public Repository(DataContext context)
		{
			_Context = context;
		}

		public void Add(TEntity entity)
		{
			return _Context.Set<TEntity>().Find(id);
		}

		public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public TEntity Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<TEntity> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Remove(TEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
