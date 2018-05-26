using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicketBook.DataAccessLayer;
using TicketBook.DataAccessLayer.DomainModel;

namespace TicketBook.BusinessLayer.Services
{
    public class AirportService
    {
        private readonly IUnitOfWork _uow;

        public AirportService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public List<City> Cities
        {
            get => _uow.Cities.AllEntities.ToList();
        }

        public ICollection<Flight> FindFlights(int departureCityId, int arrivalCityId, DateTime departureDate)
        {
            //if (!_uow.Flights.AllEntities.Any())
            //{

            //}
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


            //var flights2 = (from flight in _uow.Flights.AllEntities
            //                where flight.DepartureCityId == departureCityId &&
            //                      flight.ArrivalCityId == arrivalCityId &&
            //                      flight.DepartureTime >= thisDay &&
            //                      flight.DepartureTime < nextDay
            //                select new Flight
            //                {
            //                     Airplane = _uow.Airplanes.Find(i=>i.Id==flight.AirplaneId),
            //                     AirplaneId = flight.AirplaneId,
            //                     ArivalTime = flight.ArivalTime,
            //                     ArrivalCity = _uow.Cities.Find(i=>i.Id==flight.ArrivalCityId),
            //                     ArrivalCityId= flight.ArrivalCityId,
            //                     AvaliableTicket = flight.AvaliableTicket,
            //                     DepartureCity = _uow.Cities.Find(i=>i.Id==flight.DepartureCityId),
            //                     DepartureCityId  = flight.DepartureCityId,
            //                     DepartureTime =flight.DepartureTime,
            //                     Id = flight.Id
            //                }).ToList();

            //return flights2;

            var flights = (from flight in _uow.Flights.AllEntities
                           where flight.DepartureCityId == departureCityId &&
                                 flight.ArrivalCityId == arrivalCityId &&
                                 flight.DepartureTime >= thisDay &&
                                 flight.DepartureTime < nextDay
                           select new
                           {
                               Id = flight.Id,
                               Airplane = flight.Airplane,
                               ArivalTime = flight.ArivalTime,
                               DepartureCity = flight.DepartureCity,
                               ArrivalCity = flight.ArrivalCity,
                               DepartureTime = flight.DepartureTime
                           }).ToList();



            return flights.ToList().Select(x => new Flight
            {
                Id = x.Id,
                Airplane = x.Airplane,
                ArivalTime = x.ArivalTime,
                DepartureCity = x.DepartureCity,
                ArrivalCity = x.ArrivalCity,
                DepartureTime = x.DepartureTime
            }).ToList();
        }


    }
}
