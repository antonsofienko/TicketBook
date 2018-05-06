using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.DataAccessLayer;

namespace TicketBook.BusinessLayer.Services
{
 public class FindBestPathService
    {
        IUnitOfWork applicationUnitOfWork;

        public FindBestPathService(IUnitOfWork unitOfWork)
        {
            this.applicationUnitOfWork = unitOfWork;
        }
        public FindBestPathService()
        {
            this.applicationUnitOfWork = new ApplicationUnitOfWork();
        }


    }
}
