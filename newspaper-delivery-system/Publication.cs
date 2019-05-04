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
        int numSubs = 0; //total amount of people subscribed
        double totalOwed = 0.0; //total owed for all subscirptions

        // default constructor
        public Publication(string _name = "NO_NAME", double _price = 0)
        {
            name = _name;
            price = _price;
        }
        //function to increment amount of subs to publications
        public void incrementSubs()
        {
            numSubs++;
        }
        //function to decrement amount of subs to publications
        public void decrementSubs()
        {
            numSubs--;
        }
        // function to increment total owed between all subs of publication
        public void changeOwed()
        {
            totalOwed = price * numSubs;
        }
        // getters and setters
        public string Name
        {
            get { return name;  }
            set { name = value; }
        }

        public int NumSubs
        {
            get { return numSubs; }
            set { numSubs = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public double TotalOwed
        {
            get { return totalOwed; }
            set { totalOwed = value; }
        }

        public override string ToString()
        {
            return "Name: " + name + " --- Price: $" + Convert.ToString(price);
        }

    }
}
