using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.DataAccessLayer.DomainModel;

namespace TicketBook.DataAccessLayer.Repositories
{
   public class FlightRepository:RepositoryAbs<Flight>
    {
       public FlightRepository(DbContext context) : base(context) { }
    }
}
