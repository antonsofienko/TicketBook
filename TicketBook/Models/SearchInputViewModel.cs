using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketBook.Models
{
    public class SearchInputViewModel
    {
        public int DepartureCityId { get; set; }
        public int ArrivalCityId { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string OrderField { get; set; }
        public string OrderDirection { get; set; }
    }
}
