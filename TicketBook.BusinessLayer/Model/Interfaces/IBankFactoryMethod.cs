using System;
using System.Collections.Generic;
using System.Text;
using TicketBook.BusinessLayer.Interfaces;

namespace TicketBook.BusinessLayer.Model
{
    public interface  IBankFactoryMethod
    {
        IBankDriver CreateBankProvider(string bankName);
    }
}
