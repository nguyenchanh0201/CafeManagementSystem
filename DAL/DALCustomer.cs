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

        public DALCustomer(int customerID, string customerName, string phoneNumber, string gender, int points, int rankID)
        {
            c = new Customer(customerID, customerName, phoneNumber, gender, points, rankID);
        }

        public string createCustomerID()
        {
            string sql = "exec CreateCustomerID";
            return Connection.selectQuery(sql).Rows[0][0].ToString();
        }

        public void insert(String customerName, String phoneNumber, string gender, int points, int rankID)
        {
            string rankID1 = rankID.ToString();
            string customerID = createCustomerID();
            string sql = "insert into Customers values('" + customerID + "', N'" + customerName + "', '" + phoneNumber + "','" + gender + "'," + points + ", " + rankID1 + ")";
            // Rest of the code
            Connection.actionQuery(sql);
        }

        public void update(String customerName, String phoneNumber, int customerID)
        {
            string sql = "update Customers set name = N'" + customerName + "', phoneNum = '" + phoneNumber + "' where id = '" + customerID + "'";
            Connection.actionQuery(sql);
        }
        public void delete(int customerID)
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




    }
}