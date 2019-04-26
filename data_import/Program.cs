﻿using System;
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
            string[] lines = DataHandler.getFileLines(path + "carriers.csv"); ;

            // store carrier data
            List<Carrier> carriers = new List<Carrier>();

            // store carrier data
            foreach (string line in lines)
            {
                string[] tokens = line.Split(',');

                carriers.Add(new Carrier(tokens[0], tokens[1], tokens[2]));
            }
            
            // display all carriers
            foreach (Carrier c in carriers)
            {
                Console.WriteLine(c + "\n");
            }
            
        }
    }
}