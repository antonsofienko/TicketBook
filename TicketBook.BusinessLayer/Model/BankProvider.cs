using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.BusinessLayer.Interfaces;

namespace TicketBook.BusinessLayer.Model
{
 public   class BankProvider:IBankFactoryMethod
    { 
        IBankDriver IBankFactoryMethod.CreateBankProvider(string bankName)
        {
            switch(bankName)
            {
                case "Privat":
                    return new PrivateBankDriver();
                case "WebMoney":
                    return new WebMoneyDriver();
                default:
                    throw new Exception($"Wrong name of bank {bankName}");
            }
        }

    }
}
