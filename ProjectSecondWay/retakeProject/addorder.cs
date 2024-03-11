using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retakeProject
{
    public partial class addorder : Form
    {
        public addorder()
        {
            InitializeComponent();
            showTheMenu();
        }
        // here we make a method to refrech the combobox and show the products that we have in the txt file
        private void showTheMenu() 
        {
            comboBoxMenu.Items.Clear();
            // Read products from the file and populate AllProducts in the database class
            database.ReadProducts();
            // Assuming AllProducts is a List<Product> in the database class
            comboBoxMenu.Items.AddRange(database.AllProducts.ToArray());
            
            Refresh();
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            // here we make the code to Check if an item is selected in the ComboBox
            if (comboBoxMenu.SelectedItem != null)
            {
                // Assume that the ComboBox is bound to a list of Product objects
                Product selectedProduct = (Product)comboBoxMenu.SelectedItem;

                // here we give an order to Get the selected size ItemSize method
                string productSize = ItemSize();

                // here we make the app to determine the price based on the selected size from the option of radiobuttons 
                int itemPrice = 0;
                switch (productSize)
                {
                    case "Small":
                        itemPrice = selectedProduct.SmallPrice;
                        break;
                    case "Medium":
                        itemPrice = selectedProduct.MediumPrice;
                        break;
                    case "Large":
                        itemPrice = selectedProduct.LargePrice;
                        break;
                }

                //  here we tell the how to build the item description in listboxItems
                string itemCart = $"{selectedProduct.Name} = {productSize} = {itemPrice}";

                // then add the item description to the ListBox
                listBoxItems.Items.Add(itemCart);
                totalPriceCert();
            }
            Refresh();
        }
        // here we make the method to check the size from radio button 
        private string ItemSize() 
        {
            if (radiobtnSmall.Checked)
                return "Small";
            else if (radiobtnMedium.Checked)
                return "Medium";
            else if (radiobtnLarge.Checked)
                return "Large";


            return string.Empty;
        }
        // we make method for calculating the prices of items 
        private  int totalPriceCert() 
        {
            int totalprice = 0;
            // here we make a foreach loop to look for items in listbox
            foreach (string item in listBoxItems.Items) 
            {
               
                string[] parts = item.Split('=');
                if (parts.Length >= 3) 
                {
                    int itemPrice;
                    if (int.TryParse(parts[2], out itemPrice)) 
                    {
                        totalprice += itemPrice;
                    }
                }
            }
            sumlabel.Text = totalprice.ToString();
            return totalprice;
            
        }
        // here we code  the checkout button  to add the order in orders.text
        private void Finishbtn_Click(object sender, EventArgs e)
        {
            // here we make a condition to check if the textbox of the customer is empty or not
            if (string.IsNullOrEmpty(textBoxname.Text))
            {
                MessageBox.Show("Please, check the name and the order details");
            }
            // here we contiue the the code after checking the condition
            else
            {
                string customername = textBoxname.Text;
                int totalprice = totalPriceCert();
                int randomID = GenerateRandomID();

                // here we code the button to use the method that we create for this action in database.cs
                database.CheckoutOrders(listBoxItems, customername, randomID, totalprice);
                listBoxItems.Items.Clear();

                

                MessageBox.Show("Order is done and recorded in the database");
            }
        }

        // here we code the back button to open the home main form
        private void Backbtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void addorder_Load(object sender, EventArgs e)
        {
            showTheMenu();
        }
        // here we make a method for generated IDs automatically with our condition that IDs if in range 100 - 1000
        private int GenerateRandomID() 
        {
            Random random = new Random();   
            return random.Next(100, 1000);
        }

        
    }
}
