using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALOrderData
    {
        OrderData o;

        public DALOrderData(string orderID, DateTime orderDate, decimal total, string username, string tableID, string orderType, string customerID, string shiftID, string paymentMethod)
        {
            o = new OrderData(orderID, orderDate, total, username, tableID, orderType, customerID, shiftID, paymentMethod);
        }

        public string getOrderID()
        {
            return o.getOrderID();
        }

        public DateTime getOrderDate()
        {
            return o.getOrderDate();

        }

        public decimal getTotal()
        {
            return o.getTotal();
        }

        public string getUsername()
        {
            return o.getUsername();
        }

        public string getTableID()
        {
            return o.getTableID();
        }

        public string getOrderType()
        {
            return o.getOrderType();
        }

        public string getCustomerID()
        {
            return o.getCustomerID();
        }

        public void AddOrderData(DateTime orderDate, decimal total, String username, String tableID, String orderType, String CustomerID, String shiftID, String paymentMethod)
        {
            // Add order data to database
            string orderID = createOrderID();
            string sql = "insert into Orders values('" + orderID + "','" + orderDate + "','" + total + "','" + username + "','" + tableID + "','" + orderType + "','" + CustomerID + "','" + shiftID + "','" + paymentMethod + "')";

            Connection.actionQuery(sql);

        }

        public string createOrderID()
        {
            //Call for procedure 
            string sql = "exec generate_orderID";
            string orderID = Connection.selectQuery(sql).Rows[0][0].ToString();

            return orderID;
        }

        public void updatePaymentMethodAndTotal(string orderID, string paymentMethod, decimal total)
        {
            string sql = "update Orders set paymentMethod = '" + paymentMethod + "', total = '" + total + "' where orderID = '" + orderID + "'";
            Connection.actionQuery(sql);
        }
        public DataTable select()
        {
            string sql = "select * from Orders";
            return Connection.selectQuery(sql);
        }
        public List<OrderData> getOrderData()
        {
            List<OrderData> list = new List<OrderData>();
            string sql = "select * from Orders";
            DataTable dt = Connection.selectQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                OrderData o = new OrderData(dr);
                list.Add(o);
            }
            return list;
        }
        public void update(string orderID, DateTime orderDate, decimal total, string username, string tableID, string orderType, string CustomerID, string shiftID, string paymentMethod)
        {
            string sql = "update Orders set orderDate = '" + orderDate + "', total = '" + total + "', username = '" + username + "', tableID = '" + tableID + "', orderType = '" + orderType + "', customerID = '" + CustomerID + "', shiftID = '" + shiftID + "', paymentMethod = '" + paymentMethod + "' where orderID = '" + orderID + "'";
            Connection.actionQuery(sql);
        }
        public void delete(string orderID)
        {
            string sql = "delete from Orders where orderID = '" + orderID + "'";
            Connection.actionQuery(sql);
        }

        public void updateOrderCustomer(string orderID, string customerID)
        {
            string sql = "update Orders set customerID = '" + customerID + "' where orderID = '" + orderID + "'";
            Connection.actionQuery(sql);
        }


        public string getCustomerIDFromOrderID(string orderID)
        {
            string sql = "select customerID from Orders where orderID = '" + orderID + "'";
            return Connection.selectQuery(sql).Rows[0][0].ToString();

        }

        //Track Revenute Data from here

        //get distince year of all orders
        public List<int> getDistinctYear()
        {
            List<int> list = new List<int>();
            string sql = "select distinct year(orderDate) as year from Orders";
            DataTable dt = Connection.selectQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(Convert.ToInt32(dr["year"]));
            }
            return list;

        }

        //get revenue by month
        public DataTable getRevenueByMonth(int year)
        {
            string sql = "select month(orderDate) as month, sum(total) as revenue from Orders where year(orderDate) = " + year + " group by month(orderDate)";
            return Connection.selectQuery(sql);
        }
        //get revenue by day
        public DataTable getRevenueByDay(int year, int month)
        {
            string sql = "select day(orderDate) as day, sum(total) as revenue from Orders where year(orderDate) = " + year + " and month(orderDate) = " + month + " group by day(orderDate)";
            return Connection.selectQuery(sql);
        }

        //get revenue by shift
        public DataTable getRevenueByShift(int year, int month, int day)
        {
            string sql = "select shiftID, sum(total) as revenue from Orders where year(orderDate) = " + year + " and month(orderDate) = " + month + " and day(orderDate) = " + day + " group by shiftID";
            return Connection.selectQuery(sql);
        }

        public DataTable getRevenueByYear()
        {
            string sql = "SELECT DISTINCT(YEAR(orderDate)) AS Years, SUM(total) AS Revenue FROM Orders WHERE YEAR(orderDate) = 2024 GROUP BY YEAR(orderDate);";
            return Connection.selectQuery(sql);
        }


    }
}
