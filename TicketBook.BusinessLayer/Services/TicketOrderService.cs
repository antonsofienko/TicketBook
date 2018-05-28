
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TicketBook.BusinessLayer.Model.Interfaces;
using TicketBook.DataAccessLayer;

namespace TicketBook.BusinessLayer.Services
{
    public class TicketOrderService
    {
        ITicketBuyer _ticketBuyer;
        IUnitOfWork _uow;

        public TicketOrderService(IUnitOfWork uow, ITicketBuyer ticketBuyer =null)
        {
            this._ticketBuyer = ticketBuyer ?? new TicketBuyerService_Mock();
        }

        public bool OrderTicket() { return true; }

    }

}