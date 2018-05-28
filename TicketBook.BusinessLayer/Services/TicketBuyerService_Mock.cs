using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.BusinessLayer.Interfaces;
using TicketBook.BusinessLayer.Model;
using TicketBook.BusinessLayer.Model.Interfaces;
using TicketBook.DataAccessLayer;

namespace TicketBook.BusinessLayer.Services
{
   public class TicketBuyerService_Mock: ITicketBuyer
    {
        private readonly IUnitOfWork _uow;
       // private IBankDriver _bankDriver;
        private IBankFactoryMethod _bankFactory;

        public TicketBuyerService_Mock(IBankFactoryMethod bankFactory=null)
        {
            this._bankFactory = bankFactory ?? new BankProvider(); 
        }

        public bool Buy(string bankName,BankData registrationData,decimal amountOfMoney)
        {
            var bankDriver = _bankFactory.CreateBankProvider(bankName);

            bankDriver.Authorization(registrationData);
            bankDriver.Pay(amountOfMoney);


            return true;
        }
    }
}
