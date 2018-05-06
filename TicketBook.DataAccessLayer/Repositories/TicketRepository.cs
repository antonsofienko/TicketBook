
using Microsoft.EntityFrameworkCore;
using TicketBook.DataAccessLayer.DomainModel;
using TicketBook.DataAccessLayer.Repositories;


namespace  TicketBook.DataAccessLayer.Repositories
{
    public class TicketRepository : RepositoryAbs<Ticket>
    {
        public TicketRepository(DbContext context) : base(context) { }
    }
}