using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace newspaper_delivery_system
{

    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new message());
        }
    }

    // data handling functions
    public class DataHandler
    {
        public static string[] getFileLines(string filePath)
        {
            // store data file as text
            string data = File.ReadAllText(filePath);
            // split into lines
            string[] lines = data.Split('\n');

            return lines;
        }

        // data storing functions: return lists of data
        public static List<Carrier> getCarrierData(string dataFilePath)
        {
            // call file line handler: each item is a line of data
            string[] carrierLines = getFileLines(dataFilePath);

            // store data
            List<Carrier> carriers = new List<Carrier>();

            // store carrier data
            foreach (string line in carrierLines)
            {
                string[] tokens = line.Split(','); // separate by comma delimiter

                if (tokens[0] != "name") // skip first row
                {
                    carriers.Add(new Carrier(tokens[0], tokens[1], tokens[2]));
                }
            }

            return carriers;
        }

        public static List<Household> getHouseholdData(string dataFilePath)
        {
            // call file line handler
            string[] householdLines = getFileLines(dataFilePath);

            // store data
            List<Household> households = new List<Household>();

            // store carrier data
            foreach (string line in householdLines)
            {
                string[] tokens = line.Split(',');

                if (tokens[0] != "name") // skip first row
                {
                    households.Add(new Household(tokens[0], tokens[1], tokens[2]));
                }
            }

            return households;
        }

        public static List<Publication> getPublicationData(string dataFilePath)
        {
            // call file line handler
            string[] publicationLines = getFileLines(dataFilePath);

            // store data
            List<Publication> publications = new List<Publication>();

            // store publication data
            foreach (string line in publicationLines)
            {
                string[] tokens = line.Split(',');

                if (tokens[0] != "name") // skip first row
                {
                    publications.Add(new Publication(tokens[0], Convert.ToDouble(tokens[1])));
                }
            }

            return publications;
        }
    }
}


