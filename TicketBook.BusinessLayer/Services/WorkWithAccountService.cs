using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.DataAccessLayer;

namespace TicketBook.BusinessLayer.Services
{
 public   class WorkWithAccountService
    {
        IUnitOfWork applicationUnitOfWork;

        public WorkWithAccountService(IUnitOfWork unitOfWork)
        {
            this.applicationUnitOfWork = unitOfWork;
        }
        public WorkWithAccountService()
        {
            this.applicationUnitOfWork = new ApplicationUnitOfWork();
        }



    }
}
