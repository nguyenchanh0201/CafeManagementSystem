using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLLTableCards
    {
        static DALTableCards daltablecards;

        public BLLTableCards(String tableID, string tableName, string status)
        {
            daltablecards = new DALTableCards(tableID, tableName, status);
        }

        public static List<TableCard> getTableCards()
        {
            if (daltablecards == null)
            {
                daltablecards = new DALTableCards("", "", "");
            }


            return daltablecards.getTableCards();
        }
        public static DataTable select()
        {
            if (daltablecards == null)
            {
                daltablecards = new DALTableCards("", "", "");
            }
            return daltablecards.select();
        }

        public static void insertTableCard(String tableName)
        {
            daltablecards.insertTableCard(tableName);
        }

        public static void updateTableCard(string tableID,String tableName,String status)
        {
            if (daltablecards == null)
            {
                daltablecards = new DALTableCards("", "", "");
            }
            daltablecards.updateTableCard(tableID, tableName, status);
        }
        public static void deleteTableCard(string tableCardID)
        {
            if (daltablecards == null)
            {
                daltablecards = new DALTableCards("", "", "");
            }
            daltablecards.deleteTableCard(tableCardID);
        }

        public static void changeStatus(string tableID, string status)
        {
            if (daltablecards == null)
            {
                daltablecards = new DALTableCards("", "", "");
            }
            daltablecards.changeStatus(tableID, status);
        }
    }
}
