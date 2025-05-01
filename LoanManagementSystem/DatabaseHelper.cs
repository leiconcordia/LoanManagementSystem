using LoanManagementSystem.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Principal;
using System.Windows.Forms;
using static LoanManagementSystem.DatabaseHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoanManagementSystem
{
    public class DatabaseHelper
    {

        //Query for table Users

        //CREATE TABLE Users (
        //UserID INT PRIMARY KEY IDENTITY(1,1),
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

        //ALTER TABLE Users
        //ADD ValidID VARBINARY(MAX),
        //ProofOfIncome VARBINARY(MAX);



        //Query for table Loan
        //        CREATE TABLE Loan
        //        (
        //    LoanID INT PRIMARY KEY IDENTITY(1,1), 
        //    UserID INT NOT NULL,                 
        //    Amount DECIMAL(18, 2) NOT NULL,       
        //    Term VARCHAR(50) NOT NULL,            
        //    Status VARCHAR(50) NOT NULL,           
        //    CreatedAt DATETIME DEFAULT GETDATE(),  
        //    ApprovedAt DATETIME NULL,              
        //    DisbursedAt DATETIME NULL,            

        //    CONSTRAINT FK_Loan_Users FOREIGN KEY(UserID) REFERENCES Users(UserID)
        //);

        //        ALTER TABLE Loan
        //ADD
        //    LoanPurpose VARCHAR(255) NULL,
        //    PaymentDate DATETIME NULL;


        //        CREATE TABLE Disbursement(
        //        DisbursementID INT PRIMARY KEY IDENTITY(1,1),
        //        LoanID INT NOT NULL,
        //        Amount DECIMAL(18,2) NOT NULL,
        //        DisbursedAt DATETIME DEFAULT GETDATE(),
        //        FOREIGN KEY(LoanID) REFERENCES Loan(LoanID)
        //);


//        CREATE TABLE Payments(
//        PaymentID INT PRIMARY KEY IDENTITY(1,1),
//        LoanID INT NOT NULL,                 -- FK to Loans table
//        AmountPaid DECIMAL(18,2) NOT NULL,   -- How much the user paid
//        PaymentDate DATETIME DEFAULT GETDATE(), -- When they paid
    

//        FOREIGN KEY(LoanID) REFERENCES Loan(LoanID)
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


        public bool ValidateLogin(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM Users WHERE Username = @username AND PasswordHash = @password";

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // In real apps, use hashing!

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public string GetFullName(string username, string password)
        {
            string fullName = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FirstName, LastName FROM Users WHERE Username = @Username AND PasswordHash = @Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();
                            fullName = $"{firstName} {lastName}";
                        }
                    }
                }
            }
            return fullName;
        }
        public string GetStatus(string username, string password)
        {
            string status = ""; // Renamed variable to avoid conflict
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Status FROM Users WHERE Username = @Username AND PasswordHash = @Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            status = reader["Status"].ToString(); // Use the renamed variable
                        }
                    }
                }
            }
            return status;
        }






        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            string query = @"SELECT UserId, FirstName, LastName, Status FROM Users"; // Add all columns

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
                        Status = reader.GetString(3)  // Fixed index from 19 to 9
                    });
                }
            }
            return users;
        }

        public User GetUserById(string userId)
        {
            string query = @"SELECT UserId, FirstName, LastName, PhoneNumber, Address, 
                        DateOfBirth, EmploymentStatus, MonthlyIncome, Username, Status
                        FROM Users WHERE UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserId = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            PhoneNumber = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Address = reader.IsDBNull(4) ? null : reader.GetString(4),
                            DateOfBirth = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
                            EmploymentStatus = reader.IsDBNull(6) ? null : reader.GetString(6),
                            MonthlyIncome = reader.IsDBNull(7) ? (decimal?)null : reader.GetDecimal(7),
                            Username = reader.GetString(8),
                            Status = reader.GetString(9)
                        };
                    }
                }
            }
            return null;
        }
        public int GetUserID(string username, string password)
        {
            int userID = -1;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UserID FROM Users WHERE Username = @Username AND PasswordHash = @Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userID = Convert.ToInt32(reader["UserID"]);
                        }
                    }
                }
            }
            return userID;
        }



        // Add this to your DatabaseHelper class
        public bool UpdateUserStatus(string userId, string newStatus)
        {
            const string query = @"
        UPDATE Users 
        SET Status = @Status 
        WHERE UserId = @UserId";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", newStatus);
                    command.Parameters.AddWithValue("@UserId", userId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Log error
                Console.WriteLine($"Error updating status: {ex}");
                return false;
            }
        }

        public bool SaveUserImages(int userID, Image validID, Image proofOfIncome)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Convert images to byte arrays
                byte[] idBytes = ImageToByteArray(validID);
                byte[] proofBytes = ImageToByteArray(proofOfIncome);

                string query = @"UPDATE Users 
                         SET ValidID = @ValidID, ProofOfIncome = @Proof 
                         WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ValidID", idBytes);
                    cmd.Parameters.AddWithValue("@Proof", proofBytes);
                    cmd.Parameters.AddWithValue("@UserID", userID);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }



        public bool InsertLoan(int userID, decimal amount, string term, string loanPurpose, DateTime paymentDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Loan (UserID, Amount, Term, LoanPurpose, PaymentDate, Status, CreatedAt)
                             VALUES (@UserID, @Amount, @Term, @LoanPurpose, @PaymentDate, @Status, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@Term", term);
                        cmd.Parameters.AddWithValue("@LoanPurpose", loanPurpose);
                        cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                        cmd.Parameters.AddWithValue("@Status", "Pending");

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // True if insert successful
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting loan: " + ex.Message);
                    return false;
                }
            }
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




        public DataTable GetLoansWithUserNames()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                L.LoanID AS LoanID,  -- ✅ Include LoanID
                (U.FirstName + ' ' + U.LastName) AS Loanee,
                L.Amount AS Loan_Amount,
                L.Status
            FROM Loan L
            INNER JOIN Users U ON L.UserID = U.UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }




        public DataTable GetLoanDetailsByLoanId(int loanId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                (U.FirstName + ' ' + U.LastName) AS Loanee,
                L.Amount AS Loan_Amount,
                L.Term,
                L.LoanPurpose,
                L.Status
            FROM Loan L
            INNER JOIN Users U ON L.UserID = U.UserID
            WHERE L.LoanID = @LoanID";  // ✅ Make sure this is by LoanID

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LoanID", loanId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        public bool UpdateLoanStatus(int loanID, string newStatus)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                UPDATE Loan
                SET Status = @Status,
                    ApprovedAt = CASE WHEN @Status = 'Approved' THEN GETDATE() ELSE NULL END
                WHERE LoanID = @LoanID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Status", newStatus);
                        cmd.Parameters.AddWithValue("@LoanID", loanID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Returns true if the update was successful
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating loan status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }





        public bool InsertDisbursement(int loanId, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Disbursement (LoanID, Amount) VALUES (@LoanID, @Amount)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LoanID", loanId);
                cmd.Parameters.AddWithValue("@Amount", amount);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public DataTable GetAllDisbursements()
        {
            DataTable dt = new DataTable();
            string query = @"
            SELECT 
                (U.FirstName + ' ' + U.LastName) AS Loanee,
                L.Amount AS Loan_Amount,
                D.DisbursedAt AS Disbursed_Date
            FROM Disbursement D
            INNER JOIN Loan L ON D.LoanID = L.LoanID
            INNER JOIN Users U ON L.UserID = U.UserID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }





    }
}

