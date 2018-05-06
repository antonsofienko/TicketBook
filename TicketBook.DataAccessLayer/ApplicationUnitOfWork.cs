using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.DataAccessLayer.DomainModel;
using TicketBook.DataAccessLayer.Repositories;

namespace TicketBook.DataAccessLayer
{
 public   class ApplicationUnitOfWork:IDisposable,IUnitOfWork
    {
        private DbContext db;


        private AirplaneRepository airplaneRepository;
        private CityRepository cityRepository;
        private FlightRepository flightRepository;
        //private OrderedTicketRepository orderedTicketRepository;
        private ProfileRepository profileRepository;
        private TicketRepository ticketRepository;
        private UserRepository userRepository;
        private OrderRepository orderRepository;


        public IRepository<Airplane> Airplanes
        {
            get
            {
                if (airplaneRepository == null)
                {
                    airplaneRepository = new AirplaneRepository(db);
                }
                return airplaneRepository;
            }
        }

        public IRepository<City> Cities
        {
            get
            {
                if (cityRepository == null)
                {
                    cityRepository = new CityRepository(db);
                }
                return cityRepository;
            }
        }

        public IRepository<Flight> Flights
        {
            get
            {
                if (flightRepository == null)
                {
                    flightRepository = new FlightRepository(db);
                }
                return flightRepository;
            }
        }

        public IRepository<Profile> Profiles
        {
            get
            {
                if (profileRepository == null)
                {
                    profileRepository = new ProfileRepository(db);
                }
                return profileRepository;
            }
        }

        public IRepository<Ticket> Tickets
        {
            get
            {
                if (ticketRepository == null)
                {
                    ticketRepository = new TicketRepository(db);
                }
                return ticketRepository;
            }
        }

        public IRepository<ApplicationUser> Users
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(db);
                }
                return userRepository;
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                {
                    orderRepository = new OrderRepository(db);
                }
                return orderRepository;
            }
        }

        //---------------------------------


        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
