using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Object_Library.Data_Objects
{
    internal class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }

        public Order(int orderId, int customerId, int orderStatus, DateTime orderDate, DateTime requiredDate, DateTime shippedDate)
        {
            OrderID = orderId;
            CustomerID = customerId;
            OrderStatus = orderStatus;
            OrderDate = orderDate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
        }
    }
}
