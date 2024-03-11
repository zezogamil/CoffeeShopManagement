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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //here we code the app to take us to add order form
        private void btnaddoeder_Click(object sender, EventArgs e)
        {
            addorder f1 = new addorder();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
        // here we code the to see form
        private void btnsee_Click(object sender, EventArgs e)
        {
            seeorders f2 = new seeorders(); 
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
        // here we code button add product to take us to add product form
        private void btnaddpro_Click(object sender, EventArgs e)
        {
            addproduct f3 = new addproduct();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }
        // and exit button to close the app
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
