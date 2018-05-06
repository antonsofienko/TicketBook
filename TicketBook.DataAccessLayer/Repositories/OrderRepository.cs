using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBook.DataAccessLayer.DomainModel;
using TicketBook.DataAccessLayer.Repositories;

namespace  TicketBook.DataAccessLayer.Repositories
{
    public class OrderRepository : RepositoryAbs<Order>
    {
        public OrderRepository(DbContext context) : base(context) { }
    }
}
