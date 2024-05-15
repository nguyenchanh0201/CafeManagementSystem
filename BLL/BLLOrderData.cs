using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Net;


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

        public static void updateOrderCustomer(string orderID, string customerID)
        {
            if (dalOrderData == null)
            {
                dalOrderData = new DALOrderData("", DateTime.Now, 0, "", "", "", "", "", "");
            }
            dalOrderData.updateOrderCustomer(orderID, customerID);
        }

        
        public static string getCustomerIDFromOrderID(string orderID)
        {
            if (dalOrderData == null)
            {
                dalOrderData = new DALOrderData("", DateTime.Now, 0, "", "", "", "", "", "");
            }
            return dalOrderData.getCustomerIDFromOrderID(orderID);
        }



        //TRack Revenue 


        public static List<int> getDistinctYear()
        {
            if (dalOrderData == null)
            {
                dalOrderData = new DALOrderData("", DateTime.Now, 0, "", "", "", "", "", "");
            }
            return dalOrderData.getDistinctYear();
        }

        public static DataTable getRevenueByMonth(int year)
        {
            if (dalOrderData == null)
            {
                dalOrderData = new DALOrderData("", DateTime.Now, 0, "", "", "", "", "", "");
            }
            return dalOrderData.getRevenueByMonth(year);
        }

        public static DataTable getRevenueByDate(int year, int month)
        {
            if (dalOrderData == null)
            {
                dalOrderData = new DALOrderData("", DateTime.Now, 0, "", "", "", "", "", "");
            }
            return dalOrderData.getRevenueByDay(year, month);
        }

        public static DataTable getRevenueByShift(int year, int month, int day)
        {
            if (dalOrderData == null)
            {
                dalOrderData = new DALOrderData("", DateTime.Now, 0, "", "", "", "", "", "");
            }
            return dalOrderData.getRevenueByShift(year, month, day);
        }

        public static DataTable getRevenueByYear()
        {
            if (dalOrderData == null)
            {
                dalOrderData = new DALOrderData("", DateTime.Now, 0, "", "", "", "", "", "");
            }
            return dalOrderData.getRevenueByYear();
        }
    }
}
