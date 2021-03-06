using Data_Object_Library.Data_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Object_Library
{
    public class DBSet
    {
        List<Order> Orders { get; set; }
        List<OrderItem> OrderItems { get; set; }
        List<Customer> Customers { get; set; }

        public DBSet()
        {
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            Orders = new List<Order>();
            OrderItems = new List<OrderItem>();
            Customers = new List<Customer>();

            using (var reader = new StreamReader(dir + @"\Data CSVs\Orders.csv"))
            {

                int lineCount = 0;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Order newOrder;

                    if (lineCount > 0)
                    {
                        newOrder = new Order(Convert.ToInt32(values[0]), Convert.ToInt32(values[1]), Convert.ToInt32(values[2]),
                            Convert.ToDateTime(values[3]), Convert.ToDateTime(values[4]), Convert.ToDateTime(values[5]));

                        Orders.Add(newOrder);
                    }

                    lineCount++;
                }
            }

            using (var reader = new StreamReader(dir + @"\Data CSVs\Customers.csv"))
            {

                int lineCount = 0;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Customer newCustomer;

                    if (lineCount > 0)
                    {
                        newCustomer = new Customer(Convert.ToInt32(values[0]), values[1], values[2], values[3], values[4],
                            values[5], values[6], values[7], values[8]);

                        Customers.Add(newCustomer);
                    }

                    lineCount++;
                }
            }

            using (var reader = new StreamReader(dir + @"\Data CSVs\OrderItems.csv"))
            {

                int lineCount = 0;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    OrderItem newOrderItem;

                    if (lineCount > 0)
                    {
                        newOrderItem = new OrderItem(Convert.ToInt32(values[0]), Convert.ToInt32(values[1]),
                            Convert.ToDecimal(values[2]), Convert.ToDecimal(values[3]));

                        OrderItems.Add(newOrderItem);
                    }

                    lineCount++;
                }
            }
        }
    }
}
