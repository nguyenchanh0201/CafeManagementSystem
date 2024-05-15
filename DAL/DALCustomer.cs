using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DALCustomer
    {
        Customer c;

        public DALCustomer(string customerID, string customerName, string phoneNumber, string gender, int points, string rankID)
        {
            c = new Customer(customerID, customerName, phoneNumber, gender, points, rankID);
        }

        public string createCustomerID()
        {
            string sql = "exec CreateCustomerID";
            return Connection.selectQuery(sql).Rows[0][0].ToString();
        }

        public void insert(String customerName, String phoneNumber, string gender, int points, string rankID)
        {
            
            string customerID = createCustomerID();
            string sql = "INSERT INTO Customers (id, name, phoneNum, gender, points, rankID) VALUES ('" + customerID + "', N'" + customerName + "', '" + phoneNumber + "','" + gender + "'," + points + ", '" + rankID + "')";

            // Rest of the code

            Connection.actionQuery(sql);
        }

        public void update(String customerName, String phoneNumber, string customerID)
        {
            string sql = "update Customers set name = N'" + customerName + "', phoneNum = '" + phoneNumber + "' where id = '" + customerID + "'";
            Connection.actionQuery(sql);
        }
        public void delete(string customerID)
        {
            string sql = "delete from Customers where id = '" + customerID + "'";
            Connection.actionQuery(sql);
        }


        public List<Customer> getCustomer()
        {
            List<Customer> list = new List<Customer>();
            string sql = "select * from Customers";
            DataTable dt = Connection.selectQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                Customer c = new Customer(dr);
                list.Add(c);
            }
            return list;
        }
        public DataTable select()
        {
            string sql = "select * from Customers";
            return Connection.selectQuery(sql);
        }

        public List<Customer> getCustomerByPhone(string phoneNumber)
        {
            string sql = "select * from Customers where phoneNum = '" + phoneNumber + "'";
            List<Customer> list = new List<Customer>();
            DataTable dt = Connection.selectQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                Customer c = new Customer(dr);
                list.Add(c);
            }
            return list;
        }

        public void updateCustomerPoints(string customerID, int points)
        {
            string sql = "update Customers set points = points + " + points + " where id = '" + customerID + "'";
            Connection.actionQuery(sql);
        }



    }
}