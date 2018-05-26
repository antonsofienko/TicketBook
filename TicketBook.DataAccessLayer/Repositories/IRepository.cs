using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketBook.DataAccessLayer.Repositories
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        T Find(Predicate<T> predicate);

        //object Find(T item);
        IQueryable<T> AllEntities { get; }
    }
}
