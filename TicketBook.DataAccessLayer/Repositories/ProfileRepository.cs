
using Microsoft.EntityFrameworkCore;
using TicketBook.DataAccessLayer.DomainModel;
using TicketBook.DataAccessLayer.Repositories;

namespace TicketBook.DataAccessLayer.Repositories
{
    public class ProfileRepository : RepositoryAbs<Profile>
    {
        public ProfileRepository(DbContext context) : base(context) { }
    }
}