using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLProducts
    {
        static DALProducts dalproducts;

        public BLLProducts(string productID, string productName, string categoryID,  decimal price, int status)
        {
            dalproducts = new DALProducts(productID, productName, categoryID, price, status);
        }

        public static List<Product> GetProducts()
        {
            if (dalproducts == null)
            {
                dalproducts = new DALProducts("", "", "", 0, 1);
            }
            return dalproducts.GetProducts();
        }

        public static DataTable select ()
        {
            if (dalproducts == null )
            {
                dalproducts = new DALProducts("", "", "", 0, 1);
            }
            return dalproducts.select();
        }


        public static void insert(string productName, string categoryID, decimal price)
        {
            if (dalproducts == null)
            {
                dalproducts = new DALProducts("", "", "", 0, 1);
            }
            dalproducts.insertProduct(productName, categoryID, price);
        }

        public static void update(string productID, string productName, string categoryID, decimal price)
        {
            if (dalproducts == null)
            {
                dalproducts = new DALProducts("", "", "", 0, 1);
            }
            dalproducts.updateProduct(productID, productName, categoryID, price);
        }

        public static void delete(string productID)
        {
            if (dalproducts == null)
            {
                dalproducts = new DALProducts("", "", "", 0, 1);
            }
            dalproducts.deleteProduct(productID);
        }
        public static List<Product> GetProductsByCategory(string categoryname)
        {
            if (dalproducts == null)
            {
                dalproducts = new DALProducts("", "", "", 0, 1);
            }
            return dalproducts.GetProductsByCategory(categoryname);
        }

        
    }
}
