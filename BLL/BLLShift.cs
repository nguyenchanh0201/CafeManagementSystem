using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL; 

namespace BLL
{
    public class BLLShift
    {
        static DALShift dalshift;

        public BLLShift(String shiftID, DateTime shiftStart, DateTime shiftEnd, string username)
        {
            dalshift = new DALShift(shiftID, shiftStart, shiftEnd, username);
        }

        public  string createShiftID()
        {
            if (dalshift == null)
            {
                DALShift dalshift = new DALShift("", DateTime.Now, DateTime.Now, "");
            }
            return dalshift.createShiftID();
        }   

        public void addShift(DateTime shiftStart, DateTime shiftEnd, string username)
        {
            if (dalshift == null)
            {
                DALShift dalshift = new DALShift("", DateTime.Now, DateTime.Now, "");
            }
            dalshift.addShift(shiftStart, shiftEnd, username);
        }

        public void updateShift(String shiftID, DateTime shiftEnd)
        {
            if (dalshift == null)
            {
                DALShift dalshift = new DALShift("", DateTime.Now, DateTime.Now, "");
            }
            dalshift.updateShift(shiftID, shiftEnd);
        }
    }
}
