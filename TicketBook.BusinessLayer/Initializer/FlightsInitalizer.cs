using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TicketBook.Data;
using TicketBook.DataAccessLayer;

namespace TicketBook.BusinessLayer
{
    //public class FlightsInitalizer
    //{
    //    public static async Task InitializeAsync(IUnitOfWork db)
    //    {

    //        DateTime date = DateTime.Now;
    //        Random random = new Random();

    //        int randomAirplane = 0;
    //        int randomDepartureCity = 0;
    //        int randomArrivalCity = 0;
    //        int randomFlyTime = 0;
    //        DataAccessLayer.DomainModel.Flight tempFlight;
    //        for (int i = 0; i < 10; i++)
    //        {
    //            randomAirplane = random.Next(db.Airplanes.AllEntities.ToListAsync().Result.Count);
    //            randomDepartureCity = random.Next(db.Cities.AllEntities.ToListAsync().Result.Count);
    //            randomArrivalCity = random.Next(db.Cities.AllEntities.ToListAsync().Result.Count);

    //            randomFlyTime = random.Next(12);

    //            try
    //            {
    //                tempFlight = new DataAccessLayer.DomainModel.Flight
    //                {
    //                    AirplaneId = randomAirplane,
    //                    Airplane = db.Airplanes.Find(randomAirplane).Result,

    //                    ArrivalCityId = randomArrivalCity,
    //                    ArrivalCity = db.Cities.FindAsync(randomArrivalCity).Result,

    //                    DepartureCityId = randomDepartureCity,
    //                    DepartureCity = db.Cities.FindAsync(randomDepartureCity).Result,

    //                    ArivalTime = date.AddHours(randomFlyTime),
    //                    DepartureTime = date,

    //                    AvaliableTicket = db.Airplanes.FindAsync(randomAirplane).Result.SeatingPlace
    //                };

    //                db.Flights.Add(tempFlight);
    //               // db.SaveAsync();
    //            }
    //            catch (Exception ex)
    //            {

    //            }

    //            date.AddDays(random.Next(8));
    //        }
    //    }
    //}
}
