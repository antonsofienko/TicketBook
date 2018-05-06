using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.DataAccessLayer.DomainModel;

namespace TicketBook.DataAccessLayer.Repositories
{
 public   class AirplaneRepository:RepositoryAbs<Airplane>
    {
        public AirplaneRepository(DbContext context) : base(context) { }
    }
}
