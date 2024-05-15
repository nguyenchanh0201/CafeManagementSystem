using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Shift
    {
        private string shiftID;
        private DateTime shiftStart;
        private DateTime shiftEnd;
        private string username; 

        public Shift(string shiftID, DateTime shiftStart, DateTime shiftEnd, string username)
        {
            this.shiftID = shiftID;
            
            this.shiftStart = shiftStart;
            this.shiftEnd = shiftEnd;
            this.username = username;
        }

        public string getShiftID()
        {
            return shiftID;
        }

        public string getUsername()
        {
            return username;
        }

        public DateTime getShiftStart()
        {
            return shiftStart;
        }

        public DateTime getShiftEnd()
        {
            return shiftEnd;
        }
        public TimeSpan getShiftDuration()
        {
            return shiftEnd - shiftStart;
        }
    }
}
