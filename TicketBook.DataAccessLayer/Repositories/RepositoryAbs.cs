using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketBook.DataAccessLayer.Repositories
{
  public abstract  class RepositoryAbs<T>:IRepository<T> where T:class
    {
        private readonly DbContext dbContext;
        private object key = new object();
        public RepositoryAbs(DbContext context)
        {
            dbContext = context;
        }
        public IQueryable<T> AllEntities
        {
            get
            {
                dbContext.Set<T>().Load();
                return dbContext.Set<T>();
            }
        }

        public T Find(Predicate<T> predicate)
        {
            List<T> list;
            lock (key)
            {
                list = dbContext.Set<T>().ToList();
            }
           
       
            return list.Find(predicate);
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

        //public object Find(Type entityType, params object[] keyValue)
        //{
        //    return dbContext.Find(entityType, keyValue);
        //}
    }
}
