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
        public void HouseholdInfo()
        {
            dataList.Visible = false;
            welcomelabel2.Visible = false;
            Welcomelabel.Visible = false;
            button1.Visible = true;
            button1.Text = "Display all Households";
            button1.Click += new EventHandler(DisplayallHouseinfo);
            option1.Visible = true;
            option1.Click += new EventHandler(AddSubscription);

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
        public void PublicationInfo()
        {
            dataList.Visible = false;
            welcomelabel2.Visible = false;
            Welcomelabel.Visible = false;
            button1.Visible = true;
            button1.Text = "Display all Publications";
            button1.Click += new EventHandler(DisplayallPublicationinfo);
        }
        //Add Subscription GUI Function
        public void AddSubscription(object sender, EventArgs e)
        {
            datalist2.DataSource = publications;
            datalist2.Visible = true;

        }


        //Display all households
        public void DisplayallHouseinfo(object sender, EventArgs e)
        {
            dataList.DataSource = households;
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
    }
}
