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
        private int customerID;
        private string customerName;
        private string phoneNumber;
        private string gender;
        private int points;
        private int rankID;

        public Customer(int customerID, string customerName, string phoneNumber, string gender, int points, int rankID)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
            this.points = points;
            this.rankID = rankID;
        }

        public int getCustomerID()
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

        public int getMembershipLevel()
        {
            return rankID;
        }

        public string getGender()
        {
            return gender;
        }
        public Customer(DataRow dr)
        {
            this.customerID = Convert.ToInt32(dr["id"]);
            this.customerName = dr["name"].ToString();
            this.phoneNumber = dr["phoneNum"].ToString();
            this.points = Convert.ToInt32(dr["points"]);
            this.rankID = Convert.ToInt32(dr["rankID"]);
            this.gender = dr["gender"].ToString();
        }
    }
}