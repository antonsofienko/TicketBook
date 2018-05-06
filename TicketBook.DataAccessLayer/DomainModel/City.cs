using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketBook.DataAccessLayer.DomainModel
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("ArrivalCity")]
        public virtual ICollection<Flight> FlightsAsArrival { get; set; }

        [InverseProperty("DepartureCity")]
        public virtual ICollection<Flight> FligtsAsDeparture { get; set; }
    }
}
