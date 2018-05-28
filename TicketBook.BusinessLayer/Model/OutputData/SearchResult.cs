using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.DataAccessLayer.DomainModel;

namespace TicketBook.BusinessLayer.Model
{
  public  class SearchResult
    {
        public City ArrivalCity { get; set; }
        public City DepartureCity { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public  decimal TotalCost { get; set; }
        public TimeSpan TotalTime { get; set; }
    }
}
