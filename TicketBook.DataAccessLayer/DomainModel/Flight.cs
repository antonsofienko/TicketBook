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

        public int AvailableTicket1 { get; set; }
        public int AvailableTicket2 { get; set; }
        public int AvailableTicket3 { get; set; }

        public decimal TicketPrice1 { get; set; }
        public decimal TicketPrice2 { get; set; }
        public decimal TicketPrice3 { get; set; }

        public virtual City ArrivalCity { get; set; }

        public virtual City DepartureCity { get; set; }
    }
}
