using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PlaneTicket plane = new PlaneTicket();
            PlaneTicket plane2 = new PlaneTicket();

            plane.Origin = "JOGJA";
            plane.Destination = "PKU";
            plane.Cost = 100;
            plane.Currency = "USD";

            plane.PrintSummary();

            plane2.Origin = "JKT";
            plane2.Destination = "PKU";
            plane2.Cost = 75000;
            plane2.Currency = "IDR";

            plane2.PrintSummary();

            Console.ReadKey();
        }
    }
}
