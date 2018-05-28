using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using TicketBook.DataAccessLayer;
using TicketBook.DataAccessLayer.DomainModel;

namespace TicketBook.BusinessLayer.Services
{
    public class FlightSeeker
    {
        private readonly IUnitOfWork _uow;

        public FlightSeeker(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public ICollection<Flight> FindFlights(int departureCityId, int arrivalCityId, DateTime departureDate)
        {

            var thisDay = departureDate.Date;
            var nextDay = thisDay.AddDays(1);

            var flights2 = (from flight in _uow.Flights.AllEntities
                            where flight.DepartureCityId == departureCityId &&
                                  flight.ArrivalCityId == arrivalCityId &&
                                  flight.DepartureTime >= thisDay &&
                                  flight.DepartureTime < nextDay
                            select flight).ToList();

            foreach (var item in flights2.ToList())
            {
                item.DepartureCity = _uow.Cities.Find(i => i.Id == item.DepartureCityId);
            }

            return flights2;
        }
    }
}
