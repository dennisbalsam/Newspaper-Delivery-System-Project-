using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// for storing publication data
namespace newspaper_delivery_system
{
    public class Publication
    {
        string name;
        double price;

        // default constructor
        public Publication(string _name = "NO_NAME", double _price = 0)
        {
            name = _name;
            price = _price;
        }

        // getters and setters
        public string Name
        {
            get { return name;  }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return "Name: " + name + "\nPrice: $" + Convert.ToString(price);
        }

    }
}
