using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketBook.DataAccessLayer.DomainModel
{
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public decimal Price { get; set; }

        public Guid FlightId { get; set; }

        public int SeatNumber { get; set; }

        public virtual Flight Flight { get; set; }

        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int ComfortLevel { get; set; }
    }
}
