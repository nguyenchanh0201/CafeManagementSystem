using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderData
    {

        private string orderID;
        private DateTime orderDate;
        private decimal total;
        private string username;
        private string tableID;
        private string orderType;
        private string customerID;
        private string shiftID;
        private string paymentMethod;
        public OrderData(string orderID, DateTime orderDate, decimal total, string username, string tableID, string orderType, string customerID, string shiftID, string paymentMethod)
        {
            this.orderID = orderID;
            this.orderDate = orderDate;
            this.total = total;
            this.username = username;
            this.tableID = tableID;
            this.orderType = orderType;
            this.customerID = customerID;
            this.shiftID = shiftID;
            this.paymentMethod = paymentMethod;
        }

        public string getOrderID()
        {
            return orderID;
        }

        public DateTime getOrderDate()
        {
            return orderDate;
        }

        public decimal getTotal()
        {
            return total;
        }

        public string getUsername()
        {
            return username;
        }

        public string getTableID()
        {
            return tableID;
        }

        public string getOrderType()
        {
            return orderType;
        }

        public string getCustomerID()
        {
            return customerID;
        }

        public string getShiftID()
        {
            return shiftID;
        }

        public string getPaymentMethod()
        {
            return paymentMethod; 
        }
        public OrderData(DataRow dr)
        {
            this.shiftID = dr["shiftID"].ToString();
            this.orderID = dr["orderID"].ToString();
            this.orderDate = Convert.ToDateTime(dr["orderDate"]);
            this.total = Convert.ToDecimal(dr["total"]);
            this.username = dr["username"].ToString();
            this.tableID = dr["tableID"].ToString();
            this.orderType = dr["orderType"].ToString();
            this.customerID = dr["customerID"].ToString();
            this.paymentMethod = dr["paymentMethod"].ToString();
        }
    }
}
