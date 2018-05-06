using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketBook.DataAccessLayer.DomainModel
{
    public class Ticket
    {
        public int Id { get; set; }
        public decimal Price { get; set; }

        public int FlightId { get; set; }

        public int SeatNumber { get; set; }

        public virtual Flight Flight { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public virtual int ComfortLevel { get; set; }
    }
}
