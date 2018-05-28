using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.BusinessLayer.Model;

namespace TicketBook.BusinessLayer.Interfaces
{
    public interface IBankDriver
    {
        IBankBankResult Authorization(BankData bankData);
        IBankOperationResult Pay(decimal amountOfMoney);      
    }
}
