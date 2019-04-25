using System;
using System.Collections.Generic;
using newspaper_delivery_system;

namespace list_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carrier and Household List test program:\n");

            // lists of households and carriers
            List<Household> householdList = new List<Household>();
            List<Carrier> carrierList = new List<Carrier>();

            // creating test households and carriers
            Household h1 = new Household("Larry Johnson", "19 Mulberry Lane", "3476651433");
            Household h2 = new Household("George Morgan", "62 Far Street", "33345566");

            Carrier c1 = new Carrier("NY Paper Delivery", "18 Broadway","8006345678");
            Carrier c2 = new Carrier("Fast Delivery", "16 Lafayette Blvd.", "3471939445");

            // add households to respective list
            householdList.Add(h1);
            householdList.Add(h2);
            // add carriers to respective list
            carrierList.Add(c1);
            carrierList.Add(c2);


            // display all carriers
            Console.WriteLine("All carriers:\n");
            foreach (Carrier c in carrierList)
            {
                Console.WriteLine(c+"\n");
            }

            // display all households
            Console.WriteLine("\nAll households:\n");
            foreach (Household h in householdList)
            {
                Console.WriteLine(h+"\n");
            }

        }
    }
}
