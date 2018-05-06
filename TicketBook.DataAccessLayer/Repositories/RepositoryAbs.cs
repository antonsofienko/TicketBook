using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketBook.DataAccessLayer.Repositories
{
  public abstract  class RepositoryAbs<T>:IRepository<T> where T:class
    {
        private DbContext dbContext;
        public RepositoryAbs(DbContext context)
        {
            dbContext = context;
        }
        public IQueryable<T> AllEntities
        {
            get => dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public void Add(T item)
        {
            dbContext.Set<T>().Add(item);
        }

        public void Remove(T item)
        {
            dbContext.Set<T>().Remove(item);
        }

        public void Update(T item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
