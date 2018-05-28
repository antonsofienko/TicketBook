using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicketBook.BusinessLayer.Model;
using TicketBook.BusinessLayer.Model.Interfaces;
using TicketBook.DataAccessLayer;
using TicketBook.DataAccessLayer.DomainModel;

namespace TicketBook.BusinessLayer.Services
{
    public class AirportService
    {
        private readonly IUnitOfWork _uow;
        private IFlightSeeker _flightSeeker;
        private ITicketOrder _ticketOrder;

        public AirportService(IUnitOfWork uow)
        {
            _uow = uow;
        }


        public List<City> Cities
        {
            get => _uow.Cities.AllEntities.ToList();
        }

        public Ticket OrderTicket(User user, Flight flight, int comfortLevel, int sitePlace, string bankName, BankData bankData)
        {
            return _ticketOrder.OrderTicket(user, flight, comfortLevel, sitePlace, bankName, bankData);
        }

        public ICollection<Flight> FindFlights(Guid departureCityId, Guid arrivalCityId, DateTime departureDate)
        {
            return _flightSeeker.FindFlights(departureCityId, arrivalCityId, departureDate);
        }


    }
}
