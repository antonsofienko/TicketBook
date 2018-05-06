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
        T GetById(int id);

        IQueryable<T> AllEntities { get; }
    }
}
