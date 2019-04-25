using System;
using newspaper_delivery_system;

namespace carrier_test
{
    class Program
    {
        static void Main(string[] args)
        {
            // testing default constructor with default params
            Console.WriteLine("Testing default constructor with default params:");
            Carrier c1 = new Carrier();
            Console.WriteLine(c1 + "\n");

            // testing default constructor with one param
            Console.WriteLine("Testing default constructor with one param:");
            Carrier c2 = new Carrier("United Delivery");
            Console.WriteLine(c2 + "\n");

            // testing default constructor with all params
            Console.WriteLine("Testing default constructor with all params:");
            Carrier c3 = new Carrier("United Delivery", "101 Mulberry Lane", "8008784848");
            Console.WriteLine(c3 + "\n");

        }
    }
}
