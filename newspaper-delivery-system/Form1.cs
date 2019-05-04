using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace newspaper_delivery_system
{
    public partial class message : Form
    {
        static string path = @"..\..\..\";

        List<Household> households = DataHandler.getHouseholdData(path + "households.csv");
        List<Carrier> carriers = DataHandler.getCarrierData(path + "carriers.csv");
        List<Publication> publications = DataHandler.getPublicationData(path + "publications.csv");

        BindingSource bs = new BindingSource();
        BindingSource subs = new BindingSource();
        
        public message()
        {
            InitializeComponent();

        }

        // handle exceptions for listbox interaction
        public bool HandleListboxException(ListBox lb)
        {
            if (!lb.Visible) return false;
            return true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Household Info")
            {
                HouseholdInfo();
            }
            else if (comboBox1.SelectedItem.ToString() == "Carriers")
            {
                CarrierInfo();
            }
            else if (comboBox1.SelectedItem.ToString() == "Publications")
            {
                PublicationInfo();
            }
        }
        // Household info function
        public void PublicationInfo()
        {
            dataList.Visible = false;
            welcomelabel2.Visible = false;
            Welcomelabel.Visible = false;
            button1.Visible = true;
            button1.Text = "Display all Households";
            button1.Click += new EventHandler(DisplayallHouseinfo);
            option1.Visible = true;
            option2.Visible = true;
            option3.Visible = true;
            option4.Visible = true;
            option1.Click += new EventHandler(AddNewSubscription);
            option2.Click += new EventHandler(DisplaySubs);
            option3.Click += new EventHandler(RemoveButton);
            option4.Click += new EventHandler(HasSubscriptionButton);



        }
        //Carrier Info Function
        public void CarrierInfo()
        {
            option1.Click -= new EventHandler(AddNewSubscription);
            option2.Click -= new EventHandler(DisplaySubs);
            option3.Click -= new EventHandler(RemoveButton);
            dataList.Visible = false;
            welcomelabel2.Visible = false;
            Welcomelabel.Visible = false;
            button1.Visible = true;
            button1.Text = "Display all Carriers";
            button1.Click += new EventHandler(DisplayallCarrierinfo);
        }
        //Publication Info Function
        public void HouseholdInfo()
        {
            option1.Click -= new EventHandler(AddNewSubscription);
            option2.Click -= new EventHandler(DisplaySubs);
            option3.Click -= new EventHandler(RemoveButton);
            dataList.Visible = false;
            welcomelabel2.Visible = false;
            Welcomelabel.Visible = false;
            button1.Visible = true;
            button1.Text = "Display all Publications";
            button1.Click += new EventHandler(DisplayallPublicationinfo);
        }
        //--------------------------------------REMOVE METHODS GUI--------------------------------------
        //function called when remove sub button is clicked
        public void RemoveButton(object sender, EventArgs e)
        {
            panel1.Visible = false;
            datalist2.Visible = true;
            datalist2.DataSource = households.ElementAt(dataList.SelectedIndex).getAllSubscriptions();
            subOption.Text = "Remove Subscription";
            subOption.Visible = true;
            //Reset button event handling
            subOption.Click -= new EventHandler(addSubscription);
            subOption.Click -= new EventHandler(RemoveSubscirption);
            subOption.Click += new EventHandler(RemoveSubscirption);

        }
        //function of button to actually remove the publication
        public void RemoveSubscirption(object sender, EventArgs e)
        {
            //call method to remove subscription
            households.ElementAt(dataList.SelectedIndex).removeSubscription(datalist2.SelectedIndex);
            //Reset the list of house's subscriptions
            subs.ResetBindings(false);
            //Call the display subscriptions method
            DisplaySubs();
            panel1.Visible = true;
            //Change messages text
            messageBox.Text = "Publication removed from House's subscriptions";
  
        }
        //----------------------------------------------------------------------------------------------
        //-----------------------------------------Has subscription method GUI----------------------------------
        public void HasSubscriptionButton(object sender, EventArgs e)
        {
            //Make message not visible and change text
            panel1.Visible = false;
            subOption.Text = "Check for Subscription";
            //Reset button event handling
            subOption.Click -= new EventHandler(addSubscription);
            subOption.Click -= new EventHandler(RemoveSubscirption);
            subOption.Click -= new EventHandler(CheckforSubscription);
            subOption.Click += new EventHandler(CheckforSubscription);
            subOption.Visible = true;
            //Output the publication data list for selection to be made
            datalist2.DataSource = publications;
            datalist2.Visible = true;

        }
        //Button that actually checks if the house the selected subscription
        public void CheckforSubscription(object sender, EventArgs e)
        {
            // break out of function if dataList.SelectedIndex cannot be obtained
            HandleListboxException(dataList);

            if (households.ElementAt(dataList.SelectedIndex).hasSubscription(publications.ElementAt(datalist2.SelectedIndex)))
                messageBox.Text = "This house has the subscription: " + publications.ElementAt(datalist2.SelectedIndex).Name;
            else
                messageBox.Text = "This house does not have the subscription: " + publications.ElementAt(datalist2.SelectedIndex).Name;
            panel1.Visible = true;
        }






        //--------------------------------------------------------------------------------------------------------

        // ------------------------------------------ADD METHODS GUI----------------------------------------
        //show list of publications to Add a Subscription GUI Function
        public void AddNewSubscription(object sender, EventArgs e)
        {
            panel1.Visible = false;
            subOption.Text = "Add Subscription";
            subOption.Visible = true;
            datalist2.DataSource = publications;
            datalist2.Visible = true;
            //Reset button event handling
            subOption.Click -= new EventHandler(RemoveSubscirption);
            subOption.Click -= new EventHandler(addSubscription);
            subOption.Click += new EventHandler(addSubscription);




        }
        //Button to add the subscirption to a house hold
        public void addSubscription(object sender, EventArgs e)
        {
            //Add the selected publication to the house
            //Check if the house already has this subscription
            if (households.ElementAt(dataList.SelectedIndex).hasSubscription(publications.ElementAt(datalist2.SelectedIndex)) == false)
            {
                households.ElementAt(dataList.SelectedIndex).addSubscription(publications.ElementAt(datalist2.SelectedIndex));
                messageBox.Text = "Publication added to House's Subscriptions";
                panel1.Visible = true;

            }
            //If the house has the subscription then output it and don't add
            else
               messageBox.Text = "Has magazine already";
        }
        // -----------------------------------------------------------------------------------------------

        // -------------------------------DISPLAY LIST FUNCTIONS---------------------------------------------
        //Display current houses subscription LIST  
        public void DisplaySubs(object sender, EventArgs e)
        {

            panel1.Visible = false;
            subOption.Visible = false;
            datalist2.Visible = true;
            subs.DataSource = households.ElementAt(dataList.SelectedIndex).getAllSubscriptions();
            datalist2.DataSource = subs;

        }
        //NON BUTTON display function
        public void DisplaySubs()
        {
            datalist2.Visible = true;
            subs.DataSource = households.ElementAt(dataList.SelectedIndex).getAllSubscriptions();
            datalist2.DataSource = subs;

        }

            //Display all households
            public void DisplayallHouseinfo(object sender, EventArgs e)
        {

            bs.DataSource = households;
            dataList.DataSource = bs;
            dataList.Visible = true;

        }
        //Display all carriers
        public void DisplayallCarrierinfo(object sender, EventArgs e)
        {
            dataList.DataSource = carriers;
            dataList.Visible = true;
        }

        //Display all publications
        public void DisplayallPublicationinfo(object sender, EventArgs e)
        {

            dataList.DataSource = publications;
            dataList.Visible = true;
        }
        //------------------------------------------------------------------------------------------------


        //All form controls
        private void welcomelabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Welcomelabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datalist2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void option1_Click(object sender, EventArgs e)
        {

        }

        private void addSub_Click(object sender, EventArgs e)
        {

        }

        private void option2_Click(object sender, EventArgs e)
        {

        }

        private void option3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
                    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
