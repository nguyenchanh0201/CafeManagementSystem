using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;


namespace BLL
{
    public class BLLOrderData
    {
        static DALOrderData dalOrderData;

        public BLLOrderData(string orderID, DateTime orderDate, decimal total, string username, string tableID, string orderType, string customerID, string shiftID, string paymentMethod)
        {
            dalOrderData = new DALOrderData(orderID, orderDate, total, username, tableID, orderType, customerID, shiftID, paymentMethod);
        }

        public string getOrderID()
        {
            return dalOrderData.getOrderID();
        }

        public DateTime getOrderDate()
        {
            return dalOrderData.getOrderDate();

        }

        public decimal getTotal()
        {
            return dalOrderData.getTotal();
        }

        public string getUsername()
        {
            return dalOrderData.getUsername();
        }

        public string getTableID()
        {
            return dalOrderData.getTableID();
        }

        public string getOrderType()
        {
            return dalOrderData.getOrderType();
        }

        public string getCustomerID()
        {
            return dalOrderData.getCustomerID();
        }

        public void AddOrderData(DateTime orderDate, decimal total, String username, String tableID, String orderType, String CustomerID, String shiftID, string paymentMethod)
        {
            dalOrderData.AddOrderData(orderDate, total, username, tableID, orderType, CustomerID, shiftID, paymentMethod);
        }

        public String createOrderID()
        {
            return dalOrderData.createOrderID();
        }

        public static void updatePaymentMethodAndTotal(string orderID, string paymentMethod, decimal total)
        {
            if (dalOrderData == null)
            {
                dalOrderData = new DALOrderData("", DateTime.Now, 0, "", "", "", "", "", "");
            }
            dalOrderData.updatePaymentMethodAndTotal(orderID, paymentMethod, total);
        }
        public static DataTable select()
        {
            if (dalOrderData == null)
            {
                dalOrderData = new DALOrderData("", DateTime.Now, 0, "", "", "", "", "", "");
            }
            return dalOrderData.select();
        }
        public static List<OrderData> getOrderData()
        {
            if (dalOrderData == null)
            {
                dalOrderData = new DALOrderData("", DateTime.Now, 0, "", "", "", "", "", "");
            }
            return dalOrderData.getOrderData();
        }
        public static void update(string orderID, DateTime orderDate, decimal total, string username, string tableID, string orderType, string CustomerID, string shiftID, string paymentMethod)
        {
            if (dalOrderData == null)
            {
                dalOrderData = new DALOrderData("", DateTime.Now, 0, "", "", "", "", "", "");
            }
            dalOrderData.update(orderID, orderDate, total, username, tableID, orderType, CustomerID, shiftID, paymentMethod);
        }
        public static void delete(string orderID)
        {
            if (dalOrderData == null)
            {
                dalOrderData = new DALOrderData("", DateTime.Now, 0, "", "", "", "", "", "");
            }
            dalOrderData.delete(orderID);
        }

        public static void updateOrderCustomer(string orderID, int customerID)
        {
            if (dalOrderData == null)
            {
                dalOrderData = new DALOrderData("", DateTime.Now, 0, "", "", "", "", "", "");
            }
            dalOrderData.updateOrderCustomer(orderID, customerID);
        }
    }
}
