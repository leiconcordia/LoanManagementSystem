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
        private readonly string connectionString = "Server=DESKTOP-0TPQ7D6\\SQLEXPRESS01;Database=DB_KASALIGAN_LOAN_SYSTEM;Trusted_Connection=True;";

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

            string query = @"   SELECT UserId, FirstName, LastName, PhoneNumber, Address, DateOfBirth, EmploymentStatus, MonthlyIncome, Username, Status
    FROM Users"; // Add all columns

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        UserId = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        PhoneNumber = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                        DateOfBirth = reader.IsDBNull(5) || !(reader[5] is DateTime) ? (DateTime?)null : reader.GetDateTime(5),
                        EmploymentStatus = reader.IsDBNull(6) ? null : reader.GetString(6),
                        MonthlyIncome = reader.IsDBNull(7) ? (decimal?)null : reader.GetDecimal(7),
                        Username = reader.GetString(8),
                        Status = reader.GetString(9)  // Fixed index from 19 to 9
                    });
                }
            }
            return users;
        }

        // User class to represent the user object
        public class User
        {
            public int UserId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public DateTime? DateOfBirth { get; set; }
            public string EmploymentStatus { get; set; }
            public decimal? MonthlyIncome { get; set; }
            public string Username { get; set; }
            public string Status { get; set; }

        }
    }
}
