using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class DALRank
    {
        Rank r;
        public DALRank(string rankID, String rankName, int goalPoints, int discount)
        {
            r = new Rank(rankID, rankName, goalPoints, discount);
        }
        public string createRankID()
        {
            string sql = "exec GenerateRankID";
            return Connection.selectQuery(sql).Rows[0][0].ToString();
        }
        public void insert(String rankName, int goalPoints, int discount)
        {
            string rankId = createRankID();
            string sql = "insert into Ranks values ('" + rankId + "', N'" + rankName + "'," + goalPoints + "," + discount + ")";
            Connection.actionQuery(sql);
        }
        public void update(String rankName, int goalPoints, int discount, string rankID)
        {
            string sql = "update Ranks set rankName = N'" + rankName + "', goalPoints = " + goalPoints + ", discount = " + discount + " where rankID = '" + rankID + "'";
            Connection.actionQuery(sql);
        }
        public void delete(string rankID)
        {
            string sql = "delete from Ranks where rankID = '" + rankID + "'";
            Connection.actionQuery(sql);
        }
        public List<Rank> getRank()
        {
            List<Rank> list = new List<Rank>();
            string sql = "select * from Ranks order by goalPoints ";
            DataTable dt = Connection.selectQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                Rank r = new Rank(dr);
                list.Add(r);
            }
            return list;
        }
        public DataTable select()
        {
            string sql = "select * from Ranks order by goalPoints";
            return Connection.selectQuery(sql);
        }
        
    }
}
