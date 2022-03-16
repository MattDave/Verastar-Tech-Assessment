using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Object_Library.Data_Objects
{
    internal class OrderItem
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public decimal ListPrice { get; set; }

        public decimal Discount { get; set; }

        public OrderItem(int orderId, int itemId, decimal listPrice, decimal discount)
        {
            OrderId = orderId;
            ItemId = itemId;
            ListPrice = listPrice;
            Discount = discount;
        }
    }
}
