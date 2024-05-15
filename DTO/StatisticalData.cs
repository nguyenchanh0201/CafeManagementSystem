using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StatisticalData
    {

        private int statisticalID;
        private DateTime orderDate;
        private TimeSpan orderTime;
        private string orderMethod;
        private float total;
        private int customerID;

        public StatisticalData(int statisticalID, DateTime orderDate, TimeSpan orderTime, string orderMethod, float total, int customerID)
        {
            this.statisticalID = statisticalID;
            this.orderDate = orderDate;
            this.orderTime = orderTime;
            this.orderMethod = orderMethod;
            this.total = total;
            this.customerID = customerID;
        }

        public int getStatisticalID()
        {
            return statisticalID;
        }

        public DateTime getOrderDate()
        {
            return orderDate;
        }

        public TimeSpan getOrderTime()
        {
            return orderTime;
        }

        public string getOrderMethod()
        {
            return orderMethod;
        }

        public float getTotal()
        {
            return total;
        }

        public int getCustomerID()
        {
            return customerID;
        }
    }
}
