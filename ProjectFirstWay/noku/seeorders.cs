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

namespace noku
{
    public partial class seeorders : Form
    {
        public seeorders()
        {
            InitializeComponent();
            LoadOrderIDs();
            TheShopOrdersCount(labeltotalorders);
            TotalIncome(labelSumoforders);

        }
        private void LoadOrderIDs()
        {
            List<int> orderIDs = DataBase.OrdersIDs();
            lbShowID.Items.AddRange(orderIDs.Select(id => id.ToString()).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homeForm home = new homeForm(); 
            this.Hide();
            home.ShowDialog();  
            this.Close();

        }
        private void lbShowID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear existing data
            ClearOrderDetails();

            // Get the selected order ID from the ListBox
            if (lbShowID.SelectedItem != null && int.TryParse(lbShowID.SelectedItem.ToString(), out int selectedOrderID))
            {
                // Load order details based on the selected ID
                LoadOrderInvoice(selectedOrderID, labelId, labelName, labelTotal, listBoxitems);
            }
        }
        private void ClearOrderDetails()
        {
            // Clear labels and ListBox
            labelId.Text = "";
            labelName.Text = "";
            labelTotal.Text = "";
            listBoxitems.Items.Clear();
            Refresh();
        }
        public static void LoadOrderInvoice(int orderID, Label labelId, Label labelName, Label labelTotal, ListBox listBoxitems)
        {
            FileStream fs = new FileStream("OrderHistory.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] splittedline = line.Split(';');

                if (splittedline.Length >= 4 && int.TryParse(splittedline[0], out int currentOrderID) && currentOrderID == orderID)
                {
                    labelId.Text = splittedline[0];
                    labelName.Text = splittedline[1];
                    listBoxitems.Items.Clear();

                    
                    string[] items = splittedline[2].Split('+'); 
                    foreach (string item in items)
                    {
                        listBoxitems.Items.Add(item.Trim()); 
                    }

                    labelTotal.Text = splittedline[3] + " PLN";
                    break;
                }

               
            }
            
            sr.Close();
            fs.Close();
            return;
            
        }
        public static int TheShopOrdersCount( Label labeltotalorders)
        {
            int orders = 0;

            FileStream fs = new FileStream("OrderHistory.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream) 
            {
                string line = sr.ReadLine();    
                orders++;   
            }
            sr.Close();
            fs.Close();
            labeltotalorders.Text = $"{orders} Order";
            return orders;
        }
        public static int TotalIncome(Label labelSumoforders) 
        {
            int income = 0;

            FileStream fs = new FileStream("OrderHistory.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream) 
            {
                string line = sr.ReadLine();
                string[] splittedline = line.Split(';');
                if (splittedline.Length >= 4 && int.TryParse(splittedline[3], out int totalsum)) 
                {
                    income += totalsum;
                }
            }

            sr.Close();
            fs.Close();

            labelSumoforders.Text = $"{income} PLN";
            return income;
        }

        
    }
}
