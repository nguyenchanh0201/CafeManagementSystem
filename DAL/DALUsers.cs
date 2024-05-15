using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO ;
using System.Data;

namespace DAL
{
    public class DALUsers
    {
        Users u; 
        public DALUsers (String username, String password, int roleID,String name, String phone)
        {
            u = new Users(username, password, roleID,name, phone);
        }
        public void insert(String username, String password, int roleID, String name, String phone)
        {
            string sql = "insert into users values ('" + username + "','" + password + "','" + roleID + "','" + name + "','" + phone + "')";
            Connection.actionQuery(sql);
        }

        public bool login (String username, String password)
        {
            string sql = "select * from users where username = '" + username + "' and password = '" +  password + "'";
            if (Connection.check(sql))
            {
                System.Console.WriteLine(Connection.check(sql));
                return true;
                
            }
            return false;


        }
        public void updatePassword(String username, String password)
        {
            string sql = "update users set password = '" + password + "' where username = '" + username + "'";
            Connection.actionQuery(sql);
        }

        public string getRole(string username)
        {
            string sql = "SELECT roleName FROM Role WHERE roleID IN (SELECT roleID FROM users WHERE username = '" + username + "')";
            DataTable dt = Connection.selectQuery(sql);
            return dt.Rows[0][0].ToString();
        }

        public List<Users> getUsers()
        {
            List<Users> list = new List<Users>();
            string sql = "select * from users";
            DataTable dt = Connection.selectQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                Users u = new Users(dr);
                list.Add(u);
            }
            return list;
        }
        public void update(String username, String name, String phone)
        {
            string sql = "update users set name = '" + name + "', phone = '" + phone + "' where username = '" + username + "'";
            Connection.actionQuery(sql);
        }
        public void delete(String username)
        {
            string sql = "delete from users where username = '" + username + "'";
            Connection.actionQuery(sql);
        }
        public DataTable select()
        {
            string sql = "select * from users";


            return Connection.selectQuery(sql);
        }

    }
}
