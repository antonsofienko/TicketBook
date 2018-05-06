using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.DataAccessLayer.DomainModel;

namespace TicketBook.DataAccessLayer.Repositories
{
    public class CityRepository : RepositoryAbs<City>
    {
        public CityRepository(DbContext context) : base(context) { }
    }
}
