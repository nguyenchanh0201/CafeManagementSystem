using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        private string customerID;
        private string customerName;
        private string phoneNumber;
        private string gender;
        private int points;
        private string rankID;

        public Customer(string customerID, string customerName, string phoneNumber, string gender, int points, string rankID)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
            this.points = points;
            this.rankID = rankID;
        }

        public string getCustomerID()
        {
            return customerID;
        }

        public string getCustomerName()
        {
            return customerName;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public int getPoints()
        {
            return points;
        }

        public string getMembershipLevel()
        {
            return rankID;
        }

        public string getGender()
        {
            return gender;
        }
        public Customer(DataRow dr)
        {
            this.customerID = dr["id"].ToString();
            this.customerName = dr["name"].ToString();
            this.phoneNumber = dr["phoneNum"].ToString();
            this.points = Convert.ToInt32(dr["points"]);
            this.rankID = dr["rankID"].ToString();
            this.gender = dr["gender"].ToString();
        }
    }
}