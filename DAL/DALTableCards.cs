using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Security.Cryptography;

namespace DAL
{
    public class DALTableCards
    {

        TableCard tc;
        public DALTableCards(String tableID, string tableName, string status)
        {
            tc = new TableCard(tableID, tableName, status);
        }

        public List<TableCard> getTableCards()
        {
            List<TableCard> list = new List<TableCard>();
            string sql = "SELECT * FROM tableCards ORDER BY CAST(RIGHT(id, LEN(id) - 1) AS INT);";
            DataTable dt = Connection.selectQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new TableCard(dr));
            }
            return list;

        }
        public DataTable select()
        {
            String sql = "SELECT * FROM tableCards ORDER BY CAST(RIGHT(id, LEN(id) - 1) AS INT);";
            return Connection.selectQuery(sql);
        }

        public void insertTableCard(string tableName)
        {
            string tableID = createTableID();
            string sql = "insert into tableCards values('" + tableID + "','" + tableName + "','Empty')";

            Connection.actionQuery(sql);
        }

        public void updateTableCard(String tableID,String tableName,String status)
        {
            string sql = "update tableCards set tableName = '" + tableName + "', status = '" + status + "' where id = '" + tableID + "'";
            Connection.actionQuery(sql);
        }
        public void deleteTableCard(string tableID)
        {
            string sql = "delete from tableCards where id = '" + tableID + "'";
            Connection.actionQuery(sql);
        }

        public string createTableID()
        {
            string sql = "exec GenerateNewTableID";
            DataTable dt = Connection.selectQuery(sql);
            return dt.Rows[0][0].ToString();

        }

        public void changeStatus(string tableID, string status)
        {
            if(status == "Empty")
            {
                status = "Taken";
            }
            else if(status == "Taken")
            {
                status = "Empty";
            }

            string sql = "update tableCards set status = '" + status + "' where id = '" + tableID + "'";
            Connection.actionQuery(sql);
        }

    }
}
