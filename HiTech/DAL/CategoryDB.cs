using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTech.BLL;
using System.Data.SqlClient;

namespace HiTech.DAL
{
    public static class CategoryDB
    {
        public static List<Category> GetListCategory()
        {
            List<Category> listCategory = new List<Category>();
            Category acategory;
            using (SqlConnection conn = UtilityDB.ConnectDB())
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Categories", conn);
                SqlDataReader sqlReader = cmdSelect.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        acategory = new Category();
                        acategory.CategoryId = Convert.ToInt32(sqlReader["CategoryId"]);
                        acategory.CategoryName = sqlReader["CategoryName"].ToString();
                        listCategory.Add(acategory);
                    }
                }
                else
                {
                    listCategory = null;
                }
            }
            return listCategory;
        }
    }
}

