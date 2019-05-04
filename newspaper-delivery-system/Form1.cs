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
        BindingSource carrierlist = new BindingSource();
        BindingSource subs = new BindingSource();
        
        public message()
        {
            InitializeComponent();

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
            else if (comboBox1.SelectedItem.ToString() == "Billing")
            {
                BillingInfo();
            }
        }

        // Billing info function
        public void BillingInfo()
        {
            PublicationsButtonsNotVisible();
            CarrierButtonsNotVisible();
            HouseholdButtonsNotVisible();
            
            DisplayallHouseinfo();
            dataList.Visible = true;
            welcomelabel2.Visible = false;
            Welcomelabel.Visible = false;
           
            option2.Location = new Point(435, 430);
            option2.Click += new EventHandler(DisplaySubs);
            button1.Visible = false;
            billingButton.Location = new Point(261, 430);
            billingButton.Text = "View Total Owed";
            billingButton.Click += new EventHandler(viewBill);



        }

        // Household info function
        public void PublicationInfo()
        {
            PublicationsButtonsVisible();
            CarrierButtonsNotVisible();
            BillingButtonsNotVisible();
            HouseholdButtonsNotVisible();
            dataList.Visible = false;
            welcomelabel2.Visible = false;
            Welcomelabel.Visible = false;
            DisplayallHouseinfo();
            PublicationsButtonsVisible();
            option1.Click += new EventHandler(AddNewSubscription);
            option3.Click += new EventHandler(RemoveButton);
            option4.Click += new EventHandler(HasSubscriptionButton);



        }
        //Carrier Info Function
        public void CarrierInfo()
        {
            PublicationsButtonsNotVisible();
            HouseholdButtonsNotVisible();
            BillingButtonsNotVisible();
            CarrierButtonsVisible();
            DisplayallCarrierinfo();
            option5.Click += new EventHandler(CarrierRoutesButton);
            option6.Click += new EventHandler(AddCarrierButton);
            option7.Click += new EventHandler(RemoveCarrierButton);
            option8.Click += new EventHandler(ModifyCarrierButton);
            dataList.Visible = true;
            welcomelabel2.Visible = false;
            Welcomelabel.Visible = false;

            
        }
        //Publication Info Function
        public void HouseholdInfo()
        {
            PublicationsButtonsNotVisible();
            CarrierButtonsNotVisible();
            HouseholdButtonsVisible();
            BillingButtonsNotVisible();
            DisplayallHouseinfo();
            dataList.Visible = true;
            welcomelabel2.Visible = false;
            Welcomelabel.Visible = false;
            option9.Click += new EventHandler(AddHouseholdButton);
            option10.Click += new EventHandler(DeleteHouseholdButton);
            option11.Click += new EventHandler(ModifyInfoButton);
            option12.Click += new EventHandler(SuspendHouseholdButton);
        
        }
        //-----------------------------------------------------------------------PUBLICATIONS SECTION-----------------------------------------------------
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

        //--------------------------------------------------------------------------------END PUBLICATIONS -------------------------------------------------------

        //-----------------------------------------------------------------------------Carrier Functions Section-----------------------------------------------------
        //-Carrier Routes Button
        public void CarrierRoutesButton(object sender, EventArgs e)
        {
            
            //Make label not visible
            panel1.Visible = false;
            //make text boxes not visible 
            nameLabel.Visible = false;
            phoneLabel.Visible = false;
            addressLabel.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
           
            // add event handler 
            carrierSubOption.Click -= new EventHandler(AddCarrier);
            carrierSubOption.Click -= new EventHandler(RemoveCarrier);
            carrierSubOption.Click -= new EventHandler(ModifyCarrier);
            carrierSubOption.Click += new EventHandler(ViewCarrierRoutes);
            
            //Change text and location
            carrierSubOption.Text = "Check Routes";
            carrierSubOption.Visible = true;
            carrierSubOption.Location = new Point(435, 430);
        
        }
        //Actually adding a route button
        public void ViewCarrierRoutes(object sender, EventArgs e)
        {
            //Assign the carrier routes
            carriers.ElementAt(dataList.SelectedIndex).assignHouses(households);
            // Output it in the second datalist
            datalist2.DataSource = carriers.ElementAt(dataList.SelectedIndex).getAllHouseholds();
            datalist2.Visible = true;
        }
        //-----------------------------------------------------------------Add carrier button
        public void AddCarrierButton(object sender, EventArgs e)
        {
            panel1.Visible = false;
            //Make sure textboxes are empty
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            //Hide the carrier list
            button1.Visible = false;
            
            datalist2.Visible = false;

            //make text boxes visible for data entry
            nameLabel.Visible = true;
            phoneLabel.Visible = true;
            addressLabel.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

            //Remove old event handling, and add new one
            carrierSubOption.Text = "Add Carrier";
            carrierSubOption.Visible = true;
            carrierSubOption.Click -= new EventHandler(ViewCarrierRoutes);
            carrierSubOption.Click -= new EventHandler(AddCarrier);
            carrierSubOption.Click -= new EventHandler(ModifyCarrier);
            carrierSubOption.Click -= new EventHandler(RemoveCarrier);
            carrierSubOption.Click += new EventHandler(AddCarrier);


        }
        //Actually adding a carrier
        public void AddCarrier(object sender, EventArgs e)
        {
  
            //Local Variables
            string name, address, phone;
            //Set variables to textbox data
            name = textBox1.Text;
            phone = textBox2.Text;
            address = textBox3.Text;

       
            //Create a temp carrier
            Carrier newCarrier = new Carrier(name, address, phone);

            //Add the new carrier to the list of carriers
            carriers.Add(newCarrier);
            // Update list of carriers
            carrierlist.ResetBindings(false);

            //Display label
            panel1.Visible = true;
            messageBox.Text = "Carrier Added";

            //Display new addition
            dataList.Visible = true;
            DisplayallCarrierinfo();
            dataList.SelectedIndex= carrierlist.Count - 1;

            //Make sure textboxes are empty
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();

        }
        //--------------------------------Remove carrier button---------------------------------
        public void RemoveCarrierButton(object sender, EventArgs e)
        {
            //make messgae not visible
            panel1.Visible = false;
            //change location of button
            carrierSubOption.Location = new Point(435, 430);
            
            //make text boxes not visible 
            nameLabel.Visible = false;
            phoneLabel.Visible = false;
            addressLabel.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;

           

            //Remove old event handling, and add new one
            carrierSubOption.Text = "Remove Carrier";
            carrierSubOption.Visible = true;
            carrierSubOption.Click -= new EventHandler(ViewCarrierRoutes);
            carrierSubOption.Click -= new EventHandler(AddCarrier);
            carrierSubOption.Click -= new EventHandler(ModifyCarrier);
            carrierSubOption.Click -= new EventHandler(RemoveCarrier);
            carrierSubOption.Click += new EventHandler(RemoveCarrier);


        }
        //Actually adding a carrier
        public void RemoveCarrier(object sender, EventArgs e)
        {
            //get selected index and delete it from list
            carrierlist.RemoveAt(dataList.SelectedIndex);
            //reset the carrier list
            carrierlist.ResetBindings(false);
            DisplayallCarrierinfo();
            //indicate it has been removed
            messageBox.Text = "Carrier has been removed, # of carriers = " + (carrierlist.Count - 1);
            panel1.Visible = true;


        }
        //---------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------Modify carrier button
        public void ModifyCarrierButton(object sender, EventArgs e)
        {
            carrierSubOption.Location = new Point(435, 430);
            panel1.Visible = false;
            //Make sure textboxes are empty
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();

            //make text boxes visible for data entry
            nameLabel.Visible = true;
            phoneLabel.Visible = true;
            addressLabel.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

            //Remove old event handling, and add new one
            carrierSubOption.Text = "Modify Carrier";
            carrierSubOption.Visible = true;
            carrierSubOption.Click -= new EventHandler(ViewCarrierRoutes);
            carrierSubOption.Click -= new EventHandler(AddCarrier);
            carrierSubOption.Click -= new EventHandler(RemoveCarrier);
            carrierSubOption.Click -= new EventHandler(ModifyCarrier);
            carrierSubOption.Click += new EventHandler(ModifyCarrier);


        }
        //Actually adding a carrier
        public void ModifyCarrier(object sender, EventArgs e)
        {
            
            //Local Variables
            string name, address, phone;
            //Set variables to textbox data
            if (String.IsNullOrEmpty(textBox1.Text) == false)
            {
                name = textBox1.Text;
                carriers.ElementAt(dataList.SelectedIndex).Name = name;
            }
            if (String.IsNullOrEmpty(textBox2.Text) == false)
            {
                phone = textBox2.Text;
                carriers.ElementAt(dataList.SelectedIndex).Phone = phone;
            }
            if (String.IsNullOrEmpty(textBox3.Text) == false)
            {
                address = textBox3.Text;
                carriers.ElementAt(dataList.SelectedIndex).Address = address;
            }

            

           
            // Update list of carriers
            carrierlist.ResetBindings(false);

            //Display label
            panel1.Visible = true;
            messageBox.Text = "Carrier Info Modified";

            //Display new addition
            DisplayallCarrierinfo();
           

            //Make sure textboxes are empty
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();

        }
        //-------------------------------------------------------End carrier functions-------------------------------------------------------------
        //-----------------------------------------------------------Household Functions---------------------------------------------------------------
        //Function for the button itself to add house
        public void AddHouseholdButton(object sender, EventArgs e)
        {
            panel1.Visible = false;
            //Make sure textboxes are empty
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            //Hide the carrier list
            
            datalist2.Visible = false;

            //make text boxes visible for data entry
            nameLabel.Visible = true;
            phoneLabel.Visible = true;
            addressLabel.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            //add suboption
            householdSubOption.Location = new Point(435, 430);
            householdSubOption.Text = "Add House";
            householdSubOption.Visible = true;
            householdSubOption.Click -= new EventHandler(AddHousehold);
            householdSubOption.Click -= new EventHandler(DeleteHousehold);
            householdSubOption.Click -= new EventHandler(ModifyInfo);
            householdSubOption.Click -= new EventHandler(SuspendHouse);
            householdSubOption.Click += new EventHandler(AddHousehold);
        }
        //Sub button to add house
        public void AddHousehold(object sender, EventArgs e)
        {

            //Local Variables
            string name, address, phone;
            //Set variables to textbox data
            name = textBox1.Text;
            phone = textBox2.Text;
            address = textBox3.Text;


            //Create a temp household
           Household newHouse = new Household(name, address, phone);

            //Add the new carrier to the list of households
            households.Add(newHouse);
            // Update list of households
            bs.ResetBindings(false);

            //Display label
            panel1.Visible = true;
            messageBox.Text = "Household Added";

            //Display new addition
            dataList.Visible = true;
            DisplayallHouseinfo();
            dataList.SelectedIndex = bs.Count - 1;

            //Make sure textboxes are empty
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();

        }

        //Function for the delete household button
        public void DeleteHouseholdButton(object sender, EventArgs e)
        {
            //make messgae not visible
            panel1.Visible = false;
            //change location of button
            householdSubOption.Location = new Point(435, 430);
         
            //make text boxes not visible 
            nameLabel.Visible = false;
            phoneLabel.Visible = false;
            addressLabel.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;



            //Remove old event handling, and add new one
            householdSubOption.Visible = true;
            householdSubOption.Text = "Remove Household";
            householdSubOption.Click -= new EventHandler(AddHousehold);
            householdSubOption.Click -= new EventHandler(DeleteHousehold);
            householdSubOption.Click -= new EventHandler(ModifyInfo);
            householdSubOption.Click -= new EventHandler(SuspendHouse);
            householdSubOption.Click += new EventHandler(DeleteHousehold);
        }
        //Sub button to delete house
        public void DeleteHousehold(object sender, EventArgs e)
        {
            //get selected index and delete it from list
            bs.RemoveAt(dataList.SelectedIndex);
            //reset the carrier list
            bs.ResetBindings(false);
            DisplayallHouseinfo();
            //indicate it has been removed
            messageBox.Text = "Household has been removed, # of households = " + (bs.Count - 1);
            panel1.Visible = true;
        }

        //Function to modify household Info
        public void ModifyInfoButton(object sender, EventArgs e)
        {
            householdSubOption.Location = new Point(435, 430);
            panel1.Visible = false;
            //Make sure textboxes are empty
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();

            //make text boxes visible for data entry
            nameLabel.Visible = true;
            phoneLabel.Visible = true;
            addressLabel.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

            //Remove old event handling, and add new one
            householdSubOption.Text = "Modify Household";
            householdSubOption.Visible = true;
            householdSubOption.Click -= new EventHandler(AddHousehold);
            householdSubOption.Click -= new EventHandler(DeleteHousehold);
            householdSubOption.Click -= new EventHandler(SuspendHouse);
            householdSubOption.Click -= new EventHandler(ModifyInfo);
            householdSubOption.Click += new EventHandler(ModifyInfo);
        }
        //Sub button to modify info
        public void ModifyInfo(object sender, EventArgs e)
        {
            //Local Variables
            string name, address, phone;
            //Set variables to textbox data
            if (String.IsNullOrEmpty(textBox1.Text) == false)
            {
                name = textBox1.Text;
                households.ElementAt(dataList.SelectedIndex).Name = name;
            }
            if (String.IsNullOrEmpty(textBox2.Text) == false)
            {
                phone = textBox2.Text;
                households.ElementAt(dataList.SelectedIndex).Phone = phone;
            }
            if (String.IsNullOrEmpty(textBox3.Text) == false)
            {
                address = textBox3.Text;
                households.ElementAt(dataList.SelectedIndex).Address = address;
            }




            // Update list of carriers
            bs.ResetBindings(false);

            //Display label
            panel1.Visible = true;
            messageBox.Text = "Household Info Modified";

            //Display new addition
            DisplayallHouseinfo();


            //Make sure textboxes are empty
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
        }

        //Function for suspend household button
        public void SuspendHouseholdButton(object sender, EventArgs e)
        {
            //make messgae not visible
            panel1.Visible = false;
            //change location of button
            householdSubOption.Location = new Point(435, 430);
            
            //make text boxes not visible 
            nameLabel.Visible = false;
            phoneLabel.Visible = false;
            addressLabel.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;



            //Remove old event handling, and add new one
            householdSubOption.Visible = true;

            //get selected index and delete it from list
     
            householdSubOption.Text = "Suspend/Unsuspend House Delivery";
            householdSubOption.Click -= new EventHandler(AddHousehold);
            householdSubOption.Click -= new EventHandler(DeleteHousehold);
            householdSubOption.Click -= new EventHandler(ModifyInfo);
            householdSubOption.Click -= new EventHandler(SuspendHouse);
            householdSubOption.Click += new EventHandler(SuspendHouse);

          
      
        }
        //Sub button to suspend household
        public void SuspendHouse(object sender, EventArgs e)
        {
            //get selected index and delete it from list
            if (households.ElementAt(dataList.SelectedIndex).Suspended == true)
            {
                households.ElementAt(dataList.SelectedIndex).Suspended = false;
                messageBox.Text = "Household Delivery has been unsuspended ";
            }
            else
            {
                households.ElementAt(dataList.SelectedIndex).Suspended = true;
                messageBox.Text = "Household Delivery has been suspended ";
            }
            //reset the carrier list
            bs.ResetBindings(false);
            DisplayallHouseinfo();
            //indicate it has been suspended / unsuspended
            
            panel1.Visible = true;
        }







        //-------------------------------------------------------------End household functions------------------------------------------------------
        //-------------------------------------------------------------Billing section----------------------------------------------------------
        public void viewBill(object sender, EventArgs e)
        {
            messageBox.Text = "Number of Subscirptions: " + households.ElementAt(dataList.SelectedIndex).NumSubs.ToString() + " ---- Total Owed: " + households.ElementAt(dataList.SelectedIndex).TotalOwed;
            panel1.Visible = true;
        }



        //---------------------------------------------------------------------------------------------------------------------------------------
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

            //Display all households BUTTON
        public void DisplayallHouseinfo(object sender, EventArgs e)
        {

            bs.DataSource = households;
            dataList.DataSource = bs;
            dataList.Visible = true;

        }
        //Display all households
        public void DisplayallHouseinfo()
        {

            bs.DataSource = households;
            dataList.DataSource = bs;
            dataList.Visible = true;

        }
        //Display all carriers button
        public void DisplayallCarrierinfo(object sender, EventArgs e)
        {
            carrierlist.DataSource = carriers;
            dataList.DataSource = carrierlist;
            dataList.Visible = true;
        }
        //Display all carriers just function
        public void DisplayallCarrierinfo()
        {
            carrierlist.DataSource = carriers;
            dataList.DataSource = carrierlist;
            dataList.Visible = true;
        }

        //Display all publications
        public void DisplayallPublicationinfo(object sender, EventArgs e)
        {

            dataList.DataSource = publications;
            dataList.Visible = true;
        }
        //------------------------------------------------------------------------------------------------

        //Functions to make each Sections buttons visible
        //Publications buttons
        public void PublicationsButtonsVisible()
        {
            //Make the buttons visible
            option1.Visible = true;
            option3.Visible = true;
            option4.Visible = true;
        }
        //Carrier buttons
        public void CarrierButtonsVisible()
        {
            //Make the buttons visible
            option5.Visible = true;
            option6.Visible = true;
            option7.Visible = true;
            option8.Visible = true;
            //Change location
            option5.Location = new Point(1040, 210);
            option6.Location = new Point(1040, 355);
            option7.Location = new Point(1040, 500);
            option8.Location = new Point(1040, 645);
        }
        //Household buttons
        public void HouseholdButtonsVisible()
        {
            //Make the buttons visible
            option9.Visible = true;
            option10.Visible = true;
            option11.Visible = true;
            option12.Visible = true;
            //Change location
            option9.Location = new Point(1040, 210);
            option10.Location = new Point(1040, 355);
            option11.Location = new Point(1040, 500);
            option12.Location = new Point(1040, 645);
        }
        
        


        //Functions to make each Sections buttons not visible
        //Publications buttons
        public void PublicationsButtonsNotVisible()
        {
            //Make the buttons not visible
            option1.Visible = false;
            option2.Visible = false;
            option3.Visible = false;
            option4.Visible = false;
            subOption.Visible = false;
            //Make sure data lists also arent visible
            dataList.Visible = false;
            datalist2.Visible = false;
        }

        //Carriers buttons
        public void CarrierButtonsNotVisible()
        {
            option5.Visible = false;
            option6.Visible = false;
            option7.Visible = false;
            option8.Visible = false;
            carrierSubOption.Visible = false;
            //make text boxes not visible 
            nameLabel.Visible = false;
            phoneLabel.Visible = false;
            addressLabel.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            panel1.Visible = false;
        }
        //Household buttons
        public void HouseholdButtonsNotVisible()
        {
            //Make the buttons not visible
            option9.Visible = false;
            option10.Visible = false;
            option11.Visible = false;
            option12.Visible = false;
            subOption.Visible = false;
            householdSubOption.Visible = false;
            //Make sure data lists also arent visible
            dataList.Visible = false;
            datalist2.Visible = false;
        }
        //Billing buttons
        public void BillingButtonsNotVisible()
        {
            billingButton.Visible = false;
            option2.Visible = false;
        }

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


        private void addSub_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Publication tab buttons --------------------------------------------------------------------------
        private void option1_Click(object sender, EventArgs e)
        {

        }

        private void option2_Click(object sender, EventArgs e)
        {

        }

        private void option3_Click(object sender, EventArgs e)
        {

        }

        private void option4_Click(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------------------------

        //Carrier tab buttons---------------------------------------------------------
        private void option8_Click(object sender, EventArgs e)
        {

        }

        private void option6_Click(object sender, EventArgs e)
        {

        }

        private void option5_Click(object sender, EventArgs e)
        {

        }

        private void option7_Click(object sender, EventArgs e)
        {

        }

        private void carrierSubOption_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------
    }
}
