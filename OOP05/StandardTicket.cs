using OOP05.interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    internal class StandardTicket : Ticket , IPrintable , ICansceled,ICloneable
    {
        public string SeatNumber { get; set; }
        public StandardTicket(string name, decimal price, string seat,string booked) : base(name, price, booked)
        {
            SeatNumber = seat;
        }

        public void Cansceled()
        {
            if (Booked == "Yes")
            {
                Booked = "No";
            }
            else
            {
                Console.WriteLine("Cannot Cansle ... this Ticket is not Booked ");
            }
        }




        public void PrintTicket()
        {
            Console.WriteLine($"[Ticket #{TicketId}] | MovieName : {MovieName} | price : {Price} EGP | PriceAfterTax : {PriceAfterTax} EGP | Seat: {SeatNumber} | Boocked : {Booked}");
        }

        public object Clone() => new StandardTicket(this.MovieName, this.Price, SeatNumber, this.Booked);


    }
}
