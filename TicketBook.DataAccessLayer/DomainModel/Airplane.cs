using System;
using System.Collections.Generic;
using System.Text;

namespace TicketBook.DataAccessLayer.DomainModel
{
    public class Airplane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeatingPlace { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }


        private static int  _amountOfField=4;
        public static Airplane ParseCVSString(string  flightInfo)
        {
            var array = flightInfo.Split(';');

            if (array.Length < _amountOfField)
                throw new ArgumentException("Wrong input data");

            return new Airplane
            {
                Id=array[0]==""?0: int.Parse(array[0]),
                 Name =array[1],
                 SeatingPlace = array[2] == "" ? 0 : int.Parse(array[2])

            };
        }
    }
}
