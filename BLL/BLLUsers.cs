using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL; 
using System.Data;
using DTO;
namespace BLL

{
    public class BLLUsers
    {
        static DALUsers dalusers;

        public BLLUsers(String username, String password, int roleID,String name,String phone)
        {
            dalusers = new DALUsers(username, password, roleID,name,phone);
        }

        public void insert(String username, String password, int roleID, String name, String phone)
        {
            dalusers.insert(username, password, roleID, name, phone);
        }


        public bool login(String username, String password)
        {
            return dalusers.login(username,password);
        }

        public static String getRole(String username)
        {
            if (dalusers == null)
            {
                dalusers = new DALUsers("", "", 0, "", "");
            }
            return dalusers.getRole(username);
        }

        public void updatePassword(String username, String password)
        {
            dalusers.updatePassword(username, password);
        }
        public static List<Users> getUsers()
        {
            return dalusers.getUsers();
        }
        public static DataTable select()
        {
            if (dalusers == null) { 
                dalusers = new DALUsers("", "", 0, "", ""); 
            }
            return dalusers.select();
        }
        public static void update(String username, String name, String phone)
        {
            if (dalusers == null)
            {
                dalusers = new DALUsers("", "", 0,"","");
            }
            dalusers.update(username, name, phone);
        }
        public static void delete(String username)
        {
            if (dalusers == null)
            {
                dalusers = new DALUsers("", "", 0, "", "");
            }
            dalusers.delete(username);
        }


    }
}
