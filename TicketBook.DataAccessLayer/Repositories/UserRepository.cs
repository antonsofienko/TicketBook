
using Microsoft.EntityFrameworkCore;
using TicketBook.DataAccessLayer.DomainModel;
using TicketBook.DataAccessLayer.Repositories;

namespace TicketBook.DataAccessLayer.Repositories
{
    public class UserRepository : RepositoryAbs<User>
    {
        public UserRepository(DbContext context) : base(context) { }
    }
}