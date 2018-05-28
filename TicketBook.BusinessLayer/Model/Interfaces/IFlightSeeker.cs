
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TicketBook.DataAccessLayer.DomainModel;

namespace TicketBook.BusinessLayer.Model.Interfaces
{
    public interface IFlightSeeker
    {
        ICollection<Flight> FindFlights(Guid departureCityId, Guid arrivalCityId, DateTime departureDate);
    }
}