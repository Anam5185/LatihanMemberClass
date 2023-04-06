using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class PlaneTicket
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int Cost { get; set; }
        public string Currency { get; set; }

        public void PrintSummary()
        {
            string convert = "";
            if (Currency == "USD")
            {
                convert = "IDR";
            }
            else if (Currency == "IDR")
            {
                convert = "USD";
            }

            int convertcurrency = 0;
            if (Currency == "USD")
            {
                convertcurrency = Cost * 15000;
            }
            else if (Currency == "IDR")
            {
                convertcurrency = Cost / 15000;
            }

            Console.WriteLine("Origin: {0}", Origin);
            Console.WriteLine("Destination: {0}", Destination);
            Console.WriteLine("Cost: {0} ({1})", Cost,Currency);
            Console.WriteLine("Convert to {0}: {1}\n", convert,convertcurrency);
        }
    }
}
