using System;
using System.Collections.Generic;
using System.Text;

namespace TicketBook.DataAccessLayer.DomainModel
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int ProfileId { get; set; }
        public bool IsPaid { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
