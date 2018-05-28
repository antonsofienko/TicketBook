using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.DataAccessLayer;

namespace TicketBook.BusinessLayer.Services
{
    public interface  IDataService
    {
        IUnitOfWork Repositories { get; }
    }
}
