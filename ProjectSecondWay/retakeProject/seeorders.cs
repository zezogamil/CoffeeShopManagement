using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace retakeProject
{
    public partial class seeorders : Form
    {
        public seeorders()
        {
            InitializeComponent();
            ShowOrderIDs();
            UpdateStoreSummary(totallabel, sumOfAlllabel);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // here we code the back button to open the main form
        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
        // here we code the listbox of IDs 
        private void listboxIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxIDs.SelectedItem != null)
            {
                int selectedOrderID = int.Parse(listboxIDs.SelectedItem.ToString());

                // Call the method to load order details based on the selected ID
                database.LoadOrderDetails(selectedOrderID, namelabel, orderIDlabel, ordertotallabel, listboxItems);
            }
        }
        // here method for show the IDs
        private void ShowOrderIDs()
        {
            List<int> orderIDs = database.ReadOrderIDs();

            // Assuming listboxIDs is the name of your ListBox
            listboxIDs.Items.Clear();
            listboxIDs.Items.AddRange(orderIDs.Select(id => id.ToString()).ToArray());
        }
        // here we code a method to show the total os all sells and total of orders 
        public static (int orderCount, int totalprices) UpdateStoreSummary(Label sumOfAlllabel, Label totallabel)
        {
            int orderCount = 0;
            int totalprices = 0;

            FileStream fs = new FileStream("Orders.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                // here we tell the app to simply count the lines of the txt file 
                string line = sr.ReadLine();
                orderCount++;
                // here we tell him how the file is splitted by semicolons
                string[] splittedLine = line.Split(';');
                // here we tell the app that we look for splittedline number two in the txtfile .because the totalprice write  in second ;
                if (splittedLine.Length >= 2)
                {
                    string lastsplittedline = splittedLine[splittedLine.Length - 1];

                    if (int.TryParse(lastsplittedline, out int totalpric))
                    {
                        totalprices += totalpric;
                    }
                }


            }


            sr.Close();
            fs.Close();
            // here we code the app to print the order count in totallabel which it related with and same for  total prices 
            totallabel.Text = $"{orderCount}";
            sumOfAlllabel.Text = $"{totalprices}";

            return (orderCount, totalprices);

        }
    }




}

