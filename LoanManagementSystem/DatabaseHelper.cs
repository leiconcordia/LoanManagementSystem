using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoanManagementSystem
{
    public class DatabaseHelper
    {

        //Query for table Users

    //CREATE TABLE Users (
    //    UserID INT PRIMARY KEY IDENTITY(1,1),
    //FirstName NVARCHAR(50) NOT NULL,
    //LastName NVARCHAR(50) NOT NULL,
    //PhoneNumber NVARCHAR(20),
    //Address NVARCHAR(100),
    //DateOfBirth DATE,
    //EmploymentStatus NVARCHAR(50),
    //MonthlyIncome DECIMAL(10, 2),
    //Username NVARCHAR(50) NOT NULL UNIQUE,
    //PasswordHash NVARCHAR(128) NOT NULL,
    //Status NVARCHAR(20) NOT NULL DEFAULT 'Pending'
//);






        // Replace with your actual SQL Server connection string
        private readonly string connectionString = "Server=STATION48;Database=DB_LMS;Trusted_Connection=True;";

        // Method to get SQL Connection
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Method to execute INSERT, UPDATE, DELETE queries
        public bool ExecuteQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Method to check if a value exists in a table (e.g., check if phone number already exists)
        public bool ValueExists(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        object result = cmd.ExecuteScalar();
                        return result != null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            // SQL query to select users
            string query = "SELECT Userid, Firstname, LastName, Status FROM Users"; // Adjust the query as needed

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
            
                    User user = new User
                    {
                        UserId = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Status = reader.GetString(3)
                    };
                    users.Add(user);
                }
            }

            return users;
        }
    }

    // User class to represent the user object
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }
    }
}
