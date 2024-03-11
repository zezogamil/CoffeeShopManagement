using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noku
{
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
            PopulateComboBox();
            
        }

        private void Ordergroupbox_Enter(object sender, EventArgs e)
        {

        }
        private void PopulateComboBox() 
        {
            comboBox1.Items.Clear();
            DataBase.ReadTheMenu();

            foreach (var product in DataBase.Allproduct)
            {
                comboBox1.Items.Add(product);
            }
            Refresh();
        }

        private int TotalOrderSUM = 0;
        private void Addproductbtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string size = SmallRB.Checked ? "Small" : MediumRB.Checked ? "Medium" : LargeRB.Checked ? "Large" : string.Empty;
               

                    productslist selectedProduct = (productslist)comboBox1.SelectedItem;

                
                int itemPrice = 0;
                switch (size)
                {
                    case "Small":
                        itemPrice = selectedProduct.Smallprice;
                        break;
                    case "Medium":
                        itemPrice = selectedProduct.Mediumprice;
                        break;
                    case "Large":
                        itemPrice = selectedProduct.Largeprice;
                        break;
                    default:
                        break;
                }

                
                string itemInfo = $"{selectedProduct.Productname} # {size} # {itemPrice}";

                TotalOrderSUM += itemPrice;
                BusketOForders.Items.Add(itemInfo);
                Sumlbl.Text = $"{TotalOrderSUM}";
            }

        }

        private void Checkoutbtn_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please, write the customer name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string customername = textBox1.Text;
                int totalSUM = TotalOrderSUM;
                int randomID = GenerateRandomID();

                DataBase.WriteTheOrderInRecord(BusketOForders, customername, randomID, totalSUM);
                BusketOForders.Items.Clear();

                MessageBox.Show("The order is preparing and have been recorded in orders record");
            }
            
        } 
        private int GenerateRandomID() 
        {
            Random random = new Random();
            return random.Next(0, 999);
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            homeForm home = new homeForm();
            this.Hide();
            home.ShowDialog();  
            this.Close();
        }
    }

}
