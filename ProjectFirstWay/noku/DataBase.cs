using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noku
{
    static class DataBase
    {
        public static List<productslist> Allproduct = new List<productslist>();

        public static void WriteMenuProduct(productslist product) 
        {
            Allproduct.Clear();
            FileStream fs = new FileStream("MENU.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine($"{product.getdata()}");
            Allproduct.Add(product);
            sw.Close();
            fs.Close();
        }
        public static void ReadTheMenu() 
        {
            Allproduct.Clear();

            FileStream fs = new FileStream("MENU.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream) 
            {
                string line = sr.ReadLine();
                string[] splittedline = line.Split(';');
                productslist product = new productslist(splittedline[0], Convert.ToInt32(splittedline[1]), Convert.ToInt32(splittedline[2]), Convert.ToInt32(splittedline[3]));
                Allproduct.Add(product);
            }
            sr.Close();
            fs.Close();
        }
        public static void WriteTheOrderInRecord(ListBox BusketOForders, string customername, int randomID, int totalSUM)  
        {
            FileStream fs = new FileStream("OrderHistory.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            List<string> ordersItems = new List<string>();
            foreach (var item in BusketOForders.Items)
            {
                ordersItems.Add(item.ToString());
            }
            string Items = string.Join(" + ", ordersItems);


            sw.WriteLine($"{randomID};{customername};{Items};{totalSUM}");

            sw.Close();
            fs.Close(); 
        }
        public static List<int> OrdersIDs() 
        {
            List<int> orderIDs = new List<int>();
            FileStream fs = new FileStream("OrderHistory.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] splittedline = line.Split(';');

                if (splittedline.Length >= 4 && int.TryParse(splittedline[0], out int randomID)) 
                {
                    orderIDs.Add(randomID);    
                }

            }
            return orderIDs;
        }
        
    }
    
}
