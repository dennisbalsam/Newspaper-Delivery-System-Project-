using System;
using System.IO;
using System.Collections.Generic;
using newspaper_delivery_system;

namespace data_import
{
    class Program
    {
        static void Main(string[] args)
        {
            // path to csv file
            string path = @"..\..\..\..\";

            // store data: carriers, households and publications
            List<Carrier> carriers = DataHandler.getCarrierData(path + "carriers.csv");
            List<Household> households = DataHandler.getHouseholdData(path + "households.csv");
            List<Publication> publications = DataHandler.getPublicationData(path + "publications.csv");

            // list how many data items there are for each class (should equal csv's num. lines - 1)
            Console.WriteLine("Carriers: " + carriers.Count);
            Console.WriteLine("Households: " + households.Count);
            Console.WriteLine("Publications: " + publications.Count + "\n");

            // display all carriers
            Console.WriteLine("Display all carriers:\n");
            foreach (Carrier c in carriers)
            {
                Console.WriteLine(c + "\n");
            }

            // display all households
            Console.WriteLine("Display all households:\n");
            foreach (Household h in households)
            {
                Console.WriteLine(h + "\n");
            }

            // display all publications
            Console.WriteLine("Display all publications:\n");
            foreach (Publication p in publications)
            {
                Console.WriteLine(p + "\n");
            }


        }
    }
}
