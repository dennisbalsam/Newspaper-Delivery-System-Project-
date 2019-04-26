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

            // call file line handler
            string[] carrierLines = DataHandler.getFileLines(path + "carriers.csv");
            string[] householdLines = DataHandler.getFileLines(path + "households.csv");
            string[] publicationLines = DataHandler.getFileLines(path + "publications.csv");

            // store data
            List<Carrier> carriers = new List<Carrier>();
            List<Household> households = new List<Household>();
            List<Publication> publications = new List<Publication>();

            // store carrier data
            foreach (string line in carrierLines)
            {
                string[] tokens = line.Split(',');

                if (tokens[0] != "name") // skip first row
                {
                    carriers.Add(new Carrier(tokens[0], tokens[1], tokens[2]));
                }
            }
            // store household data
            foreach (string line in householdLines)
            {
                string[] tokens = line.Split(',');

                if (tokens[0] != "name") // skip first row
                {
                    households.Add(new Household(tokens[0], tokens[1], tokens[2]));
                }
            }
            // store publication data
            foreach (string line in publicationLines)
            {
                string[] tokens = line.Split(',');

                if (tokens[0] != "name") // skip first row
                {
                    publications.Add(new Publication(tokens[0], Convert.ToDouble(tokens[1])));
                }
            }

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
