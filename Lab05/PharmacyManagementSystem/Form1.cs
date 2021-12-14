using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Form1 : Form
    {
        List<Medicine> medicines = new List<Medicine>();
        Inventory inventory = new Inventory();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddMedicine_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.ID = MedID.Text;
            medicine.Name = MedName.Text;
            medicine.Stock = Convert.ToInt32(MedQuantity.Text);
            medicine.Price = Convert.ToDouble(MedPrice.Text);
            medicines.Add(medicine);
            comboBox1.Items.Add(medicine.Name);
            MessageBox.Show("New medicine type added.");
            MedID.Text = "";
            MedName.Text = "";
            MedQuantity.Text = "";
            MedPrice.Text = "";
        }

        private void AddMedicine1_Click(object sender, EventArgs e)
        {
            foreach(Medicine medicine in medicines)
            {
                if(medicine.ID == MedID1.Text)
                    medicine.Stock+=Convert.ToInt32(MedQuantity1.Text);
            }
            MedID1.Text = "";
            MedQuantity1.Text = "";
            MessageBox.Show("Stock Updated.");
        }

        private void SellMedicine_Click(object sender, EventArgs e)
        {
            foreach(Medicine medicine in medicines)
            {
                if (medicine.ID == MedID2.Text)
                {
                    inventory.AccountBalance += medicine.Price * Convert.ToInt32(MedQuantity2.Text);
                    medicine.Stock-=Convert.ToInt32(MedQuantity2.Text); 
                }
            }
        }

        private void ViewBalance_Click(object sender, EventArgs e)
        {
            AccountBalance.Text += "BDT" + Convert.ToString(inventory.AccountBalance);
        }

        private void ViewStock_Click(object sender, EventArgs e)
        {
            StockListBox.Items.Clear();
            foreach(Medicine medicine in medicines)
            {
                StockListBox.Items.Add(medicine.GetInfo());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
