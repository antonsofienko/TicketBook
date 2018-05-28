
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TicketBook.BusinessLayer.Model;
using TicketBook.BusinessLayer.Model.Interfaces;
using TicketBook.DataAccessLayer;
using TicketBook.DataAccessLayer.DomainModel;

namespace TicketBook.BusinessLayer.Services
{
    public class TicketOrderService
    {
        ITicketBuyer _ticketBuyer;
        IUnitOfWork _uow;

        public TicketOrderService(IUnitOfWork uow, ITicketBuyer ticketBuyer = null)
        {
            this._ticketBuyer = ticketBuyer ?? new TicketBuyerService_Mock();
        }

        public Ticket OrderTicket(User user, Flight flight,int comfortLevel,int sitePlace, string bankName, BankData bankData)
        {
            //todo:check comfortLevel, sitePlace

            var order = new Order
            {
                IsPaid = true,
                OrderDate = DateTime.Now,
                User = user,
                UserId = user.Id
            };


            var ticket = new Ticket
            {
                Flight = flight,
                FlightId = flight.Id,
                Order = order,
                OrderId = order.Id
            };

            if (!_ticketBuyer.Buy(bankName, bankData, ticket.Price)) return null;




            _uow.Orders.Add(order);
            _uow.Tickets.Add(ticket);

            _uow.Save();

            return ticket;
        }

    }

}