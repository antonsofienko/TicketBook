using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.DataAccessLayer;

namespace TicketBook.BusinessLayer.Services
{
 public   class DataService:IDataService
    {
        private readonly IUnitOfWork _uow;

        public DataService(IUnitOfWork uow)
        {
            _uow = uow;
        }
       public IUnitOfWork Repositories { get => _uow; }
    }
}
