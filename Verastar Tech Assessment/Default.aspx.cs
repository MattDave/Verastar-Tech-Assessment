using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Object_Collection;
using Data_Object_Collection.Data_Objects;

namespace Verastar_Tech_Assessment
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            customerTable.Rows.Clear();

            DBSet dbSet = new DBSet();

            foreach(OrderItem orderItem in dbSet.OrderItems)
            {
                TableRow row = new TableRow();

                Order order = dbSet.Orders.FirstOrDefault(x => x.OrderID == orderItem.OrderId);
                Customer customer = dbSet.Customers.FirstOrDefault(x => x.CustomerId == order.CustomerID);

                TableCell customerNameCell = new TableCell();
                customerNameCell.Text = customer.FirstName + " " + customer.LastName;

                TableCell orderIDCell = new TableCell();
                orderIDCell.Text = order.OrderID.ToString();

                TableCell orderDateCell = new TableCell();
                orderDateCell.Text = order.OrderDate.ToString();

                TableCell orderItemCell = new TableCell();
                orderItemCell.Text = orderItem.ItemId.ToString();

                TableCell orderDiscountCell = new TableCell();
                orderDiscountCell.Text = (orderItem.Discount*100).ToString() + "%";

                row.Cells.Add(customerNameCell);
                row.Cells.Add(orderIDCell);
                row.Cells.Add(orderDateCell);
                row.Cells.Add(orderItemCell);
                row.Cells.Add(orderDiscountCell);

                customerTable.Rows.Add(row);
            }

            customerTable.DataBind();
        }
    }
}