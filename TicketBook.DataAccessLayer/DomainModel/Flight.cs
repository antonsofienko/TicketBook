using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketBook.DataAccessLayer.DomainModel
{
    public class Flight
    {
        public int Id { get; set; }
        public int AirplaneId { get; set; }
        public int ArrivalCityId { get; set; }
        public int DepartureCityId { get; set; }
        public DateTime ArivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public virtual Airplane Airplane { get; set; }

        public int AvaliableTicket { get; set; }
        public virtual City ArrivalCity { get; set; }

        public virtual City DepartureCity { get; set; }
    }
}
