
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TicketBook.DataAccessLayer.DomainModel;

namespace TicketBook.BusinessLayer.Model.Interfaces
{
   public interface ITicketOrder
    {
        Ticket OrderTicket(User user, Flight flight, int comfortLevel, int sitePlace, string bankName, BankData bankData);
    }
}