using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketBook.DataAccessLayer.DomainModel
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string  UserId { get; set; }
        public bool IsPaid { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
