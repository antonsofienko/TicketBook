using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBook.Data;

namespace TicketBook.DataAccessLayer
{
    public class InitialFlights
    {
       public void   CreateFlightsEveryWednsday(ApplicationDbContext db)
        {
          
            DateTime date = DateTime.Now;
            Random random = new Random();

            int randomAirplane = 0;
            int randomDepartureCity = 0;
            int randomArrivalCity = 0;
            int randomFlyTime = 0;
            DomainModel.Flight tempFlight;
            for (int i = 0; i < 10; i++)
            {
                randomAirplane = random.Next(db.Airplanes.ToListAsync().Result.Count);
                randomDepartureCity = random.Next(db.Cities.ToListAsync().Result.Count());
                randomArrivalCity = random.Next(db.Cities.ToListAsync().Result.Count());
                randomFlyTime = random.Next(12);

                try
                {
                    tempFlight =new DomainModel.Flight
                    {
                        AirplaneId = randomAirplane,
                        Airplane = db.Airplanes.FindAsync(randomAirplane).Result,

                        ArrivalCityId = randomArrivalCity,
                        ArrivalCity = db.Cities.FindAsync(randomArrivalCity).Result,

                        DepartureCityId = randomDepartureCity,
                        DepartureCity = db.Cities.FindAsync(randomDepartureCity).Result,

                        ArivalTime = date.AddHours(randomFlyTime),
                        DepartureTime = date,

                        AvaliableTicket = db.Airplanes.FindAsync(randomAirplane).Result.SeatingPlace
                    };

                    db.Flights.Add(tempFlight);
                    db.SaveChanges();
                }
                catch(Exception ex)
                {

                }
               
                date.AddDays(random.Next(8));
            }
            
        }
    }
}
