using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTech.BLL;
using System.Data.SqlClient;

namespace HiTech.DAL
{
    public static class CustomerDB
    {
        public static List<Customer> GetListCustomer()
        {
            List<Customer> listCustomer = new List<Customer>();
            Customer customer;
            using (SqlConnection conn = UtilityDB.ConnectDB())
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Customers", conn);
                SqlDataReader sqlReader = cmdSelect.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        customer = new Customer();
                        customer.CustomerId = Convert.ToInt32(sqlReader["CustomerId"]);
                        customer.CustomerName = sqlReader["CustomerName"].ToString();
                        customer.Province = sqlReader["Province"].ToString();
                        customer.StreetName = sqlReader["StreetName"].ToString();
                        customer.City = sqlReader["City"].ToString();
                        customer.PostalCode = sqlReader["PostalCode"].ToString();
                        listCustomer.Add(customer);
                    }
                }
                else
                {
                    listCustomer = null;
                }
            }
            return listCustomer;
        }
    }
}
