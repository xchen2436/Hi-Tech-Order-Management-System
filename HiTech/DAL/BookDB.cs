using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTech.BLL;
using System.Data.SqlClient;

namespace HiTech.DAL
{
    public static class BookDB
    {
        public static List<Books> GetListBook()
        {
            List<Books> listBook = new List<Books>();
            Books books;
            using (SqlConnection conn = UtilityDB.ConnectDB())
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Books", conn);
                SqlDataReader sqlReader = cmdSelect.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        books = new Books();
                        books.ISBN = Convert.ToInt64(sqlReader["ISBN"]);
                        books.BookTitle = sqlReader["BookTitle"].ToString();
                        books.QOH = Convert.ToInt32(sqlReader["QOH"]);
                        books.Price = Convert.ToDouble(sqlReader["Price"]);
                        books.AuthorId = Convert.ToInt32(sqlReader["AuthorId"]);
                        books.CategoryId = Convert.ToInt32(sqlReader["CategoryId"]);
                        books.PublisherId = Convert.ToInt32(sqlReader["PublisherId"]);
                        books.YearPublished = sqlReader["YearPublished"].ToString();
                        books.Edition = sqlReader["Edition"].ToString();
                        listBook.Add(books);
                    }
                }
                else
                {
                    listBook = null;
                }
            }
            return listBook;
        }
    }
}

