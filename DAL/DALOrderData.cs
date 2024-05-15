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

        public void updateOrderCustomer(string orderID, int customerID)
        {
            string sql = "update Orders set customerID = '" + customerID + "' where orderID = '" + orderID + "'";
            Connection.actionQuery(sql);
        }





    }
}
