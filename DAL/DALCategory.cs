using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DALCategory
    {
        ProductCategory pc;

        public DALCategory(string categoryID, string categoryName)
        {
            pc = new ProductCategory(categoryID, categoryName);
        }

        public string getCategoryName()
        {
            return pc.getCategoryName();
        }
        public string createCategoryID()
        {
            string sql = "exec GenerateNewCategoryID";
            return Connection.selectQuery(sql).Rows[0][0].ToString();
        }

        public List<ProductCategory> getCategory() {
            string sql = "SELECT * FROM Categories";
            List<ProductCategory> list = new List<ProductCategory>();
            foreach (DataRow dr in Connection.selectQuery(sql).Rows)
            {
                list.Add(new ProductCategory(dr));
            }
            return list;
        }
        public void insertCategory(string categoryName)
        {
            string categoryID = createCategoryID();
            string sql = "insert into Categories values('" + categoryID + "', N'" + categoryName + "')";
            Connection.actionQuery(sql);
        }
        public void deleteCategory(string categoryID)
        {
            string sql = "delete from Categories where CateID = '" + categoryID + "'";
            Connection.actionQuery(sql);
        }
        public void updateCategory(string categoryName,string categoryID)
        {
            string sql = "update Categories set CateName = N'" + categoryName + "' where CateID = '" + categoryID + "'";
            Connection.actionQuery(sql);
        }
        public DataTable select()
        {
            string sql = "SELECT * FROM Categories";
            return Connection.selectQuery(sql);
        }

    }
}
