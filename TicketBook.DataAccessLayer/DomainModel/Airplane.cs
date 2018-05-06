using System;
using System.Collections.Generic;
using System.Text;

namespace TicketBook.DataAccessLayer.DomainModel
{
    public class Airplane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public int SeatingPlace { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
