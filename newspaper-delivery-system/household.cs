using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newspaper_delivery_system
{
    // Households subscribe to publications and are delivered to by carriers
    public class Household : Carrier
    {
        private List<string> subscriptions = new List<string>(); // Publications household is subscribed to
        private bool suspended; // if household is suspended from receiving delivery

        // getter and setter
        public bool Suspended
        {
            get { return suspended; }
            set { suspended = value; }
        }

        // default constructor with constructor delegation
        public Household(string _name = "NO_NAME", string _address = "NO_ADDRESS", string _phone = "NO_PHONE", bool _suspended = false) : base(_name, _address, _phone)
        {
            suspended = _suspended;
        }

        // subscription methods
        // ====================

        // check if household has subscription
        public bool hasSubscription(string sub)
        {
            // subscription to look for
            string found = subscriptions.Find(item => item == sub);

            if (found == null)
                return false;
            return true;
        }

        // add subscription to list
        public void addSubscription(string sub)
        {
            subscriptions.Add(sub);
        }

        // remove subscription from list
        public bool removeSubscription(string sub)
        {
            int index = -1;
            // check if sub exists
            if (hasSubscription(sub))
            {
                index = subscriptions.FindIndex(item => item == sub);
                subscriptions.RemoveAt(index);
                return true;
            }
            else
                return false;
        }

        // display all subscriptions
        public string getAllSubscriptions()
        {
            string allSubs = ""; // hold all subscriptions

            if (subscriptions.Count == 0)
                return "No subscriptions";

            foreach(string sub in subscriptions)
            {
                allSubs += "\t" + sub + "\n";
            }
            return allSubs;
        }

        // toString
        public override string ToString()
        {
            return base.ToString() + "\nSuspended: " + suspended + "\nSubscriptions: \n" + getAllSubscriptions();
        }
    }
}

