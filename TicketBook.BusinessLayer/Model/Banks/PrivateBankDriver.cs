using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.BusinessLayer.Interfaces;

namespace TicketBook.BusinessLayer.Model
{
 public   class PrivateBankDriver:IBankDriver
    {
       public IBankBankResult Authorization(BankData bankData)
        {
            throw new NotImplementedException();
        }
       public IBankOperationResult Pay(decimal amountOfMoney)
        {
            throw new NotImplementedException();
        }
    }
}
