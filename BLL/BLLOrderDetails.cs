using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLOrderDetails
    {
       static  DALOrderDetails dalorderdetails;

        public BLLOrderDetails(int orderDetailID, string orderID, string productID, string productName,  int quantity, decimal price)
        {
            dalorderdetails = new DALOrderDetails(orderDetailID, orderID, productID,productName, quantity, price);
        }

        public int getOrderDetailID()
        {
            return dalorderdetails.getOrderDetailID();
        }

        public string getOrderID()
        {
            return dalorderdetails.getOrderID();
        }


        public string getProductID()
        {
            return dalorderdetails.getProductID();
        }

        public int getQuantity()
        {
            return dalorderdetails.getQuantity();
        }

        public decimal getPrice()
        {
            return dalorderdetails.getPrice();
        }

        public static void AddOrderDetail(string orderID, string productID, string productName, int quantity, decimal price)
        {
            if (dalorderdetails == null)
            {
                dalorderdetails = new DALOrderDetails(0,"", "", "", 0, 0);
            }
            dalorderdetails.AddOrderDetail(orderID, productID, productName, quantity, price);
        }

        public static DataTable GetData(String orderID)
        {
            if (dalorderdetails == null)
            {
                dalorderdetails = new DALOrderDetails(0, "", "", "", 0, 0);
            }
            return dalorderdetails.GetData(orderID);
        }

        public static void updateQuantity(int orderDetailID, int quantity)
        {
            if (dalorderdetails == null)
            {
                dalorderdetails = new DALOrderDetails(0, "", "", "", 0, 0);
            }
            dalorderdetails.updateQuantity(orderDetailID, quantity);
        }

        public static void deleteOrderDetail(int orderDetailID)
        {
            if (dalorderdetails == null)
            {
                dalorderdetails = new DALOrderDetails(0, "", "", "", 0, 0);
            }
            dalorderdetails.deleteOrderDetail(orderDetailID);
        }

        public static List<OrderDetail> getOrderDetailsListByOrderID(string orderID)
        {
            if (dalorderdetails == null)
            {
                dalorderdetails = new DALOrderDetails(0, "", "", "", 0, 0);
            }
            return dalorderdetails.GetOrderDetails(orderID);
        }
    }
}
