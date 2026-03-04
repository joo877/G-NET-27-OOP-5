using OOP05.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    internal class Ticket 
    {

        private decimal _price;
        public string MovieName { get; set; }
        public string Booked { get; set; }


        public decimal PriceAfterTax => _price + _price * .14m;

        private static int ticketCounter = 0;

        public int TicketId { get; }
        public decimal Price
        {
            get { return _price; }
            set
            {

                if (value > 0)
                    _price = value;
            }
        }

        public Ticket(string name, decimal price,string isbooked )
        {
            MovieName = name;
            Price = price;
            Booked = isbooked;
            ticketCounter++;
            TicketId = ticketCounter;


        }

      
    }
}
