using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noku
{
    public partial class addproducts : Form
    {
        public addproducts()
        {
            InitializeComponent();

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0 || textBoxSmallP.Text.Length == 0 || textBoxMediumP.Text.Length == 0 || textBoxLp.Text.Length == 0)
            {
                MessageBox.Show("Please, there is a blank empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                productslist product = new productslist(textBoxName.Text, Convert.ToInt32(textBoxSmallP.Text), Convert.ToInt32(textBoxMediumP.Text), Convert.ToInt32(textBoxLp.Text));
                DataBase.WriteMenuProduct(product);
                MessageBox.Show("The new prodcut have been add to the shop menu");

                textBoxName.Clear();
                textBoxSmallP.Clear();
                textBoxMediumP.Clear();
                textBoxLp.Clear();

            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            homeForm home = new homeForm();
            this.Hide();
            home.ShowDialog();
            this.Close();

        }
    }
}
