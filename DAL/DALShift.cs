using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALShift
    {
         Shift s; 

        public DALShift(String shiftID, DateTime shiftStart, DateTime shiftEnd, string username)
        {
            s = new Shift(shiftID, shiftStart, shiftEnd, username);
        }

        public string getShiftID()
        {
            return s.getShiftID();
        }


        //Create a method to create shift ID 
        public string createShiftID()
        {
            //Call for procedure 
            string sql = "exec generate_shiftID";
            string shiftID = Connection.selectQuery(sql).Rows[0][0].ToString();

            return shiftID;
        }


        public  void addShift(DateTime shiftStart, DateTime shiftEnd, string username)
        {
            //Add to shift table
            
            string shiftID = createShiftID();

            string sql = "insert into Shift values ('" + shiftID + "','" + shiftStart + "','" + username + "','" + shiftEnd + "')";
            Connection.actionQuery(sql);
        }

        public void updateShift(String shiftID, DateTime shiftEnd)
        {             //Update shift table
                      string sql = "update Shift set shiftEnd = '" + shiftEnd + "' where shiftID = '" + shiftID + "'";
                                             Connection.actionQuery(sql);
                                                   }
        }
    }
