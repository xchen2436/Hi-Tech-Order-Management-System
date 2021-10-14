using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTech.DAL;


namespace HiTech.BLL
{
    public class Customer
    {
        private int customerId;
        private string customerName;
        private string streetName;
        private string province;
        private string city;
        private string postalCode;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string StreetName { get => streetName; set => streetName = value; }
        public string Province { get => province; set => province = value; }
        public string City { get => city; set => city = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }

        public List<Customer> ListCustomer()
        {
            return CustomerDB.GetListCustomer();
        }
    }
}
