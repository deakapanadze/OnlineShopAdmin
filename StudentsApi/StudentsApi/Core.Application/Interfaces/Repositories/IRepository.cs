using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Application.Interfaces.Repositories
{
   public interface IRepository<T>where T:class
    {
        void Add(T entity);
        void Update(int id, T entity);
        void Delete(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
