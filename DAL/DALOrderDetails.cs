using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALOrderDetails
    {
        OrderDetail od;


        public DALOrderDetails(int orderDetailID, string orderID, string productID, string productName, int quantity, decimal price)
        {
            od = new OrderDetail(orderDetailID, orderID, productID, productName, quantity, price);
        }

        public int getOrderDetailID()
        {
            return od.getOrderDetailID();
        }

        public string getOrderID()
        {
            return od.getOrderID();
        }

        public string getProductID()
        {
            return od.getProductID();
        }

        public int getQuantity()
        {
            return od.getQuantity();
        }

        public decimal getPrice()
        {
            return od.getPrice();
        }

        public void AddOrderDetail(string orderID, string productID, string productName, int quantity, decimal price)
        {
            // Add order detail to database
            string sql = "INSERT INTO OrderDetails (orderID, productID, productName, quantity, price) VALUES ('" + orderID + "', '" + productID + "', '" + productName + "', '" + quantity + "', '" + price + "')";
            Connection.actionQuery(sql);

        }

        public void UpdateOrderDetail(int orderDetailID, string orderID, string productID, int quantity, decimal price)
        {
            // Update order detail in database
            string sql = "UPDATE OrderDetails SET orderID = '" + orderID + "', productID = '" + productID + "', quantity = '" + quantity + "', price = '" + price + "' WHERE orderDetailID = '" + orderDetailID + "'";
            Connection.actionQuery(sql);
        }

        public List<OrderDetail> GetOrderDetails(string orderID)
        {
            // Get order details from database
            string sql = "SELECT * FROM OrderDetails WHERE orderID = '" + orderID + "'";
            List<OrderDetail> list = new List<OrderDetail>();
            // Add order details to list
            return list;
        }

        public DataTable GetData(String orderID)
        {
            // Get order details from database
            string sql = "SELECT * FROM OrderDetails WHERE orderID = '" + orderID + "'";
            return Connection.selectQuery(sql);
        }

        public void updateQuantity(int orderDetailID, int quantity)
        {
            // Update quantity of order detail in database
            string sql = "UPDATE OrderDetails SET quantity = '" + quantity + "' WHERE orderDetailID = '" + orderDetailID + "'";
            Connection.actionQuery(sql);
        }

        public void deleteOrderDetail(int orderDetailID)
        {
            // Delete order detail from database
            string sql = "DELETE FROM OrderDetails WHERE orderDetailID = '" + orderDetailID + "'";
            Connection.actionQuery(sql);
        }


    }
}
