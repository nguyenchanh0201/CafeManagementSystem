using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Rank
    {
        private string rankID;
        private String rankName;
        private int goalPoints;
        private int discount;

        public Rank(string rankID, String rankName, int goalPoints, int discount)
        {
            this.rankID = rankID;
            this.rankName = rankName;
            this.goalPoints = goalPoints;
            this.discount = discount;
        }
        public string getRankID()
        {
            return rankID;
        }
        public String getRankName()
        {
            return rankName;
        }
        public int getGoalPoints()
        {
            return goalPoints;
        }
        public int getDiscount()
        {
            return discount;
        }
        public Rank(DataRow dr)
        {
            this.rankID = dr["rankID"].ToString();
            this.rankName = dr["rankName"].ToString();
            this.goalPoints = Convert.ToInt32(dr["goalPoints"]);
            this.discount = Convert.ToInt32(dr["discount"]);
        }
    }
}
