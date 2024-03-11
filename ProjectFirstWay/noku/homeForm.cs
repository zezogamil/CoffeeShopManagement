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
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void addorderbtn_Click(object sender, EventArgs e)
        {
            orders order = new orders();
            this.Hide();
            order.ShowDialog();
            this.Close();
        }

        private void seeorderbtn_Click(object sender, EventArgs e)
        {
            seeorders see = new seeorders();    
            this.Hide();
            see.ShowDialog();
            this.Close();
        }

        private void addproductbtn_Click(object sender, EventArgs e)
        {
            addproducts add = new addproducts();
            this.Hide();
            add.ShowDialog();
            this.Close();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
