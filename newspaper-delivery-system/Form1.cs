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

        //Display all households
        public void DisplayallHouseinfo(object sender, EventArgs e)
        {

            string path = @"..\..\..\";
            List<Household> households = DataHandler.getHouseholdData(path + "households.csv");
            dataList.DataSource = households;
            dataList.Visible = true;

        }
        //Display all carriers
        public void DisplayallCarrierinfo(object sender, EventArgs e)
        {
            string path = @"..\..\..\";
            List<Carrier> carriers = DataHandler.getCarrierData(path + "carriers.csv");
            dataList.DataSource = carriers;
            dataList.Visible = true;

        }

        //Display all publications
        public void DisplayallPublicationinfo(object sender, EventArgs e)
        {
            string path = @"..\..\..\";
            List<Publication> publications = DataHandler.getPublicationData(path + "publications.csv");
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
    }
}
