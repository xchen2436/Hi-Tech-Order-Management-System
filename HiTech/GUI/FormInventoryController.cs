using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTech.BLL;
using HiTech.DAL;
using System.Data.SqlClient;
using HiTech.VALIDATION;
using System.Configuration;


namespace HiTech.GUI
{
    public partial class FormInventoryController : Form
    {
        SqlDataAdapter da1,da2,da3,da4;
        DataSet dsBook,dsAuthor,dsCategory,dsPublisher;
        DataTable dtBook,dtAuthor,dtCategory,dtPublisher;
        SqlCommandBuilder sqlBuilder;
        Books book = new Books();
        Author author = new Author();
        Category category = new Category();
        Publisher publisher = new Publisher();
        public FormInventoryController()
        {
            InitializeComponent();
        }
        private void buttonUpdateDB_Click(object sender, EventArgs e)
        {
            da1.Update(dsBook.Tables["Books"]);
            MessageBox.Show("Database has been updated sucessfully.", "Confirmation");
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            string bookid = textBoxISBN.Text.Trim();
            if ((Validator.IsEmpty(bookid)))
            {
                MessageBox.Show("ISBN is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxISBN.Clear();
                textBoxISBN.Focus();
                return;
            }
            long searchbyisbn = Convert.ToInt64(textBoxISBN.Text.Trim());
            DataRow searchbook = dtBook.Rows.Find(searchbyisbn);
            if (searchbook != null)
            {
                MessageBox.Show("This ISBN already exists!", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string booktitile = textBoxBookTitle.Text.Trim();
            if ((Validator.IsEmpty(booktitile)))
            {
                MessageBox.Show("Book title is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookTitle.Clear();
                textBoxBookTitle.Focus();
                return;
            }
            string qoh = textBoxQOH.Text.Trim();
            if ((Validator.IsEmpty(qoh)))
            {
                MessageBox.Show("QOH is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxQOH.Clear();
                textBoxQOH.Focus();
                return;
            }
            string price = textBoxPrice.Text.Trim();
            if ((Validator.IsEmpty(price)))
            {
                MessageBox.Show("Price is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPrice.Clear();
                textBoxPrice.Focus();
                return;
            }
            string year = textBoxYearPublished.Text.Trim();
            if ((Validator.IsEmpty(year)))
            {
                MessageBox.Show("Year published is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYearPublished.Clear();
                textBoxYearPublished.Focus();
                return;
            }
            string edition = textBoxEdition.Text.Trim();
            if ((Validator.IsEmpty(edition)))
            {
                MessageBox.Show("Edition is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEdition.Clear();
                textBoxEdition.Focus();
                return;
            }
            DataRow addbook = dtBook.NewRow();
            addbook["ISBN"] = Convert.ToInt64(textBoxISBN.Text.Trim());
            addbook["BookTitle"] = textBoxBookTitle.Text.Trim();
            addbook["QOH"] = Convert.ToInt32(textBoxQOH.Text.Trim());
            addbook["Price"] = Convert.ToDouble(textBoxPrice.Text.Trim());
            addbook["AuthorId"] = Convert.ToInt32(comboBoxAuthor.Text.Trim());
            addbook["PublisherId"] = Convert.ToInt32(comboBoxCategory.Text.Trim());
            addbook["CategoryId"] = Convert.ToInt32(comboBoxPublisher.Text.Trim());
            addbook["YearPublished"] = textBoxYearPublished.Text.Trim();
            addbook["Edition"] = textBoxEdition.Text.Trim();
            dtBook.Rows.Add(addbook);
            MessageBox.Show("The Book has been added sucessfully.", "Confirmation");
            textBoxISBN.Clear();
            textBoxBookTitle.Clear();
            textBoxQOH.Clear();
            textBoxPrice.Clear();
            textBoxYearPublished.Clear();
            textBoxEdition.Clear();
            textBoxa.Clear();
            textBoxp.Clear();
            textBoxc.Clear();
            comboBoxAuthor.Text = "";
            comboBoxCategory.Text = "";
            comboBoxPublisher.Text = "";
        }
        private void buttonBackLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
        }

        private void buttonListBook_Click(object sender, EventArgs e)
        {
            Books abook = new Books();
            dataGridViewbook.DataSource = abook.ListBook();
        }

        private void FormInventoryController_Load(object sender, EventArgs e)
        {
            string authorconn = ConfigurationManager.ConnectionStrings["HiTechDBConnection"].ConnectionString;
            SqlConnection sqlauthorconn = new SqlConnection(authorconn);
            string sqlauthorquery = "Select * from Authors";
            SqlCommand sqlauthorcomm = new SqlCommand(sqlauthorquery, sqlauthorconn);
            sqlauthorconn.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlauthorcomm);
            DataTable dtauthor = new DataTable();
            sdr.Fill(dtauthor);
            comboBoxAuthor.DisplayMember = "AuthorId";
            comboBoxAuthor.DataSource = dtauthor;
            sqlauthorconn.Close();

            string maincateconn = ConfigurationManager.ConnectionStrings["HiTechDBConnection"].ConnectionString;
            SqlConnection sqlcateconn = new SqlConnection(maincateconn);
            string sqlcatequery = "Select * from Categories";
            SqlCommand sqlcatecomm = new SqlCommand(sqlcatequery, sqlcateconn);
            sqlcateconn.Open();
            SqlDataAdapter catesdr = new SqlDataAdapter(sqlcatecomm);
            DataTable dtcate = new DataTable();
            catesdr.Fill(dtcate);
            comboBoxCategory.DisplayMember = "CategoryId";
            comboBoxCategory.DataSource = dtcate;
            sqlcateconn.Close();

            string mainpubconn = ConfigurationManager.ConnectionStrings["HiTechDBConnection"].ConnectionString;
            SqlConnection sqlpubconn = new SqlConnection(mainpubconn);
            string sqlpubquery = "Select * from Publishers";
            SqlCommand sqlpubcomm = new SqlCommand(sqlpubquery, sqlpubconn);
            sqlcateconn.Open();
            SqlDataAdapter pubsdr = new SqlDataAdapter(sqlpubcomm);
            DataTable dtpub = new DataTable();
            pubsdr.Fill(dtpub);
            comboBoxPublisher.DisplayMember = "PublisherId";
            comboBoxPublisher.DataSource = dtpub;
            sqlpubconn.Close();

            this.MinimumSize = new Size(1000, 800);
            this.MaximumSize = new Size(1000, 800);
            dsBook = new DataSet("BookDB");
            dtBook = new DataTable("Books");
            dsBook.Tables.Add(dtBook);
            dtBook.Columns.Add("ISBN", typeof(Int64));
            dtBook.Columns.Add("BookTitle", typeof(string));
            dtBook.Columns.Add("QOH", typeof(Int32));
            dtBook.Columns.Add("Price", typeof(double));
            dtBook.Columns.Add("AuthorId", typeof(Int32));
            dtBook.Columns.Add("PublisherId", typeof(Int32));
            dtBook.Columns.Add("CategoryId", typeof(Int32));
            dtBook.Columns.Add("YearPublished", typeof(string));
            dtBook.Columns.Add("Edition", typeof(string));
            dtBook.PrimaryKey = new DataColumn[] { dtBook.Columns["ISBN"] };
            da1 = new SqlDataAdapter("SELECT * FROM Books", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da1);
            da1.Fill(dsBook.Tables["Books"]);

            dsAuthor = new DataSet("AuthorDB");
            dtAuthor = new DataTable("Authors");
            dsAuthor.Tables.Add(dtAuthor);
            dtAuthor.Columns.Add("AuthorId", typeof(Int32));
            dtAuthor.Columns.Add("AuthorName", typeof(string));
            dtAuthor.PrimaryKey = new DataColumn[] { dtAuthor.Columns["AuthorId"] };
            da2 = new SqlDataAdapter("SELECT * FROM Authors", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da2);
            da2.Fill(dsAuthor.Tables["Authors"]);

            dsCategory = new DataSet("CategoryDB");
            dtCategory = new DataTable("Categories");
            dsCategory.Tables.Add(dtCategory);
            dtCategory.Columns.Add("CategoryId", typeof(Int32));
            dtCategory.Columns.Add("CategoryName", typeof(string));
            dtCategory.PrimaryKey = new DataColumn[] { dtCategory.Columns["CategoryId"] };
            da3 = new SqlDataAdapter("SELECT * FROM Categories", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da3);
            da3.Fill(dsCategory.Tables["Categories"]);

            dsPublisher = new DataSet("PublisherDB");
            dtPublisher = new DataTable("Publishers");
            dsPublisher.Tables.Add(dtPublisher);
            dtPublisher.Columns.Add("PublisherId", typeof(Int32));
            dtPublisher.Columns.Add("PublisherName", typeof(string));
            dtPublisher.PrimaryKey = new DataColumn[] { dtPublisher.Columns["PublisherId"] };
            da4 = new SqlDataAdapter("SELECT * FROM Publishers", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da4);
            da4.Fill(dsPublisher.Tables["Publishers"]);
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            string bookid = textBoxISBN.Text.Trim();
            if ((Validator.IsEmpty(bookid)))
            {
                MessageBox.Show("ISBN is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxISBN.Clear();
                textBoxISBN.Focus();
                return;
            }
            string booktitile = textBoxBookTitle.Text.Trim();
            if ((Validator.IsEmpty(booktitile)))
            {
                MessageBox.Show("Book title is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookTitle.Clear();
                textBoxBookTitle.Focus();
                return;
            }
            string qoh = textBoxQOH.Text.Trim();
            if ((Validator.IsEmpty(qoh)))
            {
                MessageBox.Show("QOH is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxQOH.Clear();
                textBoxQOH.Focus();
                return;
            }
            string price = textBoxPrice.Text.Trim();
            if ((Validator.IsEmpty(price)))
            {
                MessageBox.Show("Price is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPrice.Clear();
                textBoxPrice.Focus();
                return;
            }
            string year = textBoxYearPublished.Text.Trim();
            if ((Validator.IsEmpty(year)))
            {
                MessageBox.Show("Year published is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYearPublished.Clear();
                textBoxYearPublished.Focus();
                return;
            }
            string edition = textBoxEdition.Text.Trim();
            if ((Validator.IsEmpty(edition)))
            {
                MessageBox.Show("Edition is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEdition.Clear();
                textBoxEdition.Focus();
                return;
            }
            long searchbyisbn = Convert.ToInt64(textBoxISBN.Text.Trim());
            DataRow searchbook = dtBook.Rows.Find(searchbyisbn);
            if (searchbook != null)
            {
                DataRow updatebook = dtBook.Rows.Find(searchbyisbn);
                updatebook["ISBN"] = Convert.ToInt64(textBoxISBN.Text.Trim());
                updatebook["BookTitle"] = textBoxBookTitle.Text.Trim();
                updatebook["QOH"] = Convert.ToInt32(textBoxQOH.Text.Trim());
                updatebook["Price"] = Convert.ToDouble(textBoxPrice.Text.Trim());
                updatebook["AuthorId"] = Convert.ToInt32(comboBoxAuthor.Text.Trim());
                updatebook["PublisherId"] = Convert.ToInt32(comboBoxPublisher.Text.Trim());
                updatebook["CategoryId"] = Convert.ToInt32(comboBoxCategory.Text.Trim());
                updatebook["YearPublished"] = textBoxYearPublished.Text.Trim();
                updatebook["Edition"] = textBoxEdition.Text.Trim();
                MessageBox.Show("The Book has been updated sucessfully.", "Confirmation");
                textBoxISBN.Clear();
                textBoxBookTitle.Clear();
                textBoxQOH.Clear();
                textBoxPrice.Clear();
                textBoxYearPublished.Clear();
                textBoxEdition.Clear();
                textBoxa.Clear();
                textBoxp.Clear();
                textBoxc.Clear();
            }
            else
            {
                MessageBox.Show("The Book is not found!", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Author aauthor = new Author();
            dataGridViewAuthor.DataSource = aauthor.ListAuthor();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            string aid = textBoxAID.Text.Trim();
            if ((Validator.IsEmpty(aid)))
            {
                MessageBox.Show("Author ID is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAID.Clear();
                textBoxAID.Focus();
                return;
            }
            int searchbyauthorid = Convert.ToInt32(textBoxAID.Text.Trim());
            DataRow searchauthor = dtAuthor.Rows.Find(searchbyauthorid);
            if (searchauthor != null)
            {
                MessageBox.Show("This author ID already exists!", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAID.Clear();
                textBoxAID.Focus();
            }
            
            string aname = textBoxAuthorName.Text.Trim();
            if ((Validator.IsEmpty(aname)))
            {
                MessageBox.Show("Author name is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAuthorName.Clear();
                textBoxAuthorName.Focus();
                return;
            }
            DataRow addauthor = dtAuthor.NewRow();
            addauthor["AuthorId"] = Convert.ToInt32(textBoxAID.Text.Trim());
            addauthor["AuthorName"] = textBoxAuthorName.Text.Trim();
            dtAuthor.Rows.Add(addauthor);
            MessageBox.Show("The Author has been added sucessfully.", "Confirmation");
            textBoxAID.Clear();
            textBoxAuthorName.Clear();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            string aid = textBoxAID.Text.Trim();
            if ((Validator.IsEmpty(aid)))
            {
                MessageBox.Show("Author ID is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAID.Clear();
                textBoxAID.Focus();
                return;
            }
            string aname = textBoxAuthorName.Text.Trim();
            if ((Validator.IsEmpty(aname)))
            {
                MessageBox.Show("Author name is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAuthorName.Clear();
                textBoxAuthorName.Focus();
                return;
            }
            int searchbyauthorid = Convert.ToInt32(textBoxAID.Text.Trim());
            DataRow searchauthor = dtAuthor.Rows.Find(searchbyauthorid);
            if (searchauthor != null)
            {
                DataRow updateauthor = dtAuthor.Rows.Find(searchbyauthorid);
                updateauthor["AuthorId"] = Convert.ToInt32(textBoxAID.Text.Trim());
                updateauthor["AuthorName"] = textBoxAuthorName.Text.Trim();
                MessageBox.Show("The Book has been updated sucessfully.", "Confirmation");
                textBoxAID.Clear();
                textBoxAuthorName.Clear();
            }
            else
            {
                MessageBox.Show("The Author is not found!", "Invalid Author ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void button15_Click(object sender, EventArgs e)
        {
            da3.Update(dsCategory.Tables["Categories"]);
            MessageBox.Show("Database has been updated sucessfully.", "Confirmation");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            string cid = textBoxCID.Text.Trim();
            if ((Validator.IsEmpty(cid)))
            {
                MessageBox.Show("Category ID is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCID.Clear();
                textBoxCID.Focus();
                return;
            }
            int searchbycateid = Convert.ToInt32(textBoxCID.Text.Trim());
            DataRow searchcate = dtCategory.Rows.Find(searchbycateid);
            if (searchcate != null)
            {
                MessageBox.Show("This Category ID already exists!", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCID.Clear();
                textBoxCID.Focus();
                return;
            }
            string cname = textBoxCname.Text.Trim();
            if ((Validator.IsEmpty(cname)))
            {
                MessageBox.Show("Category name is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCname.Clear();
                textBoxCname.Focus();
                return;
            }
            DataRow addcate = dtCategory.NewRow();
            addcate["CategoryId"] = Convert.ToInt32(textBoxCID.Text.Trim());
            addcate["CategoryName"] = textBoxCname.Text.Trim();
            dtCategory.Rows.Add(addcate);
            MessageBox.Show("The Category has been added sucessfully.", "Confirmation");
            textBoxCID.Clear();
            textBoxCname.Clear();
        }

        private void buttonlistPublisher_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher();
            dataGridViewPublisher.DataSource = publisher.ListPublisher();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            da4.Update(dsPublisher.Tables["Publishers"]);
            MessageBox.Show("Database has been updated sucessfully.", "Confirmation");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher();
            string pid = textBoxPID.Text.Trim();
            if ((Validator.IsEmpty(pid)))
            {
                MessageBox.Show("Publisher ID is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPID.Clear();
                textBoxPID.Focus();
                return;
            }
            int searchbypubid = Convert.ToInt32(textBoxPID.Text.Trim());
            DataRow searchpub = dtPublisher.Rows.Find(searchbypubid);
            if (searchpub != null)
            {
                MessageBox.Show("This Publisher ID already exists!", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPID.Clear();
                textBoxPID.Focus();
                return;
            }
            string pname = textBoxPName.Text.Trim();
            if ((Validator.IsEmpty(pname)))
            {
                MessageBox.Show("Publisher name is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPName.Clear();
                textBoxPName.Focus();
                return;
            }
            DataRow addpublisher = dtPublisher.NewRow();
            addpublisher["PublisherId"] = Convert.ToInt32(textBoxPID.Text.Trim());
            addpublisher["PublisherName"] = textBoxPName.Text.Trim();
            dtPublisher.Rows.Add(addpublisher);
            MessageBox.Show("The publisher has been added sucessfully.", "Confirmation");
            textBoxPID.Clear();
            textBoxPName.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher();
            string pid = textBoxPID.Text.Trim();
            if ((Validator.IsEmpty(pid)))
            {
                MessageBox.Show("Publisher ID is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPID.Clear();
                textBoxPID.Focus();
                return;
            }
            string pname = textBoxPName.Text.Trim();
            if ((Validator.IsEmpty(pname)))
            {
                MessageBox.Show("Publisher name is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPName.Clear();
                textBoxPName.Focus();
                return;
            }
            int searchbypubid = Convert.ToInt32(textBoxPID.Text.Trim());
            DataRow searchpub = dtPublisher.Rows.Find(searchbypubid);
            if (searchpub != null)
            {
                DataRow updatepub = dtPublisher.Rows.Find(searchbypubid);
                updatepub["PublisherId"] = Convert.ToInt32(textBoxPID.Text.Trim());
                updatepub["PublisherName"] = textBoxPName.Text.Trim();
                MessageBox.Show("The Publisher has been updated sucessfully.", "Confirmation");
                textBoxPID.Clear();
                textBoxPName.Clear();
            }
            else
            {
                MessageBox.Show("The Publisher is not found!", "Invalid Publisher ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher();
            string pid = textBoxPID.Text.Trim();
            if ((Validator.IsEmpty(pid)))
            {
                MessageBox.Show("Publisher ID is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPID.Clear();
                textBoxPID.Focus();
                return;
            }
            int searchbypubid = Convert.ToInt32(textBoxPID.Text.Trim());
            DataRow searchpub = dtPublisher.Rows.Find(searchbypubid);
            if (searchpub != null)
            {
                DataRow delpub = dtPublisher.Rows.Find(searchbypubid);
                DialogResult delete = MessageBox.Show("Do you want to DELETE this Publisher?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (delete == DialogResult.Yes)
                {
                    delpub.Delete();
                    MessageBox.Show("The Publisher has been deleted sucessfully.", "Confirmation");
                }
                else
                {
                    return;
                }
                comboBoxPublisher.Items.Remove(textBoxPName.Text);
                textBoxPID.Clear();
                textBoxPName.Clear();
            }
            else
            {
                MessageBox.Show("The Publisher is not found!", "Invalid Publisher ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher();
            string pid = textBoxPID.Text.Trim();
            if ((Validator.IsEmpty(pid)))
            {
                MessageBox.Show("Publisher ID is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPID.Clear();
                textBoxPID.Focus();
                return;
            }
            int searchbypubid = Convert.ToInt32(textBoxPID.Text.Trim());
            DataRow searchpub = dtPublisher.Rows.Find(searchbypubid);
            if (searchpub != null)
            {
                textBoxPID.Text = searchpub["PublisherId"].ToString();
                textBoxPName.Text = searchpub["PublisherName"].ToString();
            }
            else
            {
                MessageBox.Show("The Publisher is not found!", "Invalid Publisher ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxCategory.ValueMember);
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            int comaid = Convert.ToInt32(comboBoxAuthor.Text.Trim());
            DataRow searchcomaid = dtAuthor.Rows.Find(comaid);
            if (searchcomaid != null)
            {
                textBoxa.Text = searchcomaid["AuthorName"].ToString();
            }
            int compid = Convert.ToInt32(comboBoxPublisher.Text.Trim());
            DataRow searchcompid = dtPublisher.Rows.Find(compid);
            if (searchcompid != null)
            {
                textBoxp.Text = searchcompid["PublisherName"].ToString();
            }
            int comcid = Convert.ToInt32(comboBoxCategory.Text.Trim());
            DataRow searchcid = dtCategory.Rows.Find(comcid);
            if (searchcompid != null)
            {
                textBoxc.Text = searchcid["CategoryName"].ToString();
            }

        }

        private void Buttonrefresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventoryController formInventoryController = new FormInventoryController();
            formInventoryController.ShowDialog();
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            textBoxISBN.Clear();
            textBoxBookTitle.Clear();
            textBoxQOH.Clear();
            textBoxPrice.Clear();
            comboBoxAuthor.Text = "";
            comboBoxCategory.Text = "";
            comboBoxPublisher.Text = "";
            textBoxYearPublished.Clear();
            textBoxEdition.Clear();
            textBoxa.Clear();
            textBoxp.Clear();
            textBoxc.Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            string cid = textBoxCID.Text.Trim();
            if ((Validator.IsEmpty(cid)))
            {
                MessageBox.Show("Category ID is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCID.Clear();
                textBoxCID.Focus();
                return;
            }
            string cname = textBoxCname.Text.Trim();
            if ((Validator.IsEmpty(cname)))
            {
                MessageBox.Show("Category name is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCname.Clear();
                textBoxCname.Focus();
                return;
            }
            int searchbycateid = Convert.ToInt32(textBoxCID.Text.Trim());
            DataRow searchcate = dtCategory.Rows.Find(searchbycateid);
            if (searchcate != null)
            {
                DataRow updatecate = dtCategory.Rows.Find(searchbycateid);
                updatecate["CategoryId"] = Convert.ToInt32(textBoxCID.Text.Trim());
                updatecate["CategoryName"] = textBoxCname.Text.Trim();
                MessageBox.Show("The Category has been updated sucessfully.", "Confirmation");
                textBoxCID.Clear();
                textBoxCname.Clear();
            }
            else
            {
                MessageBox.Show("The Category is not found!", "Invalid Category ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            string cid = textBoxCID.Text.Trim();
            if ((Validator.IsEmpty(cid)))
            {
                MessageBox.Show("Category ID is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCID.Clear();
                textBoxCID.Focus();
                return;
            }
            int searchbycateid = Convert.ToInt32(textBoxCID.Text.Trim());
            DataRow searchcate = dtCategory.Rows.Find(searchbycateid);
            if (searchcate != null)
            {
                DataRow delcate = dtCategory.Rows.Find(searchbycateid);
                DialogResult delete = MessageBox.Show("Do you want to DELETE this Category?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (delete == DialogResult.Yes)
                {
                    delcate.Delete();
                    MessageBox.Show("The Category has been deleted sucessfully.", "Confirmation");
                }
                else
                {
                    return;
                }

                comboBoxCategory.Items.Remove(textBoxCname.Text);
                textBoxCID.Clear();
                textBoxCname.Clear();
            }
            else
            {
                MessageBox.Show("The Category is not found!", "Invalid Category ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            string cid = textBoxCID.Text.Trim();
            if ((Validator.IsEmpty(cid)))
            {
                MessageBox.Show("Category ID is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCID.Clear();
                textBoxCID.Focus();
                return;
            }

            int searchbycateid = Convert.ToInt32(textBoxCID.Text.Trim());
            DataRow searchcate = dtCategory.Rows.Find(searchbycateid);
            if (searchcate != null)
            {
                textBoxCID.Text = searchcate["CategoryId"].ToString();
                textBoxCname.Text = searchcate["CategoryName"].ToString();
            }
            else
            {
                MessageBox.Show("The Category is not found!", "Invalid Category ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            string aid = textBoxAID.Text.Trim();
            if ((Validator.IsEmpty(aid)))
            {
                MessageBox.Show("Author ID is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAID.Clear();
                textBoxAID.Focus();
                return;
            }
            int searchbyauthorid = Convert.ToInt32(textBoxAID.Text.Trim());
            DataRow searchauthor = dtAuthor.Rows.Find(searchbyauthorid);
            if (searchauthor != null)
            {
                DataRow delauthor = dtAuthor.Rows.Find(searchbyauthorid);
                DialogResult delete = MessageBox.Show("Do you want to DELETE this Author?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (delete == DialogResult.Yes)
                {
                    delauthor.Delete();
                    MessageBox.Show("The Author has been deleted sucessfully.", "Confirmation");
                }
                else
                {
                    return;
                }
                comboBoxAuthor.Items.Remove(textBoxAuthorName.Text);
                textBoxAID.Clear();
                textBoxAuthorName.Clear();
            }
            else
            {
                MessageBox.Show("The Author is not found!", "Invalid Author ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            string aid = textBoxAID.Text.Trim();
            if ((Validator.IsEmpty(aid)))
            {
                MessageBox.Show("Author ID is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAID.Clear();
                textBoxAID.Focus();
                return;
            }
            int searchbyauthorid = Convert.ToInt32(textBoxAID.Text.Trim());
            DataRow searchauthor = dtAuthor.Rows.Find(searchbyauthorid);
            if (searchauthor != null)
            {
                textBoxAID.Text = searchauthor["AuthorId"].ToString();
                textBoxAuthorName.Text = searchauthor["AuthorName"].ToString();
            }
            else
            {
                MessageBox.Show("The Author is not found!", "Invalid Author ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonlistCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            dataGridViewCategory.DataSource = category.ListCategory();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            da2.Update(dsAuthor.Tables["Authors"]);
            MessageBox.Show("Database has been updated sucessfully.", "Confirmation");
        }
        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            string bookid = textBoxISBN.Text.Trim();
            if ((Validator.IsEmpty(bookid)))
            {
                MessageBox.Show("ISBN is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxISBN.Clear();
                textBoxISBN.Focus();
                return;
            }
            long searchbyisbn = Convert.ToInt64(textBoxISBN.Text.Trim());
            DataRow delbook = dtBook.Rows.Find(searchbyisbn);
            if (delbook != null)
            {
                delbook.Delete();
                MessageBox.Show("The book has been deleted sucessfully.", "Confirmation");

            }
            else
            {
                MessageBox.Show("The Book is not found!", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonSearchISBN_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            string bookid = textBoxISBN.Text.Trim();
            if ((Validator.IsEmpty(bookid)))
            {
                MessageBox.Show("ISBN is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxISBN.Clear();
                textBoxISBN.Focus();
                return;
            }
            long searchbyisbn = Convert.ToInt64(textBoxISBN.Text.Trim());
            DataRow searchbook = dtBook.Rows.Find(searchbyisbn);
            if (searchbook != null)
            {
                textBoxISBN.Text = searchbook["ISBN"].ToString();
                textBoxBookTitle.Text = searchbook["BookTitle"].ToString();
                textBoxEdition.Text = searchbook["Edition"].ToString();
                textBoxQOH.Text = searchbook["QOH"].ToString();
                textBoxPrice.Text = searchbook["Price"].ToString();
                textBoxYearPublished.Text = searchbook["YearPublished"].ToString();
                comboBoxAuthor.Text = searchbook["AuthorId"].ToString();
                comboBoxCategory.Text = searchbook["CategoryId"].ToString();
                comboBoxPublisher.Text = searchbook["PublisherId"].ToString();
                int comaid = Convert.ToInt32(comboBoxAuthor.Text.Trim());
                DataRow searchcomaid = dtAuthor.Rows.Find(comaid);
                if (searchcomaid != null)
                {
                    textBoxa.Text = searchcomaid["AuthorName"].ToString();
                }
                int compid = Convert.ToInt32(comboBoxPublisher.Text.Trim());
                DataRow searchcompid = dtPublisher.Rows.Find(compid);
                if (searchcompid != null)
                {
                    textBoxp.Text = searchcompid["PublisherName"].ToString();
                }
                int comcid = Convert.ToInt32(comboBoxCategory.Text.Trim());
                DataRow searchcid = dtCategory.Rows.Find(comcid);
                if (searchcompid != null)
                {
                    textBoxc.Text = searchcid["CategoryName"].ToString();
                }
            }
            else
            {
                MessageBox.Show("The Book is not found!", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
