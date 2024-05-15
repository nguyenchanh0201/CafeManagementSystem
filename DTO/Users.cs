using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Users
    {

        private String username;
        private String password;
        private int roleID;
        private String name;
        private String phone;
        public Users(string username , string password, int roleID, string name, string phone)
        {
            this.username = username;
            this.password = password;
            this.roleID = roleID;
            this.name = name;
            this.phone = phone;
        }

        public Users(DataRow dr)
        {
            this.username = dr["username"].ToString();
            this.password = dr["password"].ToString();
            this.roleID = Convert.ToInt32(dr["roleID"]);

            this.name = dr["name"].ToString();
            this.phone = dr["phone"].ToString();
        }

        public String getUsername()
        {
            return username;
        }   

        public String getPassword()
        {
            return password;
        }

        public int getRoleID()
        {
            return roleID;
        }
        public String getName()
        {
            return name;
        }
        public String getPhone()
        {
            return phone;
        }



    }
}
