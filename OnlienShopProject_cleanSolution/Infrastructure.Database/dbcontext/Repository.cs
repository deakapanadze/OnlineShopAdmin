using Core.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.dbcontext
{
	internal class Repository<T> : IRepository<T> where T : class
	{
        protected DBContext dbContext;

        public Repository(DBContext context)
		{
            this.dbContext = context;
		}

        public void Add(T entity)
        {

            dbContext.Set<T>().Add(entity);
            //context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = dbContext.Set<T>().Find(id);
            if (entity != null)
            {
                dbContext.Set<T>().Remove(entity);
                dbContext.SaveChanges();
            }
        }

        public bool Existed(int id)
        {
            var result = dbContext.Set<T>().Find(id);
            if (result != null)
                return true;
            else
                return false;
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>().Find(id);

        }
        public void Update(int id, T entity)
        {
            var existing = dbContext.Set<T>().Find(id);
            dbContext.Entry(existing).CurrentValues.SetValues(entity);
            dbContext.SaveChanges();
        }
    }
}
