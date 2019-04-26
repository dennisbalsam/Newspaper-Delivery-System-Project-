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
            Application.Run(new Form1());
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
    }
}
