using BusinessLayer.Repository;
using DataAccessLayer.DataAccessLayer;
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
		protected DataAccess _Context;

		public Repository(DataAccess context)
		{
			_Context = context;
		}

		public void Add(TEntity entity)
		{
			 _Context.Set<TEntity>().Add(entity);
		}

		public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
		{
			return _Context.Set<TEntity>().Where(predicate).ToList();
		}

		public virtual TEntity Get(int id)
		{
			return _Context.Set<TEntity>().Find(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _Context.Set<TEntity>().ToList();
		}

		public void Remove(TEntity entity)
		{
			_Context.Set<TEntity>().Remove(entity);
		}
	}
}
