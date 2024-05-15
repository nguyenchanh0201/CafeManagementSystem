using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BLL
{
    public  class BLLRole
    {
        static DALRole dalRole;

        public BLLRole(int roleID, String roleName)
        {
            dalRole = new DALRole(roleID, roleName);
        }

        public void insert(String  roleName)
        {
            dalRole.insert(roleName);
        }

        public static void update(int roleID, String roleName)
        {
            if (dalRole == null)
            {
                dalRole = new DALRole(0, "");
            }
            dalRole.update(roleID, roleName);
        }

        public static void delete(int roleID)
        {
            if (dalRole == null)
            {
                dalRole = new DALRole(0, "");
            }
            dalRole.delete(roleID);
        }

        public static List<Role> getRole()
        {
            if (dalRole == null)
            {
                dalRole = new DALRole(0, "");
            }
            return dalRole.getRole();
        }
        public static DataTable select()
        {
            if (dalRole == null)
            {
                dalRole = new DALRole(0, "");
            }
            return dalRole.select();
        }
       
    }
}
