using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO; 
using System.Data;

namespace BLL
{
    public class BLLCategories
    {

        static DALCategory dalcategory;

        public BLLCategories(string categoryID, string categoryName)
        {
            dalcategory = new DALCategory(categoryID, categoryName);
        }
        public string createCategoryID()
        {
            return dalcategory.createCategoryID();
        }
        
        public static string getCategoryName()
        {
            return dalcategory.getCategoryName();
        }

        public static  List<ProductCategory> getCategory()
        {
            if (dalcategory == null)
            {
                dalcategory = new DALCategory("", "");
            }
            return dalcategory.getCategory();
        }
        public static void insert(string categoryName)
        {
            if (dalcategory == null)
            {
                dalcategory = new DALCategory("", "");
            }
            dalcategory.insertCategory(categoryName);
        }
        public static void update(string categoryName,string categoryID)
        {
            if (dalcategory == null)
            {
                dalcategory = new DALCategory("", "");
            }
            dalcategory.updateCategory(categoryName,categoryID);
        }
        public static void delete(string categoryID)
        {
            if (dalcategory == null)
            {
                dalcategory = new DALCategory("", "");
            }
            dalcategory.deleteCategory(categoryID);
        }
        public static DataTable select()
        {
            if (dalcategory == null)
            {
                dalcategory = new DALCategory("", "");
            }
            return dalcategory.select();
        }
    }
}
