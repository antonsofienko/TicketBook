using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.DataAccessLayer.DomainModel;
using TicketBook.DataAccessLayer.Repositories;

namespace TicketBook.DataAccessLayer
{
 public interface IUnitOfWork
    {
        IRepository<Airplane> Airplanes { get; }
        IRepository<City> Cities { get; }
        IRepository<Flight> Flights { get; }
        IRepository<Order> Orders { get; }
        //IRepository<Profile> Profiles { get; }
        IRepository<Ticket> Tickets { get; }
        IRepository<User> Users { get; }

        void Save();
    }
}
