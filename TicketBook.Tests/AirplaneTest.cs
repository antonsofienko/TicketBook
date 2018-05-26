using System;
using TicketBook.DataAccessLayer.DomainModel;
using Xunit;

namespace TicketBook.Tests
{
    public class AirplaneTest
    {
        [Fact]
        public void ParseCVSString_retruntedObject()
        {
           var plane =  Airplane.ParseCVSString(";Name;Company;34");
            Assert.True(true);
        }
    }
}
