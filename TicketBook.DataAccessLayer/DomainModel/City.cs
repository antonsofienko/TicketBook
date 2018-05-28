using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketBook.DataAccessLayer.DomainModel
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("ArrivalCity")]
        public virtual ICollection<Flight> FlightsAsArrival { get; set; }

        [InverseProperty("DepartureCity")]
        public virtual ICollection<Flight> FligtsAsDeparture { get; set; }


       // private static int _amountOfField = 2;
        //public static City ParseCVSString(string flightInfo, DbContext db=null) 
        //{
        //    var array = flightInfo.Split(';');

        //    if (array.Length < _amountOfField)
        //        throw new ArgumentException("Wrong input data");

        //    return new City
        //    {
        //        Id = array[0] == "" ? 0 : int.Parse(array[0]),
        //        Name = array[1]
        //    };
        //}
    }
}
