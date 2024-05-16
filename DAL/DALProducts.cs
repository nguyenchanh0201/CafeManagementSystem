using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Reflection;
using System.Security.Policy;
using System.Xml.Linq;

namespace DAL
{
    public class DALProducts
    {
        Product p;

        public DALProducts(string productID, string productName, string categoryID, decimal price, int status)
        {
            p = new Product(productID, productName, categoryID, price, status);
        }
        public string createProductID()
        {
            string sql = "exec GenerateNewProductID";
            return Connection.selectQuery(sql).Rows[0][0].ToString();
        }

        public List<Product> GetProducts()
        {
            string sql = "SELECT * FROM Products";
            List<Product> list = new List<Product>();
            foreach (DataRow dr in Connection.selectQuery(sql).Rows)
            {
                list.Add(new Product(dr));
            }
            return list;
        }

       public void insertProduct(string productName, string categoryID, decimal price)
        {
            string productID = createProductID();
            int status = 1;
            string sql = "INSERT INTO Products (pid, pname, price, status, cateID) VALUES ('" + productID + "', N'" + productName + "', '" + price + "','" + status + "','" + categoryID + "')";
            Connection.actionQuery(sql);
        }

        public void updateProduct(string productID, string productName, string categoryID, decimal price)
        {
            string sql = "update Products set pname = N'" + productName + "', cateID = '" + categoryID + "', price = '" + price + "' where PID = '" + productID + "'";
            
            Connection.actionQuery(sql);
        }

        public void deleteProduct(string productID)
        {
            string sql = "delete from Products where PID = '" + productID + "'";
            Connection.actionQuery(sql);
        }

        public List<Product> GetProductsByCategory(string categoryName)
        {
            List<Product> list = new List<Product>();
            string sql = "SELECT * FROM Products WHERE cateID = '" + categoryName + "'";
            DataTable dt = Connection.selectQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                Product p = new Product(dr);
                list.Add(p);
            }
            return list;
        }

        

        public DataTable select()
        {
            string sql = "SELECT * FROM Products";
            return Connection.selectQuery(sql);
        }






    }
}
