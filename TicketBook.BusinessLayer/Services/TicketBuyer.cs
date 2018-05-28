using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.BusinessLayer.Interfaces;
using TicketBook.BusinessLayer.Model;
using TicketBook.DataAccessLayer;

namespace TicketBook.BusinessLayer.Services
{
   public class TicketBuyer
    {
        private readonly IUnitOfWork _uow;
        private IBankDriver _bankDriver;
        private IBankFactoryMethod _bankFactory;

        public TicketBuyer(IUnitOfWork uow)
        {
            _uow = uow;
        }
    }
}
