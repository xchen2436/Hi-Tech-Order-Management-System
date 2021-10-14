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

namespace HiTech.GUI
{
    public partial class FormMISManager : Form
    {
        public FormMISManager()
        {
            InitializeComponent();
        }
        private void buttonEmpADD_Click(object sender, EventArgs e)
        {
            string empId = textBoxEmpId.Text.Trim();
            if (!(Validator.IsValidId(empId)))
            {
                MessageBox.Show("Employee ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpId.Clear();
                textBoxEmpId.Focus();
                return;
            }
            Employee_and_User emp0 = new Employee_and_User();
            emp0 = emp0.SearchEmployee(Convert.ToInt32(textBoxEmpId.Text.Trim()));
            if (emp0 != null)
            {
                MessageBox.Show("This Employee ID already exists!", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpId.Clear();
                textBoxEmpId.Focus();
                return;
            }
            string empFirstName = textBoxEmpFN.Text.Trim();
            if (!(Validator.IsValidName(empFirstName)))
            {
                MessageBox.Show("Invalid First Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpFN.Clear();
                textBoxEmpFN.Focus();
                return;
            }
            string empLastName = textBoxEmpLN.Text.Trim();
            if (!(Validator.IsValidName(empLastName)))
            {
                MessageBox.Show("Invalid Last Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpLN.Clear();
                textBoxEmpLN.Focus();
                return;
            }
            string empPhoneNumber = textBoxEmpPN.Text.Trim();
            if ((Validator.IsEmpty(empPhoneNumber)))
            {
                MessageBox.Show("Phone Number is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpPN.Clear();
                textBoxEmpPN.Focus();
                return;
            }
            string empEmail = textBoxEmpEmail.Text.Trim();
            if ((Validator.IsEmpty(empEmail)))
            {
                MessageBox.Show("Email is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpEmail.Clear();
                textBoxEmpEmail.Focus();
                return;
            }
            string empjobid = textBoxJobId.Text.Trim();
            if ((Validator.IsEmpty(empjobid)))
            {
                MessageBox.Show("JobId is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxJobId.Clear();
                textBoxJobId.Focus();
                return;
            }
            Employee_and_User emp = new Employee_and_User();
            emp.EmployeeId = Convert.ToInt32(textBoxEmpId.Text.Trim());
            emp.FirstName = textBoxEmpFN.Text.Trim();
            emp.LastName  = textBoxEmpLN.Text.Trim();
            emp.PhoneNumber = textBoxEmpPN.Text.Trim();
            emp.Email = textBoxEmpEmail.Text.Trim();
            emp.JobId = Convert.ToInt32(textBoxJobId.Text.Trim());
            emp.SaveEmployee(emp);
            MessageBox.Show("Employee data saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxEmpId.Clear();
            textBoxEmpFN.Clear();
            textBoxEmpLN.Clear();
            textBoxJobId.Clear();
            textBoxEmpPN.Clear();
            textBoxEmpEmail.Clear();
        }
        private void buttonEmpUpdate_Click(object sender, EventArgs e)
        {
            string empId = textBoxEmpId.Text.Trim();
            if (!(Validator.IsValidId(empId)))
            {
                MessageBox.Show("Employee ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpId.Clear();
                textBoxEmpId.Focus();
                return;
            }
            string empFirstName = textBoxEmpFN.Text.Trim();
            if (!(Validator.IsValidName(empFirstName)))
            {
                MessageBox.Show("Invalid First Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpFN.Clear();
                textBoxEmpFN.Focus();
                return;
            }
            string empLastName = textBoxEmpLN.Text.Trim();
            if (!(Validator.IsValidName(empLastName)))
            {
                MessageBox.Show("Invalid Last Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpLN.Clear();
                textBoxEmpLN.Focus();
                return;
            }
            string empPhoneNumber = textBoxEmpPN.Text.Trim();
            if ((Validator.IsEmpty(empPhoneNumber)))
            {
                MessageBox.Show("Phone Number is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpPN.Clear();
                textBoxEmpPN.Focus();
                return;
            }
            string empEmail = textBoxEmpEmail.Text.Trim();
            if ((Validator.IsEmpty(empEmail)))
            {
                MessageBox.Show("Email is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpEmail.Clear();
                textBoxEmpEmail.Focus();
                return;
            }
            string empjobid = textBoxJobId.Text.Trim();
            if ((Validator.IsEmpty(empjobid)))
            {
                MessageBox.Show("JobId is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxJobId.Clear();
                textBoxJobId.Focus();
                return;
            }
            Employee_and_User emp = new Employee_and_User();
            emp = emp.SearchEmployee(Convert.ToInt32(textBoxEmpId.Text.Trim()));
            if (emp != null)
            {
                emp.EmployeeId = Convert.ToInt32(textBoxEmpId.Text.Trim());
                emp.FirstName = textBoxEmpFN.Text.Trim();
                emp.LastName = textBoxEmpLN.Text.Trim();
                emp.PhoneNumber = textBoxEmpPN.Text.Trim();
                emp.Email = textBoxEmpEmail.Text.Trim();
                emp.JobId = Convert.ToInt32(textBoxJobId.Text.Trim());
                DialogResult answer = MessageBox.Show("Do you want to update this employee information? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (answer == DialogResult.Yes)
                {
                    emp.UpdateEmployee(emp);
                    MessageBox.Show("Employee data Updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxEmpId.Clear();
                    textBoxEmpFN.Clear();
                    textBoxEmpLN.Clear();
                    textBoxJobId.Clear();
                    textBoxEmpPN.Clear();
                    textBoxEmpEmail.Clear();
                }
            }
            else
            {
                MessageBox.Show("Employee not found!", "Error");
                textBoxSearchEmpId.Clear();
            }
            
        }
        private void buttonListEmployee_Click(object sender, EventArgs e)
        {
            Employee_and_User emp = new Employee_and_User();
            List<Employee_and_User> listEmp = emp.ListEmployees();
            listViewEmployee.Items.Clear();
            if (listEmp.Count != 0)
            {
                foreach (Employee_and_User anEmp in listEmp)
                {
                    ListViewItem item = new ListViewItem(anEmp.EmployeeId.ToString());
                    item.SubItems.Add(anEmp.FirstName);
                    item.SubItems.Add(anEmp.LastName);
                    item.SubItems.Add(anEmp.PhoneNumber);
                    item.SubItems.Add(anEmp.Email);
                    item.SubItems.Add(anEmp.JobId.ToString());
                    listViewEmployee.Items.Add(item);
                }
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string empId = textBoxEmpId.Text.Trim();
            if (!(Validator.IsValidId(empId)))
            {
                MessageBox.Show("Employee ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpId.Clear();
                textBoxEmpId.Focus();
                return;
            }
            Employee_and_User delemp = new Employee_and_User();

            delemp = delemp.SearchEmployee(Convert.ToInt32(textBoxEmpId.Text));
            if (delemp != null)
            {
                DialogResult delete = MessageBox.Show("Are You Sure You Want To Delete This Employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (delete == DialogResult.Yes)
                {
                    delemp.DeleteEmployee(Convert.ToInt32(textBoxEmpId.Text));
                    MessageBox.Show("Delete Successful!", "Successful", MessageBoxButtons.OK);
                    textBoxEmpId.Clear();
                    textBoxEmpFN.Clear();
                    textBoxEmpLN.Clear();
                    textBoxJobId.Clear();
                    textBoxEmpPN.Clear();
                    textBoxEmpEmail.Clear();
                }
                else
                {
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("This Employee does not exist", "Error", MessageBoxButtons.OK);
                textBoxEmpId.Text = "";
                textBoxEmpId.Focus();
                return;
            }

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
        }
        private void buttonListJob_Click(object sender, EventArgs e)
        {
            Employee_and_User emp = new Employee_and_User();
            List<Employee_and_User> listjobs = emp.listJobs();
            listViewJob.Items.Clear();
            if (listjobs.Count != 0)
            {
                foreach (Employee_and_User anEmp in listjobs)
                {
                    ListViewItem item = new ListViewItem(anEmp.JobId.ToString());
                    item.SubItems.Add(anEmp.JobTitle);
                    item.SubItems.Add(anEmp.LastName);
                    listViewJob.Items.Add(item);
                }
            }
        }
        private void buttonListAllUser_Click(object sender, EventArgs e)
        {
            Employee_and_User user = new Employee_and_User();
            List<Employee_and_User> listUser = user.listUsers();
            listViewUser.Items.Clear();
            if (listUser.Count != 0)
            {
                foreach (Employee_and_User anUser in listUser)
                {
                    ListViewItem item = new ListViewItem(anUser.UserId.ToString());
                    item.SubItems.Add(anUser.Password);
                    item.SubItems.Add(anUser.EmployeeId.ToString());
                    listViewUser.Items.Add(item);
                }
            }
        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string userid = textBoxUserId.Text.Trim();
            if (!(Validator.IsValidId(userid)))
            {
                MessageBox.Show("User ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserId.Clear();
                textBoxUserId.Focus();
                return;
            }
            Employee_and_User searchUserId = new Employee_and_User();
            searchUserId = searchUserId.SearchUser(Convert.ToInt32(textBoxUserId.Text.Trim()));
            if (searchUserId != null)
            {
                MessageBox.Show("This User ID already exists!", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserId.Clear();
                textBoxUserId.Focus();
                return;
            }
            string password = textBoxPassword.Text.Trim();
            if ((Validator.IsEmpty(password)))
            {
                MessageBox.Show("Password is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Clear();
                textBoxPassword.Focus();
                return;
            }
            string empid = textBoxEmpId_User.Text.Trim();
            if ((Validator.IsEmpty(empid)))
            {
                MessageBox.Show("EmployeeId is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpId_User.Clear();
                textBoxEmpId_User.Focus();
                return;
            }
            Employee_and_User searchEmpId = new Employee_and_User();
            Employee_and_User user = new Employee_and_User();
            user.UserId = Convert.ToInt32(textBoxUserId.Text.Trim());
            user.Password = textBoxPassword.Text.Trim();
            user.EmployeeId = Convert.ToInt32(textBoxEmpId_User.Text.Trim());
            user.SaveUsers(user);
            MessageBox.Show("User data saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxUserId.Clear();
            textBoxPassword.Clear();
            textBoxEmpId_User.Clear();
        }
        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            string userid = textBoxUserId.Text.Trim();
            if (!(Validator.IsValidId(userid)))
            {
                MessageBox.Show("User ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserId.Clear();
                textBoxUserId.Focus();
                return;
            }
            Employee_and_User searchUserId = new Employee_and_User();
            string password = textBoxPassword.Text.Trim();
            if ((Validator.IsEmpty(password)))
            {
                MessageBox.Show("Password is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Clear();
                textBoxPassword.Focus();
                return;
            }
            string empid = textBoxEmpId_User.Text.Trim();
            if ((Validator.IsEmpty(empid)))
            {
                MessageBox.Show("EmployeeId is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmpId_User.Clear();
                textBoxEmpId_User.Focus();
                return;
            }
            Employee_and_User user = new Employee_and_User();
            user.UserId = Convert.ToInt32(textBoxUserId.Text.Trim());
            user.Password = textBoxPassword.Text.Trim();
            user.EmployeeId = Convert.ToInt32(textBoxEmpId_User.Text.Trim());
            DialogResult answer = MessageBox.Show("Do you want to update this User information? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
            {
                user.UpdateEmployee(user);
                MessageBox.Show("Employee data Updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxUserId.Clear();
                textBoxPassword.Clear();
                textBoxEmpId_User.Clear();
            }
        }
        private void buttonSearchEmp_Click(object sender, EventArgs e)
        {
            string empId = textBoxSearchEmpId.Text.Trim();
            if (!(Validator.IsValidId(empId)))
            {
                MessageBox.Show("Employee ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSearchEmpId.Clear();
                textBoxSearchEmpId.Focus();
                return;
            }
            Employee_and_User emp = new Employee_and_User();
            emp = emp.SearchEmployee(Convert.ToInt32(textBoxSearchEmpId.Text.Trim()));
            if (emp != null)
            {
                List<Employee_and_User> listEmp = emp.ListEmployees();
                listViewEmployee.Items.Clear();
                if (listEmp.Count != 0)
                {
                        ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                        item.SubItems.Add(emp.FirstName);
                        item.SubItems.Add(emp.LastName);
                        item.SubItems.Add(emp.PhoneNumber);
                        item.SubItems.Add(emp.Email);
                        item.SubItems.Add(emp.JobId.ToString());
                        listViewEmployee.Items.Add(item);
                    }
                }
            else
            {
                MessageBox.Show("Employee not found!", "Error");
                textBoxSearchEmpId.Clear();
            }
        }
        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            string userid = textBoxSearchUserId.Text.Trim();
            if (!(Validator.IsValidId(userid)))
            {
                MessageBox.Show("User ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSearchUserId.Clear();
                textBoxSearchUserId.Focus();
                return;
            }
            Employee_and_User user = new Employee_and_User();
            user = user.SearchUser(Convert.ToInt32(textBoxSearchUserId.Text.Trim()));
            if (user != null)
            {
                List<Employee_and_User> listUser = user.listUsers();
                listViewUser.Items.Clear();
                if (listUser.Count != 0)
                {
                    ListViewItem item = new ListViewItem(user.UserId.ToString());
                    item.SubItems.Add(user.Password);
                    item.SubItems.Add(user.EmployeeId.ToString());
                    listViewUser.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("User not found!", "Error");
                textBoxSearchUserId.Clear();
            }
        }
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            string userid = textBoxUserId.Text.Trim();
            if (!(Validator.IsValidId(userid)))
            {
                MessageBox.Show("User ID must be 4-digit number", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserId.Clear();
                textBoxUserId.Focus();
                return;
            }
            Employee_and_User deluser = new Employee_and_User();
            deluser = deluser.SearchUser(Convert.ToInt32(textBoxUserId.Text));
            if (deluser != null)
            {
                DialogResult delete = MessageBox.Show("Are You Sure You Want To Delete This User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (delete == DialogResult.Yes)
                {
                    deluser.DeleteUser(Convert.ToInt32(textBoxUserId.Text));
                    MessageBox.Show("Delete Successful!", "Successful", MessageBoxButtons.OK);
                    textBoxUserId.Clear();
                    textBoxPassword.Clear();
                    textBoxEmpId_User.Clear();
                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("This Users does not exist", "Error", MessageBoxButtons.OK);
                textBoxUserId.Text = "";
                textBoxUserId.Focus();
                return;
            }
        }

        private void groupBoxEmp_Enter(object sender, EventArgs e)
        {

        }
    }
}
    

