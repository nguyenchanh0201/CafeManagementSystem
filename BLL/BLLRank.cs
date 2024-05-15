using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLLRank
    {
        static DALRank dalRank;
        public BLLRank(string rankID, String rankName, int goalPoints, int discount)
        {
            dalRank = new DALRank(rankID, rankName, goalPoints, discount);
        }
        public string createRankID()
        {
            return dalRank.createRankID();
        }
        public static void insert(String rankName, int goalPoints, int discount)
        {
            if (dalRank == null)
            {
                dalRank = new DALRank("", "", 0, 0);
            }
            dalRank.insert(rankName, goalPoints, discount);
        }
        public static  void update(String rankName, int goalPoints, int discount,string rankID)
        {
            if (dalRank == null)
            {
                dalRank = new DALRank("", "", 0, 0);
            }
            dalRank.update(rankName, goalPoints, discount,rankID);
        }
        public static void delete(string rankID)
        {
            if (dalRank == null)
            {
                dalRank = new DALRank("", "", 0, 0);
            }
            dalRank.delete(rankID);
        }
        public static  List<Rank> getRank()
        {
            if (dalRank == null)
            {
                dalRank = new DALRank("", "", 0, 0);
            }
            return dalRank.getRank();
        }
        public static DataTable select()
        {
            if (dalRank == null)
            {
                dalRank = new DALRank("", "", 0, 0);
            }
            return dalRank.select();
        }
    }
}
