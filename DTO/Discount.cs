using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Discount
    {

        private int discountID;
        private string discountCode;
        private float percentage;

        public Discount(int discountID, string discountCode, float percentage)
        {
            this.discountID = discountID;
            this.discountCode = discountCode;
            this.percentage = percentage;
        }

        public int getDiscountID()
        {
            return discountID;
        }

        public string getDiscountCode()
        {
            return discountCode;
        }

        public float getPercentage()
        {
            return percentage;
        }
    }
}
