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
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        // toString
        public override string ToString()
        {
            return "Name: " + name + "\nAddress: " + address + "\nPhone: " + phone;
        }
    }
}
