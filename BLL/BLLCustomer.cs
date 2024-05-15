using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLCustomer
    {
        static DALCustomer dalCustomer;
        public BLLCustomer(int customerID, String customerName, String phoneNumber, string gender, int points, int rankID)
        {
            dalCustomer = new DALCustomer(customerID, customerName, phoneNumber, gender, points, rankID);
        }

        public string createCustomerID()
        {
            return dalCustomer.createCustomerID();
        }

        public static void insert(String customerName, String phoneNumber, String gender, int points, int rankID)
        {
            if (dalCustomer == null)
            {
                dalCustomer = new DALCustomer(0, "", "", "", 0, 0);
            }
            dalCustomer.insert(customerName, phoneNumber, gender, points, rankID);
        }
        public static void update(String customerName, String phoneNumber,int customerID)
        {
            if(dalCustomer == null)
            {
                dalCustomer = new DALCustomer(0, "", "", "", 0, 0);
            }
            dalCustomer.update(customerName, phoneNumber,customerID);
        }
        public static void delete(int customerID)
        {
            if (dalCustomer == null)
            {
                dalCustomer = new DALCustomer(0, "", "", "", 0, 0);
            }
            dalCustomer.delete(customerID);
        }
        public static List<Customer> getCustomer()
        {
            if (dalCustomer == null)
            {
                dalCustomer = new DALCustomer(0, "", "", "", 0, 0);
            }
            return dalCustomer.getCustomer();
        }
        public static DataTable select()
        {
            if (dalCustomer == null)
            {
                dalCustomer = new DALCustomer(0, "", "", "", 0, 0);
            }
            return dalCustomer.select();
        }

        public static List<Customer> getCustomerByPhone(string phoneNum)
        {
            if (dalCustomer == null)
            {
                dalCustomer = new DALCustomer(0, "", "", "", 0, 0);
            }
            return dalCustomer.getCustomerByPhone(phoneNum);
        }
        
    }
}