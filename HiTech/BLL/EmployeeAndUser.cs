using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTech.DAL;

namespace HiTech.BLL
{
    public class Employee_and_User
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;
        private int jobId;
        private string jobTitle;
        private int userId;
        private string password;

        public int EmployeeId { get => employeeId; set => employeeId = value; }

        public int JobId { get => jobId; set => jobId = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public int UserId { get => userId; set => userId = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }

        public void SaveEmployee(Employee_and_User emp)
        {
            Employee_and_UserDB.SaveEmployee(emp);
        }
        public Employee_and_User SearchEmployee(int empId)
        {

            return Employee_and_UserDB.SearchEmployee(empId);
        }
        public void UpdateEmployee(Employee_and_User emp)
        {
            Employee_and_UserDB.UpdateEmployee(emp);
        }
        public List<Employee_and_User> ListEmployees()
        {
            return Employee_and_UserDB.ListEmployees();
        }
        public void DeleteUser(int userId)
        {
            Employee_and_UserDB.DeleteUser(userId);
        }
        public void DeleteEmployee(int empId)
        {
            Employee_and_UserDB.DeleteEmployee(empId);
        }
        public List<Employee_and_User> listJobs()
        {
            return Employee_and_UserDB.listJobs();
        }
        public List<Employee_and_User> listUsers()
        {
            return Employee_and_UserDB.listUsers();
        }
        public void SaveUsers(Employee_and_User user)
        {
            Employee_and_UserDB.SaveUsers(user);
        }
        public Employee_and_User SearchUser(int empId)
        {

            return Employee_and_UserDB.SearchUser(empId);
        }
        public void UpdateUser(Employee_and_User user)
        {
            Employee_and_UserDB.UpdateUser(user);
        }

    }
}
