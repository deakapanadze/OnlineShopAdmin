using Core.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Database.Implementations
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        protected StudentsDbContext context;

        public Repository(StudentsDbContext context)
        {
            this.context = context;
        }


        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = context.Set<T>().Find(id);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Update(int id, T entity)
        {
            var existing = context.Set<T>().Find(id);
            context.Entry(existing).CurrentValues.SetValues(entity);
            context.SaveChanges();
        }
    }
}
