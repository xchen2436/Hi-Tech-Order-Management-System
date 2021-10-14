using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTech.BLL;
using System.Data.SqlClient;

namespace HiTech.DAL
{
    public static class PublisherDB
    {
        public static List<Publisher> GetListPublisher()
        {
            List<Publisher> listPublisher = new List<Publisher>();
            Publisher apublisher;
            using (SqlConnection conn = UtilityDB.ConnectDB())
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Publishers", conn);
                SqlDataReader sqlReader = cmdSelect.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        apublisher = new Publisher();
                        apublisher.PublisherId = Convert.ToInt32(sqlReader["PublisherId"]);
                        apublisher.PublisherName = sqlReader["PublisherName"].ToString();
                        listPublisher.Add(apublisher);
                    }
                }
                else
                {
                    listPublisher = null;
                }
            }
            return listPublisher;
        }
    }
}

