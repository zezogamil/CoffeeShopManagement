using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retakeProject
{
    // here we give the variables that we made a value
    public class Customers
    {
        private string customerName;
        private int idOrder;

        public Customers(string[] data)
        {
            customerName = data[0];
            IDorder = Convert.ToInt32(data[1]);
        }

        public Customers(string customername, int IDorder)
        {
           customerName = customername;
           idOrder = IDorder;
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public int IDorder
        {
            get { return idOrder; }
            set { idOrder = value; }
        }
    }

}
