using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTech.VALIDATION;
using HiTech.BLL;
using HiTech.DAL;
using System.Data.SqlClient;


namespace HiTech.GUI
{
    public partial class FormSalesManager : Form
    {
        SqlDataAdapter da;
        DataSet dsCustomer;
        DataTable dtCustomer;
        SqlCommandBuilder sqlBuilder;
        Customer aCourse = new Customer();
        public FormSalesManager()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
        }

        private void buttonListEmployee_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            dataGridViewCustomer.DataSource = customer.ListCustomer();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            string cusId = textBoxCusId.Text.Trim();
            if (!(Validator.IsValidId(cusId)))
            {
                MessageBox.Show("Customer ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCusId.Clear();
                textBoxCusId.Focus();
                return;
            }
            int searchbyid = Convert.ToInt32(textBoxCusId.Text.Trim());
            DataRow searchcustomer = dtCustomer.Rows.Find(searchbyid);
            if (searchcustomer != null)
            {
                MessageBox.Show("This Customer ID already exists!", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCusId.Clear();
                textBoxCusId.Focus();
                return;
            }
            string cusName = textBoxCustomerName.Text.Trim();
            if (!(Validator.IsValidName(cusName)))
            {
                MessageBox.Show("Invalid Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerName.Clear();
                textBoxCustomerName.Focus();
                return;
        }
            string cusprovince = textBoxProvince.Text.Trim();
            if ((Validator.IsEmpty(cusprovince)))
            {
                MessageBox.Show("Province is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxProvince.Clear();
                textBoxProvince.Focus();
                return;
            }
            string cuscity = textBoxCity.Text.Trim();
            if ((Validator.IsEmpty(cuscity)))
            {
                MessageBox.Show("City is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCity.Clear();
                textBoxCity.Focus();
                return;
            }
            string cuscode = textBoxPostcode.Text.Trim();
            if ((Validator.IsEmpty(cuscode)))
            {
                MessageBox.Show("Postcode is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPostcode.Clear();
                textBoxPostcode.Focus();
                return;
            }
            DataRow addcustomer = dtCustomer.NewRow();
            addcustomer["CustomerId"] = Convert.ToInt32(textBoxCusId.Text.Trim());
            addcustomer["CustomerName"] = textBoxCustomerName.Text.Trim();
            addcustomer["StreetName"] = textBoxStreetName.Text.Trim();
            addcustomer["Province"] = textBoxProvince.Text.Trim();
            addcustomer["City"] = textBoxCity.Text.Trim();
            addcustomer["PostalCode"] = textBoxPostcode.Text.Trim();
            dtCustomer.Rows.Add(addcustomer);
            MessageBox.Show("The customer has been added sucessfully.", "Confirmation");
            textBoxCusId.Clear();
            textBoxCustomerName.Clear();
            textBoxStreetName.Clear();
            textBoxProvince.Clear();
            textBoxCity.Clear();
            textBoxPostcode.Clear();
        }

        private void FormSalesManager_Load(object sender, EventArgs e)
        {
            dsCustomer = new DataSet("CustomerDS");
            dtCustomer = new DataTable("Customer");
            dsCustomer.Tables.Add(dtCustomer);
            dtCustomer.Columns.Add("CustomerId", typeof(Int32));
            dtCustomer.Columns.Add("CustomerName", typeof(string));
            dtCustomer.Columns.Add("StreetName", typeof(string));
            dtCustomer.Columns.Add("CourseProvinceTitle", typeof(string));
            dtCustomer.Columns.Add("City", typeof(string));
            dtCustomer.Columns.Add("PostalCode", typeof(string));
            dtCustomer.PrimaryKey = new DataColumn[] { dtCustomer.Columns["CustomerId"] };
            da = new SqlDataAdapter("SELECT * FROM Customers", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da);
            da.Fill(dsCustomer.Tables["Customer"]);

        }

        private void buttonUpdateDatabase_Click(object sender, EventArgs e)
        {
            da.Update(dsCustomer.Tables["Customer"]);
            MessageBox.Show("Database has been updated sucessfully.", "Confirmation");
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            string cusId = textBoxCusId.Text.Trim();
            if (!(Validator.IsValidId(cusId)))
            {
                MessageBox.Show("Customer ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCusId.Clear();
                textBoxCusId.Focus();
                return;
            }
            
            string cusprovince = textBoxProvince.Text.Trim();
            if ((Validator.IsEmpty(cusprovince)))
            {
                MessageBox.Show("Province is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxProvince.Clear();
                textBoxProvince.Focus();
                return;
            }
            string cuscity = textBoxCity.Text.Trim();
            if ((Validator.IsEmpty(cuscity)))
            {
                MessageBox.Show("City is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCity.Clear();
                textBoxCity.Focus();
                return;
            }
            string cuscode = textBoxPostcode.Text.Trim();
            if ((Validator.IsEmpty(cuscode)))
            {
                MessageBox.Show("Postcode is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPostcode.Clear();
                textBoxPostcode.Focus();
                return;
            }
            int searchbyid = Convert.ToInt32(textBoxCusId.Text.Trim());
            DataRow searchcustomer = dtCustomer.Rows.Find(searchbyid);
            if (searchcustomer != null)
            {
                DataRow updatecustomer = dtCustomer.Rows.Find(searchbyid);
                updatecustomer["CustomerId"] = Convert.ToInt32(textBoxCusId.Text.Trim());
                updatecustomer["CustomerName"] = textBoxCustomerName.Text.Trim();
                updatecustomer["StreetName"] = textBoxStreetName.Text.Trim();
                updatecustomer["Province"] = textBoxProvince.Text.Trim();
                updatecustomer["City"] = textBoxCity.Text.Trim();
                updatecustomer["PostalCode"] = textBoxPostcode.Text.Trim();
                MessageBox.Show("The customer has been updated sucessfully.", "Confirmation");
            }
            else
            {
                MessageBox.Show("The Customer is not found!", "Invalid CustomerID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            string cusId = textBoxCusId.Text.Trim();
            if (!(Validator.IsValidId(cusId)))
            {
                MessageBox.Show("Customer ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCusId.Clear();
                textBoxCusId.Focus();
                return;
            }
            int searchbyid = Convert.ToInt32(textBoxCusId.Text.Trim());
            DataRow searchcustomer = dtCustomer.Rows.Find(searchbyid);
            if (searchcustomer != null)
            {
                DataRow delcustomer = dtCustomer.Rows.Find(searchbyid);
                DialogResult delete = MessageBox.Show("Do you want to DELETE this customer?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (delete == DialogResult.Yes)
                {
                    delcustomer.Delete();
                    MessageBox.Show("The customer has been deleted sucessfully.", "Confirmation");
                    textBoxCusId.Clear();
                    textBoxCustomerName.Clear();
                    textBoxStreetName.Clear();
                    textBoxProvince.Clear();
                    textBoxCity.Clear();
                    textBoxPostcode.Clear();
                }
                else
                {
                    return;
                }
                
                
            }
            else
            {
                MessageBox.Show("The Customer is not found!", "Invalid CustomerID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearchCus_Click(object sender, EventArgs e)
        {
            string cusId = textBoxsearchid.Text.Trim();
            if (!(Validator.IsValidId(cusId)))
            {
                MessageBox.Show("Customer ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxsearchid.Clear();
                textBoxsearchid.Focus();
                return;
            }
            int searchbyid = Convert.ToInt32(textBoxsearchid.Text.Trim());
            DataRow searchcustomer = dtCustomer.Rows.Find(searchbyid);
            if (searchcustomer != null)
            {
                textBoxsearchname.Text = searchcustomer["CustomerName"].ToString();
                textBoxsearchprovince.Text = searchcustomer["Province"].ToString();
                textBoxsearchcity.Text = searchcustomer["City"].ToString();
                textBoxsearchpostalcode.Text = searchcustomer["PostalCode"].ToString();
                textBoxsearchstreet.Text = searchcustomer["StreetName"].ToString();
            }
            else
            {
                MessageBox.Show("The Customer is not found!", "Invalid CustomerID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
    
}
