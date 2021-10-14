using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTech.BLL;
using System.Data.SqlClient;

namespace HiTech.DAL
{
    public static class AuthorDB
    {
        public static List<Author> GetListAuthor()
        {
            List<Author> listAuthor = new List<Author>();
            Author author;
            using (SqlConnection conn = UtilityDB.ConnectDB())
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Authors", conn);
                SqlDataReader sqlReader = cmdSelect.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        author = new Author();
                        author.AuthorId = Convert.ToInt32(sqlReader["AuthorId"]);
                        author.AuthorName = sqlReader["AuthorName"].ToString();
                        listAuthor.Add(author);
                    }
                }
                else
                {
                    listAuthor = null;
                }
            }
            return listAuthor;
        }
    }
}

