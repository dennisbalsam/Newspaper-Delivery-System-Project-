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

            // test getters
            Console.WriteLine("Testing getters:");
            Console.WriteLine("Name: " + c3.Name);
            Console.WriteLine("Address: " + c3.Address);
            Console.WriteLine("Phone: " + c3.Phone);
            Console.WriteLine();
            
            // test setters
            Console.WriteLine("Testing setters:");

            c3.Name = "NY Paper Carriers";
                Console.WriteLine("New Name: " + c3.Name);
            c3.Address = "86 Coral Ave";
                Console.WriteLine("New Address: " + c3.Address);
            c3.Phone = "8004499";
                Console.WriteLine("New Phone: " + c3.Phone);
        }
    }
}
