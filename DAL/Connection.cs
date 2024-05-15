using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection cn;
        public static void connect()
        {
            string s = "initial catalog = CafeTest; data source = LAPTOP-2RPKDMIN; integrated security = true";
            cn = new SqlConnection(s);
            cn.Open();

        }
        public static void actionQuery(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, cn);

            cmd.ExecuteNonQuery();
        }
        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public static bool check(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }



        
    }
}
