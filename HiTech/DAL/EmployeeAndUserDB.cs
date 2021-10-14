using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTech.BLL;
using System.Data.SqlClient;

namespace HiTech.DAL
{
    public static class Employee_and_UserDB
    {
        public static void SaveEmployee(Employee_and_User emp)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.CommandText = "INSERT INTO Employees(EmployeeId,FirstName,LastName,PhoneNumber,Email,JobId) " +
                                    " VALUES (@EmployeeId,@FirstName,@LastName,@PhoneNumber,@Email,@JobId)";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            cmdInsert.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdInsert.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
            cmdInsert.Parameters.AddWithValue("@Email", emp.Email);
            cmdInsert.Parameters.AddWithValue("@JobId", emp.JobId);
            cmdInsert.Connection = conn;
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        public static Employee_and_User SearchEmployee(int Id)
        {
            Employee_and_User emp = new Employee_and_User();
            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Employees " +
                                    "WHERE EmployeeId = @EmployeeId";
            cmdSelect.Parameters.AddWithValue("@EmployeeId", Id);
            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            if (sqlReader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.PhoneNumber = sqlReader["PhoneNumber"].ToString();
                emp.Email = sqlReader["Email"].ToString();
                emp.JobId = Convert.ToInt32(sqlReader["JobId"]);
            }
            else
            {
                emp = null;
            }

            return emp;
        }
        public static List<Employee_and_User> ListEmployees()
        {
            List<Employee_and_User> listEmp = new List<Employee_and_User>();
            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Employees ";
            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee_and_User emp;

            while (sqlReader.Read())
            {
                emp = new Employee_and_User();
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName  = sqlReader["LastName"].ToString();
                emp.PhoneNumber = sqlReader["PhoneNumber"].ToString();
                emp.Email  = sqlReader["Email"].ToString();
                emp.JobId = Convert.ToInt32(sqlReader["JobId"]);
                listEmp.Add(emp);
            }
            return listEmp;
        }
        
        public static List<Employee_and_User> listJobs()
        {
            List<Employee_and_User> listjob = new List<Employee_and_User>();
            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Job ";
            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee_and_User emp;

            while (sqlReader.Read())
            {
                emp = new Employee_and_User();
                emp.JobId = Convert.ToInt32(sqlReader["JobId"]);
                emp.JobTitle = sqlReader["JobTitle"].ToString();
                listjob.Add(emp);
            }
            return listjob;
        }
        public static List<Employee_and_User> listUsers()
        {
            List<Employee_and_User> listUser = new List<Employee_and_User>();
            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Users ";
            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee_and_User user;

            while (sqlReader.Read())
            {
                user = new Employee_and_User();
                user.UserId = Convert.ToInt32(sqlReader["UserId"]);
                user.Password = sqlReader["Password"].ToString();
                user.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                listUser.Add(user);
            }
            return listUser;
        }
        public static void SaveUsers(Employee_and_User user)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.CommandText = "INSERT INTO Users(UserId,Password,EmployeeId) " +
                                    " VALUES (@UserId,@Password,@EmployeeId)";
            cmdInsert.Parameters.AddWithValue("@UserId", user.UserId);
            cmdInsert.Parameters.AddWithValue("@Password", user.Password);
            cmdInsert.Parameters.AddWithValue("@EmployeeId", user.EmployeeId);
            cmdInsert.Connection = conn;
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        public static Employee_and_User SearchUser(int Id)
        {
            Employee_and_User user = new Employee_and_User();
            SqlConnection conn = UtilityDB.ConnectDB();
            conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Users " +
                                    "WHERE UserId = @UserId";
            cmdSelect.Parameters.AddWithValue("@UserId", Id);
            cmdSelect.Connection = conn;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            if (sqlReader.Read())
            {
                user.UserId = Convert.ToInt32(sqlReader["UserId"]);
                user.Password = sqlReader["Password"].ToString();
                user.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
            }
            else
            {
                user = null;
            }

            return user;
        }
        public static void UpdateEmployee(Employee_and_User emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdUpate = new SqlCommand();
            cmdUpate.CommandText = "UPDATE Employees " +
                                    "SET    EmployeeId = @EmployeeId," +
                                    "       FirstName = @FirstName," +
                                    "       LastName = @LastName," +
                                    "       PhoneNumber = @PhoneNumber," +
                                    "       Email = @Email," +
                                    "       JobId = @JobId " +
                                    "WHERE  EmployeeId = @EmployeeId";
            cmdUpate.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            cmdUpate.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdUpate.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdUpate.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
            cmdUpate.Parameters.AddWithValue("@Email", emp.Email);
            cmdUpate.Parameters.AddWithValue("@JobId", emp.JobId);
            cmdUpate.Connection = connDB;
            cmdUpate.ExecuteNonQuery();
            connDB.Close();
        }
        public static void UpdateUser(Employee_and_User user)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdUpate1 = new SqlCommand();
            cmdUpate1.CommandText = "UPDATE Users " +
                                    "SET    UserId = @UserId," +
                                    "       Password = @Password," +
                                    "       EmployeeId = @EmployeeId" +
                                    "WHERE  UserId = @UserId";
            cmdUpate1.Parameters.AddWithValue("@UserId", user.UserId);
            cmdUpate1.Parameters.AddWithValue("@Password", user.Password);
            cmdUpate1.Parameters.AddWithValue("@EmployeeId", user.EmployeeId);
            cmdUpate1.Connection = connDB;
            cmdUpate1.ExecuteNonQuery();
            connDB.Close();
        }
        public static void DeleteUser(int userId)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.CommandText = "DELETE FROM Users " +
                                    "WHERE UserId= @UserId";
            cmdDelete.Parameters.AddWithValue("@UserId", userId);
            cmdDelete.Connection = conn;
            cmdDelete.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteEmployee(int empId)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.CommandText = "DELETE FROM Employees " +
                                    "WHERE EmployeeId= @EmployeeId";
            cmdDelete.Parameters.AddWithValue("@EmployeeId", empId);
            cmdDelete.Connection = conn;
            cmdDelete.ExecuteNonQuery();
            conn.Close();
        }
    }
}
