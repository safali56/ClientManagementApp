using Lab2B;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B
{
    public partial class Form1 : Form
    {
        private bool isAdded = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] hairDressers = { "Jane Samley", "Pat Johnson", "Ron Chambers", "Sue Pallon", "Laurie Renkins" };
            string[] services = { "Cut", "Wash, blow - dry, and style", "Colour", "Highlights", "Extension", "Up -do" };

            foreach (string hairDresser in hairDressers)
                hairDressersList.Items.Add(hairDresser);

            foreach (string service in services)
                servicesList.Items.Add(service);

            hairDressersList.SelectedIndex = 0;



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviceBtn.Enabled = true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            if (isAdded)
            {
                chargedList.Items.Add(hairDressersList.SelectedItem.ToString());
                totalPriceList.Items.Add($"{HairSalonModel.GetHairDresserFee(hairDressersList.SelectedItem.ToString())}");
                isAdded = false;
                calculateBtn.Enabled = true;
                hairDressersList.Enabled = false;
            }
            chargedList.Items.Add(servicesList.SelectedItem.ToString());
            totalPriceList.Items.Add($"{HairSalonModel.GetServiceFee(servicesList.SelectedItem.ToString())}");
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0M;
            foreach (var item in totalPriceList.Items)
            {
                totalPrice += Convert.ToDecimal(item.ToString());
            }
           totalPriceLabel.Text  = $"Total Price: {totalPrice:C}";
           
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            chargedList.Items.Clear();
            totalPriceList.Items.Clear();
            totalPriceLabel.Text = "Total Price:";
            serviceBtn.Enabled = false;
            calculateBtn.Enabled=false;
            hairDressersList.Enabled = true;
            hairDressersList.SelectedIndex = 0;
            hairDressersList.Focus ();
        }
    }
}

