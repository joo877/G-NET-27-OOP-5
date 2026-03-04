using OOP05.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    internal class Cinema
    {
        private IPrintable[] _ticket = new IPrintable[20];

        public void AddTicket(IPrintable T)
        {
            for (int i = 0; i < _ticket.Length; i++)
            {
                if (_ticket[i] == null)
                {
                    _ticket[i] = T;
                    return;
                }


            }


        }
        public void PrintAllTickets()
        {
            for (int i = 0; i < _ticket.Length; i++)
            {
                if (_ticket[i] != null)
                   _ticket[i].PrintTicket();


            }

        }


        public void OpenCinema() => Console.WriteLine("=== Cinema Opened ===");
        public void CloseCinema() => Console.WriteLine("=== Cinema Closed ===");
    }
}
