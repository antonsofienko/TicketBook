
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TicketBook.BusinessLayer.Model.Interfaces
{
    public interface ITicketBuyer
    {

       bool Buy(string bankName, BankData registrationData, decimal amountOfMoney);
    }
}