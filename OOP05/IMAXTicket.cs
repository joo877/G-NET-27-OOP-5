using OOP05.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    internal class IMAXTicket : Ticket , IPrintable , ICansceled , ICloneable
    {
        public string Is3D { get; set; }

        public IMAXTicket(string name, decimal price, string is3D, string booked) : base(name, price += is3D =="Yes" ? 30 : 0,booked)
        {
            Is3D = is3D;

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

        public  void PrintTicket()
        {
            Console.WriteLine($"[Ticket #{TicketId}] | MovieName : {MovieName} | price : {Price} EGP | PriceAfterTax : {PriceAfterTax} EGP | Is3D : {Is3D} | Booked :{Booked}");
        }

        public object Clone() => new IMAXTicket(this.MovieName, this.Price, Is3D, this.Booked);
    }
}
