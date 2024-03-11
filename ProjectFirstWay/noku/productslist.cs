using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noku
{
    class productslist
    {
        public string Productname;
        public int Smallprice;
        public int Mediumprice;
        public int Largeprice;

        
        

        
        public productslist(string productname, int smallprice, int mediumprice, int largeprice)
        {
            Productname = productname;
            Smallprice = smallprice;
            Mediumprice = mediumprice;
            Largeprice = largeprice;
        }
        public override string ToString()
        {
            return $"{Productname} - {Smallprice} - {Mediumprice} - {Largeprice}";
        }

        public string getdata() 
        {
            return $"{Productname};{Smallprice};{Mediumprice};{Largeprice}";
        }
        
    }

    class Customers 
    {
        public string Customername;
        public int OrderID;

        public Customers(string customername, int orderid) 
        {
            Customername = customername;
            OrderID = orderid;
        }
        public string orderdata()
        {
            return $"{Customername};{OrderID}";
        }

    }
}
