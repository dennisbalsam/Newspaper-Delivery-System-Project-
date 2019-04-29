using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newspaper_delivery_system
{
    public partial class Form1 : Form
    {
        static string path = @"..\..\..\";

        List<Household> households = DataHandler.getHouseholdData(path + "households.csv");
        List<Carrier> carriers = DataHandler.getCarrierData(path + "carriers.csv");
        List<Publication> publications = DataHandler.getPublicationData(path + "publications.csv");

        BindingSource bs = new BindingSource();
    
        public Form1()
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
            option1.Click += new EventHandler(AddNewSubscription);
            addSub.Click += new EventHandler(addSubscription);
            option2.Click += new EventHandler(DisplaySubs);

            
            

        }
        //Carrier Info Function
        public void CarrierInfo()
        {
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
            dataList.Visible = false;
            welcomelabel2.Visible = false;
            Welcomelabel.Visible = false;
            button1.Visible = true;
            button1.Text = "Display all Publications";
            button1.Click += new EventHandler(DisplayallPublicationinfo);
        }
        //Button to add the subscirption to a house hold
        public void addSubscription(object sender, EventArgs e)
        {

            //Add the selected publication to the house
            households.ElementAt(dataList.SelectedIndex).addSubscription(publications.ElementAt(datalist2.SelectedIndex));
            bs.ResetBindings(false);
            addSub.Click += new EventHandler(DisplayallHouseinfo);
        }

        //Display current houses subscriptions
        public void DisplaySubs(object sender, EventArgs e)
        {
            datalist2.DataSource = households.ElementAt(dataList.SelectedIndex).getAllSubscriptions();

        }
        //show list of publications to Add a Subscription GUI Function
        public void AddNewSubscription(object sender, EventArgs e)
        {
            addSub.Visible = true;
            datalist2.DataSource = publications;
            datalist2.Visible = true;

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
    }
}
