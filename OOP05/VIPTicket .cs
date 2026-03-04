using OOP05.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    internal class VIPTicket: Ticket ,IPrintable, ICansceled,ICloneable
    {
        public string LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; } = 50;
        public VIPTicket(string name, decimal price, string loungeAccess, decimal serviceFee, string booked) : base(name, price, booked)
        {
            LoungeAccess = loungeAccess;
            ServiceFee = serviceFee;
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
            Console.WriteLine($"[Ticket #{TicketId}] | MovieName : {MovieName} | price : {Price} EGP | PriceAfterTax : {PriceAfterTax} EGP | LoungeAccess : {LoungeAccess} | ServiceFee : {ServiceFee} EGP | Booked : {Booked}");
        }


        public object Clone() => new VIPTicket(this.MovieName, this.Price, LoungeAccess,ServiceFee, this.Booked);

    }
}
