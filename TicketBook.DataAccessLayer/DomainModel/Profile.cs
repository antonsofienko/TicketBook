using System;
using System.Collections.Generic;
using System.Text;

namespace TicketBook.DataAccessLayer.DomainModel
{
    public class Profile
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
