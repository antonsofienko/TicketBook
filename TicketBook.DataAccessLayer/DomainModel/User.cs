using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TicketBook.DataAccessLayer.DomainModel;

namespace  TicketBook
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class User : IdentityUser
    {
        public virtual ICollection<Order> Orders { get; set; }
    }
}
