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
    public partial class addproduct : Form
    {
        public addproduct()
        {
            InitializeComponent();
        }
        // here we code the add button to recorded the data in txt.file
        private void addbtn_Click(object sender, EventArgs e)
        {
            // here we set a if statement to make the app check the textbox is filled or no
            if (string.IsNullOrEmpty(textBoxnname.Text) || string.IsNullOrEmpty(textBoxSprice.Text) || string.IsNullOrEmpty(textBoxMprics.Text) || string.IsNullOrEmpty(textBoxLprice.Text))
            {
                //here we set the message if any textbox is empty 
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                // here we make the app add the product with assuming the price is an integer
                Product product = new Product(textBoxnname.Text, Convert.ToInt32(textBoxSprice.Text), Convert.ToInt32(textBoxMprics.Text), Convert.ToInt32(textBoxLprice.Text));

                // here we give an order to write the product in txt file using the method that we create in the class
                database.WriteProducts(product);

                //here we set a message to show after the data have been recorded in the txt.file 
                MessageBox.Show("The product have been add in the menu");

                // here we code this to remove the values after add
                textBoxnname.Text = "";
                textBoxSprice.Text = "";
                textBoxMprics.Text = "";
                textBoxLprice.Text = "";
            }

        }
        //here we code the back button to show the home main form
        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();

        }
    }
}
