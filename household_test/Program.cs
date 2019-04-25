using System;
using newspaper_delivery_system;

namespace household_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Household class test program:\n");

            // testing default constructor no params
            Console.WriteLine("Testing default constructor no params:");
            Household h1 = new Household();
            Console.WriteLine(h1 + "\n");

            // testing default constructor one param
            Console.WriteLine("Testing default constructor one param:");
            Household h2 = new Household("Johnson Smith");
            Console.WriteLine(h2 + "\n");

            // testing default constructor all params
            Console.WriteLine("Testing default constructor all params:");
            Household h3 = new Household("George Brown", "34 State St.", "347828345", true);
            Console.WriteLine(h3 + "\n");

            // test getter
            Console.WriteLine("Testing getter:");
            Console.WriteLine("Suspended: " + h3.Suspended + "\n");

            // test setter
            Console.WriteLine("Testing setter:");
            h3.Suspended = false;
            Console.WriteLine("Suspended: " + h3.Suspended + "\n");

            // test subscription methods
            h3.addSubscription("Gardening Monthly");
            h3.addSubscription("The Daily News");
            h3.addSubscription("Cycling International");

            // check for subscription
            Console.WriteLine("Checking for 'The Daily News': " + h3.hasSubscription("The Daily News"));

            //  display all subscriptions
            Console.WriteLine("Display all subscriptions:");
            Console.WriteLine(h3.getAllSubscriptions() + "\n");

            // remove subscription
            h3.removeSubscription("The Daily News");
            //  display all subscriptions again
            Console.WriteLine("Display all subscriptions after removal:");
            Console.WriteLine(h3.getAllSubscriptions() + "\n");

            // testing toString with subscriptions
            Console.WriteLine(h3);
        }
    }
}
