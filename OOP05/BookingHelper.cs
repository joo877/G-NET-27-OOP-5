using OOP05.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    internal class BookingHelper
    {

        public static void print(IPrintable[] printable) {


            for (int i = 0; i < printable.Length; i++)
            {
               printable[i].PrintTicket();
            }




        }
        
        
    }
}
