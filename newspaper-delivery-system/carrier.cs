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
        private List<Household> HouseholdsRoute = new List<Household>(); // Households the carrier has on its route
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
            return "Name:  " + name + "-- Address: " + address + "-- Phone: " + phone;
        }

        //Add a household
        public void addHouse (Household house)
        {
            HouseholdsRoute.Add(house);
        }
        //Remove a household
        public void removeHouse (Household house)
        {
            HouseholdsRoute.Remove(house);
        }
        //return all households list
        public List<Household> getAllHouseholds()
        {

            if (HouseholdsRoute.Count == 0)
                return null;

            return HouseholdsRoute;
        }
        //add households to route 
        public void assignHouses(List<Household> allHouses)
        {
            //Empty the routes
            HouseholdsRoute.Clear();
            //Create random number
            Random r = new Random();

            //Lopp a few times 
            for (int x = 0; x < 3; x++)
            {

                int rInt = r.Next(0, allHouses.Count); //get a random number
                HouseholdsRoute.Add(allHouses.ElementAt(rInt));
            }

        }

    }
}
