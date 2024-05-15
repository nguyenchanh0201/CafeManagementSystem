using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Role
    {
        private int roleID;
        private String roleName;

        public Role(int roleID, String roleName)
        {
            this.roleID = roleID;
            this.roleName = roleName;
        }

        public int getRoleID()
        {
            return roleID;
        }

        public String getRoleName()
        {
            return roleName;
        }
        public Role(DataRow dr)
        {
            this.roleID = Convert.ToInt32(dr["roleID"]);
            this.roleName = dr["roleName"].ToString();
        }

    }
}
