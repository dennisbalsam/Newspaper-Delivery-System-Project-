using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace newspaper_delivery_system
{
    // Households subscribe to publications and are delivered to by carriers
    public class Household : Carrier
    {
        private List<string> subscriptions; // Publications household is subscribed to
        private bool suspended; // if household is suspended from receiving delivery

        // getter and setter
        public bool Suspended { get; set; }

        // default constructor with constructor delegation
        public Household(string _name = "NO_NAME", string _address = "NO_ADDRESS", string _phone = "NO_PHONE", bool _suspended = false) : base(_name, _address, _phone)
        {
            suspended = _suspended;
        }

        // toString
        public override string ToString()
        {
            return base.ToString() + "\nSuspended: " + suspended;
        }
    }
}
