using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retakeProject
{
    // here we create the database class to handle almost all process of the app
    static class database
    {
        public static List<Product> AllProducts = new List<Product>();

        // here wa coded a method to write the new products in text file of products 
        public static void WriteProducts(Product product)
        {
            // here we use the filestream to write in text file as database
            FileStream fs = new FileStream("ProductsList.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            // here we constructor how it recoded 
            sw.WriteLine($"{product.Name};{product.SmallPrice};{product.MediumPrice};{product.LargePrice}");
            AllProducts.Add(product);
            sw.Close();
            fs.Close();

        }

        // then we make another method for read 
        public static void ReadProducts()
        {
            AllProducts.Clear();
            FileStream fs = new FileStream("ProductsList.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] splittedLine = line.Split(';');
                Product product = new Product(splittedLine[0], Convert.ToInt32(splittedLine[1]), Convert.ToInt32(splittedLine[2]), Convert.ToInt32(splittedLine[3]));
                AllProducts.Add(product);
            }
            sr.Close();
            fs.Close();
        }
        // here we make another method but this time to recoded the data in database file of orders that have done 
        public static void CheckoutOrders(ListBox listBoxItems, string customername, int randomID, int totalprice)
        {
            FileStream fs = new FileStream("Orders.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine($"{customername};{randomID};{string.Join("=", listBoxItems.Items.Cast<string>())};{totalprice}");


            sw.Close();
            fs.Close();
        }
        // here we make method to read the IDs
        public static List<int> ReadOrderIDs()
        {
            List<int> orderIDs = new List<int>();

            FileStream fs = new FileStream("Orders.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] parts = line.Split(';');

                if (parts.Length >= 3 && int.TryParse(parts[1], out int randomID))
                {
                    orderIDs.Add(randomID);
                }
            }

            return orderIDs;
        }
        // here to load all details of the order
        public static void LoadOrderDetails(int orderID, Label nameLabel, Label orderIDLabel, Label ordertotalLabel, ListBox listBoxItems)
        {
            FileStream fs = new FileStream("Orders.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] parts = line.Split(';');

                if (parts.Length >= 4 && int.TryParse(parts[1], out int parsedOrderID))
                {
                    if (parsedOrderID == orderID)
                    {
                        // Match found, display order details
                        nameLabel.Text = parts[0];  // Assuming the name is the first part
                        orderIDLabel.Text = parts[1];
                        ordertotalLabel.Text = parts[3];

                        string itemsString = parts[2];
                        string[] items = itemsString.Split('=');
                        // Remove the last element which is "Total Price: X"
                        listBoxItems.Items.Clear();
                        listBoxItems.Items.AddRange(items.ToArray());


                        // Close the file stream and return as we found the order details
                        sr.Close();
                        fs.Close();
                        return;
                    }
                }
            }

            // If execution reaches here, no matching order ID was found
            sr.Close();
            fs.Close();
        }

        
    }   
}
