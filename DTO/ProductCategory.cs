using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductCategory
    {

        private string categoryID;
        private string categoryName;
        public ProductCategory(string categoryID, string categoryName)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
        }

        public string getCategoryID()
        {
            return categoryID;
        }

        public string getCategoryName()
        {
            return categoryName;
        }

        public ProductCategory(DataRow dr)
        {
            this.categoryID = dr["CateID"].ToString()  ;
            this.categoryName = dr["CateName"].ToString();
        }
    }
}
