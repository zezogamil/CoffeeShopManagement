using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retakeProject
{
    //here we give the variable of products that we made a value 
    public class Product
    {
        private string productName;
        private int smallPrice;
        private int mediumPrice;
        private int largePrice;

        public Product(string[] data)
        {
            productName = data[0];
            smallPrice = Convert.ToInt32(data[1]);
            mediumPrice = Convert.ToInt32(data[2]);
            largePrice = Convert.ToInt32(data[3]);
        }

        public Product(string Name, int SmallPrice, int MediumPrice, int LargePrice)
        {
            productName = Name;
            smallPrice = SmallPrice;
            mediumPrice = MediumPrice;
            largePrice = LargePrice;
        }

        public string Name
        {
            get { return productName; }
            set { productName = value; }
        }

        public int SmallPrice
        {
            get { return smallPrice; }
            set { smallPrice = value; }
        }

        public int MediumPrice
        {
            get { return mediumPrice; }
            set { mediumPrice = value; }
        }

        public int LargePrice
        {
            get { return largePrice; }
            set { largePrice = value; }
        }
        public override string ToString()
        {
            return $"{productName} - Small: {smallPrice}, Medium: {mediumPrice}, Large: {largePrice}";
        }
    }

}
