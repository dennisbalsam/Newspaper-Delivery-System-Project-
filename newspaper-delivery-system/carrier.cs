using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newspaper_delivery_system
{
    // Carrier makes deliveries to households
    public class Carrier
    {
        // name, address and phone number
        private string name, address, phone;

        // default constructor
        public Carrier(string _name = "NO_NAME", string _address = "NO_ADDRESS", string _phone = "NO_PHONE")
        {
            name = _name;
            address = _address;
            phone = _phone;
        }

        // getters and setters
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // toString
        public override string ToString()
        {
            return "Name:  " + name + "-- Address: " + address + "-- Phone: " + phone + "--";
        }
    }
}
