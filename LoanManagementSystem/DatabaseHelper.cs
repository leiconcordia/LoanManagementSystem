﻿using LoanManagementSystem.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Windows.Forms;
using static LoanManagementSystem.DatabaseHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LoanManagementSystem
{
    public class DatabaseHelper
    {

        //Query for table Users

        //CREATE TABLE Users(
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

        //        ALTER TABLE Users
        //        ADD ValidID VARBINARY(MAX),
        //        ProofOfIncome VARBINARY(MAX);
        //        ALTER TABLE Users
        //ADD CreditBalance DECIMAL(10, 2) NOT NULL DEFAULT 0.00;




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
        //ADD MonthlyPayment DECIMAL(10, 2) NOT NULL DEFAULT 0;

        //        ALTER TABLE Loan
        //ADD
        //                    LoanPurpose VARCHAR(255) NULL,
        //                    PaymentDate DATETIME NULL;

        //                ALTER TABLE Loan
        //        ADD Interest DECIMAL(10,2) NOT NULL DEFAULT 0.00,
        //            NewBalance DECIMAL(10,2) NOT NULL DEFAULT 0.00;


        //CREATE TABLE Disbursement(
        //DisbursementID INT PRIMARY KEY IDENTITY(1,1),
        //        LoanID INT NOT NULL,
        //        Amount DECIMAL(18,2) NOT NULL,
        //        DisbursedAt DATETIME DEFAULT GETDATE(),
        //        FOREIGN KEY(LoanID) REFERENCES Loan(LoanID)
        //);


        //CREATE TABLE Payments(
        //    PaymentID INT PRIMARY KEY IDENTITY(1,1),  -- Auto-incrementing primary key
        //    LoanID INT NOT NULL,
        //    Balance DECIMAL(18,2) NOT NULL,
        //    Status VARCHAR(50) NOT NULL,
        //    Remarks VARCHAR(255) NULL,
        //    CreatedDate DATETIME DEFAULT GETDATE(),

        //    -- Add foreign key constraint to link with Loan table
        //    CONSTRAINT FK_Payments_Loan FOREIGN KEY(LoanID)
        //    REFERENCES Loan(LoanID)
        //);



        //        CREATE TABLE PaymentSchedule(
        //    LoanID INT,
        //    MonthIndex INT,
        //    DueDate DATE,
        //    MonthlyPayment DECIMAL(18,2),
        //    ScheduledBalance DECIMAL(18,2),
        //    PRIMARY KEY(LoanID, MonthIndex)
        //);


//        CREATE TABLE ActivityLogs(
//LogID INT PRIMARY KEY IDENTITY,
//Action VARCHAR(50),
//            Message VARCHAR(255),
//            Timestamp DATETIME DEFAULT GETDATE()
//        );

//         _dbHelper.LogActivity("User Approved", $"user #{_userId}");
//          db.DisburseLoan(loanId);  // Your logic
//        db.LogActivity("Loan Disbursed", $"Disbursed {amount} for Loan #{loanId}");






        // Replace with your actual SQL Server connection string
        //private readonly string connectionString = "Server=LAPTOP-GHQG6N7F\\SQLEXPRESS01;Database=DB_KASALIGAN_LOAN_SYSTEM;Trusted_Connection=True;";
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






        //public List<User> GetUsers()
        //{
        //    List<User> users = new List<User>();

        //    string query = @"SELECT UserId, FirstName, LastName, Status FROM Users"; // Add all columns

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(query, connection);
        //        connection.Open();

        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            users.Add(new User
        //            {
        //                UserId = reader.GetInt32(0),
        //                FirstName = reader.GetString(1),
        //                LastName = reader.GetString(2),
        //                Status = reader.GetString(3)  // Fixed index from 19 to 9
        //            });
        //        }
        //    }
        //    return users;
        //}

        public List<User> GetUsers(string searchTerm = "")
        {
            List<User> users = new List<User>();
            string query = @"
                SELECT UserId, FirstName, LastName, Status 
                FROM Users 
                WHERE FirstName LIKE @Search OR LastName LIKE @Search
                ORDER BY CreatedAt DESC";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Search", $"%{searchTerm}%");
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        UserId = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Status = reader.GetString(3)
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

        public string GetUserStatus(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Status FROM Users WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
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



        public bool InsertLoan(int userID, decimal amount, int term, string loanPurpose, decimal monthlyPayment, decimal newBalance, decimal interest)

        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                INSERT INTO Loan (UserID, Amount, Term, LoanPurpose, MonthlyPayment, Status, NewBalance, Interest)
                VALUES (@UserID, @Amount, @Term, @LoanPurpose, @MonthlyPayment, @Status, @NewBalance, @Interest)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@Term", term);
                        cmd.Parameters.AddWithValue("@LoanPurpose", loanPurpose);
                        cmd.Parameters.AddWithValue("@MonthlyPayment", monthlyPayment);
                        cmd.Parameters.AddWithValue("@Status", "Pending");
                        cmd.Parameters.AddWithValue("@NewBalance", newBalance);
                        cmd.Parameters.AddWithValue("@Interest", interest);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // True if successful
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting loan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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




        public void LogActivity(string action, string message)
        {
            string query = "INSERT INTO ActivityLogs (Action, Message) VALUES (@action, @message)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@action", action);
                cmd.Parameters.AddWithValue("@message", message);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        

        public int GetPendingUsers()
        {
            int total = 0;
            string query = "SELECT * FROM Users WHERE Status = 'Pending'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();

             
            }

            return total;
        }


        public DataTable GetUsersWithNearDueDates()
        {
            DataTable dt = new DataTable();
            string query = @"
                    SELECT 
                    l.LoanID AS [Loan ID],
                    l.UserID AS [User ID],
                    ps.MonthlyPayment AS [Amount],
                    ps.DueDate AS [Scheduled Date]
                FROM Loan l
                JOIN PaymentSchedule ps ON l.LoanID = ps.LoanID
                WHERE 
                    l.Status = 'Disbursed' AND 
                    ps.DueDate BETWEEN CAST(GETDATE() AS DATE) AND DATEADD(MONTH, 2, CAST(GETDATE() AS DATE))
                ORDER BY ps.DueDate;
                ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }




        public DataTable GetRecentActivities()
        {
            DataTable dt = new DataTable();
            string query = "SELECT TOP 10 Action, Message, Timestamp FROM ActivityLogs ORDER BY Timestamp DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }



        //public Dictionary<string, int> GetLoanStatusCounts()
        //{
        //    Dictionary<string, int> statusCounts = new Dictionary<string, int>();

        //    string query = @"SELECT Status, COUNT(*) AS Count FROM Loan GROUP BY Status";

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            conn.Open();
        //            SqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                string status = reader["Status"].ToString();
        //                int count = Convert.ToInt32(reader["Count"]);
        //                statusCounts[status] = count;
        //            }
        //        }
        //    }

        //    return statusCounts;
        //}

        public decimal GetTotalDisbursedAmount()
        {
            decimal total = 0;
            string query = "SELECT ISNULL(SUM(Amount), 0) FROM Disbursement";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    total = Convert.ToDecimal(result);
                }
            }

            return total;
        }




        public int GetPendingLoans()
        {
            int count = 0;
            string query = @"
  SELECT COUNT(*) FROM Loan WHERE Status = 'Pending'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                count = (int)cmd.ExecuteScalar();
            }

            return count;
        }

        // Method to get the count of active loans (those that have been disbursed)
        public int GetActiveLoanCount()
        {
            int count = 0;
            string query = @"
  SELECT COUNT(*) 
  FROM Loan L
  INNER JOIN Disbursement D ON L.LoanID = D.LoanID
  WHERE L.Status = 'Disbursed'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                count = (int)cmd.ExecuteScalar();
            }

            return count;
        }




        public DataTable SearchLoansByName(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
    SELECT L.LoanID, (U.FirstName + ' ' + U.LastName) AS Loanee,
           L.Amount AS Loan_Amount, L.Status
    FROM Loan L
    INNER JOIN Users U ON L.UserID = U.UserID
    WHERE (U.FirstName + ' ' + U.LastName) LIKE @keyword";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable SearchLoansByNameAndStatus(string keyword, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
    SELECT L.LoanID, (U.FirstName + ' ' + U.LastName) AS Loanee,
           L.Amount AS Loan_Amount, L.Status
    FROM Loan L
    INNER JOIN Users U ON L.UserID = U.UserID
    WHERE (U.FirstName + ' ' + U.LastName) LIKE @keyword
      AND L.Status = @status";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    cmd.Parameters.AddWithValue("@status", status);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }






        //KANI SIYA DONG NAA NI SIYAY METHOD NA INGANI ILISI LANG TONG DAAN ANI.

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
    L.Status,
    L.ValidID,
    L.ProofOfIncome
FROM Loan L
INNER JOIN Users U ON L.UserID = U.UserID
WHERE L.LoanID = @LoanID";
                // ✅ Make sure this is by LoanID

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


        //KANING DUHA I ADD JUDNI KAY BAGO NI. 

        public int GetUserIdByLoanId(int loanId)
        {
            int userId = -1;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID FROM Loan WHERE LoanID = @LoanID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LoanID", loanId);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    userId = Convert.ToInt32(result);
                }
            }
            return userId;
        }


        public int GetDisbursedLoanCountByUserId(int userId)
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Loan WHERE UserID = @UserID AND Status = 'Disbursed'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();
                count = (int)cmd.ExecuteScalar();
            }
            return count;
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





        //public bool InsertDisbursement(int loanId, decimal amount)
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();

        //        SqlTransaction transaction = conn.BeginTransaction();

        //        try
        //        {
        //            // 1. Insert into Disbursement table
        //            string insertQuery = "INSERT INTO Disbursement (LoanID, Amount) VALUES (@LoanID, @Amount)";
        //            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction))
        //            {
        //                insertCmd.Parameters.AddWithValue("@LoanID", loanId);
        //                insertCmd.Parameters.AddWithValue("@Amount", amount);
        //                insertCmd.ExecuteNonQuery();
        //            }

        //            // 2. Get the UserID from Loan table
        //            int userId;
        //            string getUserQuery = "SELECT UserID FROM Loan WHERE LoanID = @LoanID";
        //            using (SqlCommand getUserCmd = new SqlCommand(getUserQuery, conn, transaction))
        //            {
        //                getUserCmd.Parameters.AddWithValue("@LoanID", loanId);
        //                object result = getUserCmd.ExecuteScalar();
        //                if (result == null)
        //                {
        //                    transaction.Rollback();
        //                    return false;
        //                }
        //                userId = Convert.ToInt32(result);
        //            }

        //            // 3. Update CreditBalance for the user
        //            string updateCreditQuery = "UPDATE Users SET CreditBalance = CreditBalance + @Amount WHERE UserID = @UserID";
        //            using (SqlCommand updateCmd = new SqlCommand(updateCreditQuery, conn, transaction))
        //            {
        //                updateCmd.Parameters.AddWithValue("@Amount", amount);
        //                updateCmd.Parameters.AddWithValue("@UserID", userId);
        //                updateCmd.ExecuteNonQuery();
        //            }

        //            transaction.Commit();
        //            return true;
        //        }
        //        catch
        //        {
        //            transaction.Rollback();
        //            return false;
        //        }
        //    }
        //}

        //public bool InsertDisbursement(int loanId, decimal amount)
        //{
        //    if (loanId <= 0 || amount <= 0)
        //    {
        //        MessageBox.Show("Invalid loan ID or amount.");
        //        return false;
        //    }

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        SqlTransaction transaction = conn.BeginTransaction();

        //        try
        //        {
        //            // 1. Insert into Disbursement table
        //            string insertQuery = "INSERT INTO Disbursement (LoanID, Amount, DisbursedAt) VALUES (@LoanID, @Amount, GETDATE())";
        //            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction))
        //            {
        //                insertCmd.Parameters.AddWithValue("@LoanID", loanId);
        //                insertCmd.Parameters.AddWithValue("@Amount", amount);
        //                insertCmd.ExecuteNonQuery();
        //            }

        //            // 2. Get UserID from Loan table
        //            int userId;
        //            string getUserQuery = "SELECT UserID FROM Loan WHERE LoanID = @LoanID";
        //            using (SqlCommand getUserCmd = new SqlCommand(getUserQuery, conn, transaction))
        //            {
        //                getUserCmd.Parameters.AddWithValue("@LoanID", loanId);
        //                object result = getUserCmd.ExecuteScalar();
        //                if (result == null || result == DBNull.Value)
        //                {
        //                    transaction.Rollback();
        //                    return false;
        //                }
        //                userId = Convert.ToInt32(result);
        //            }

        //            // 3. Update User CreditBalance
        //            string updateCreditQuery = "UPDATE Users SET CreditBalance = CreditBalance + @Amount WHERE UserID = @UserID";
        //            using (SqlCommand updateCmd = new SqlCommand(updateCreditQuery, conn, transaction))
        //            {
        //                updateCmd.Parameters.AddWithValue("@Amount", amount);
        //                updateCmd.Parameters.AddWithValue("@UserID", userId);
        //                updateCmd.ExecuteNonQuery();
        //            }

        //            // 4. Get loan details: Term, MonthlyPayment, NewBalance
        //            int term = 0;
        //            decimal monthlyPayment = 0, newBalance = 0;
        //            string getLoanQuery = "SELECT Term, MonthlyPayment, NewBalance FROM Loan WHERE LoanID = @LoanID";
        //            using (SqlCommand cmdLoan = new SqlCommand(getLoanQuery, conn, transaction))
        //            {
        //                cmdLoan.Parameters.AddWithValue("@LoanID", loanId);
        //                using (SqlDataReader reader = cmdLoan.ExecuteReader())

        //                {
        //                    if (reader.Read())
        //                    {
        //                        // Then proceed with your logic
        //                        object termObj = reader.GetValue(0);
        //                        term = (termObj == null || termObj == DBNull.Value) ? 0 : int.TryParse(termObj.ToString(), out int parsedTerm) ? parsedTerm : 0;
        //                        monthlyPayment = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
        //                        newBalance = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
        //                    }
        //                    else
        //                    {
        //                        transaction.Rollback();
        //                        return false;
        //                    }
        //                }
        //            }

        //            // 5. Get Disbursement date
        //            DateTime disbursementDate;
        //            string getDateQuery = "SELECT DisbursedAt FROM Disbursement WHERE LoanID = @LoanID";
        //            using (SqlCommand cmdDate = new SqlCommand(getDateQuery, conn, transaction))
        //            {
        //                cmdDate.Parameters.AddWithValue("@LoanID", loanId);
        //                object dateResult = cmdDate.ExecuteScalar();
        //                if (dateResult == null || dateResult == DBNull.Value)
        //                {
        //                    transaction.Rollback();
        //                    return false;
        //                }
        //                disbursementDate = Convert.ToDateTime(dateResult);
        //            }

        //            // 6. Insert full PaymentSchedule
        //            for (int i = 1; i <= term; i++)
        //            {
        //                DateTime dueDate = disbursementDate.AddMonths(i);
        //                decimal scheduledBalance = newBalance - (monthlyPayment * i);
        //                if (scheduledBalance < 0) scheduledBalance = 0;

        //                string insertSchedule = @"
        //            INSERT INTO PaymentSchedule (LoanID, MonthIndex, DueDate, MonthlyPayment, ScheduledBalance)
        //            VALUES (@LoanID, @MonthIndex, @DueDate, @MonthlyPayment, @ScheduledBalance)";
        //                using (SqlCommand cmdInsert = new SqlCommand(insertSchedule, conn, transaction))
        //                {
        //                    cmdInsert.Parameters.AddWithValue("@LoanID", loanId);
        //                    cmdInsert.Parameters.AddWithValue("@MonthIndex", i);
        //                    cmdInsert.Parameters.AddWithValue("@DueDate", dueDate);
        //                    cmdInsert.Parameters.AddWithValue("@MonthlyPayment", monthlyPayment);
        //                    cmdInsert.Parameters.AddWithValue("@ScheduledBalance", scheduledBalance);
        //                    cmdInsert.ExecuteNonQuery();
        //                }
        //            }

        //            transaction.Commit();
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            transaction?.Rollback();
        //            MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
        //            return false;
        //        }
        //    }
        //}

        public bool InsertDisbursement(int loanId, decimal amount)
        {
            if (loanId <= 0 || amount <= 0)
            {
                MessageBox.Show("Invalid loan ID or amount.");
                return false;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Get latest AdminWallet balance
                    decimal adminBalance = 0;
                    string getAdminBalanceQuery = "SELECT TOP 1 TotalBalance FROM AdminWallet ORDER BY WalletID DESC";

                    using (SqlCommand adminBalanceCmd = new SqlCommand(getAdminBalanceQuery, conn, transaction))
                    {
                        object result = adminBalanceCmd.ExecuteScalar();
                        if (result == null || result == DBNull.Value)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Unable to retrieve AdminWallet balance.");
                            return false;
                        }

                        adminBalance = Convert.ToDecimal(result);
                        if (adminBalance < amount)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Admin wallet has insufficient balance.");
                            return false;
                        }
                    }

                    // 2. Subtract amount and insert a new wallet record
                    decimal newAdminBalance = adminBalance - amount;
                    string insertAdminWalletQuery = @"
                INSERT INTO AdminWallet (TotalBalance, LastUpdated)
                VALUES (@TotalBalance, GETDATE())"; // WalletID is assumed to be IDENTITY

                    using (SqlCommand updateAdminCmd = new SqlCommand(insertAdminWalletQuery, conn, transaction))
                    {
                        updateAdminCmd.Parameters.AddWithValue("@TotalBalance", newAdminBalance);
                        updateAdminCmd.ExecuteNonQuery();
                    }



                    // --- continue with your original disbursement, user credit update, and payment schedule logic ---
                    // [Insert into Disbursement]
                    string insertQuery = "INSERT INTO Disbursement (LoanID, Amount, DisbursedAt) VALUES (@LoanID, @Amount, GETDATE())";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction))
                    {
                        insertCmd.Parameters.AddWithValue("@LoanID", loanId);
                        insertCmd.Parameters.AddWithValue("@Amount", amount);
                        insertCmd.ExecuteNonQuery();
                    }

                    // [Get UserID from Loan]
                    int userId;
                    string getUserQuery = "SELECT UserID FROM Loan WHERE LoanID = @LoanID";
                    using (SqlCommand getUserCmd = new SqlCommand(getUserQuery, conn, transaction))
                    {
                        getUserCmd.Parameters.AddWithValue("@LoanID", loanId);
                        object result = getUserCmd.ExecuteScalar();
                        if (result == null || result == DBNull.Value)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Loan not found.");
                            return false;
                        }
                        userId = Convert.ToInt32(result);
                    }

                    // [Update User CreditBalance]
                    string updateCreditQuery = "UPDATE Users SET CreditBalance = CreditBalance + @Amount WHERE UserID = @UserID";
                    using (SqlCommand updateCmd = new SqlCommand(updateCreditQuery, conn, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@Amount", amount);
                        updateCmd.Parameters.AddWithValue("@UserID", userId);
                        updateCmd.ExecuteNonQuery();
                    }

                    // [Get loan details]
                    int term = 0;
                    decimal monthlyPayment = 0, newBalance = 0;
                    string getLoanQuery = "SELECT Term, MonthlyPayment, NewBalance FROM Loan WHERE LoanID = @LoanID";
                    using (SqlCommand cmdLoan = new SqlCommand(getLoanQuery, conn, transaction))
                    {
                        cmdLoan.Parameters.AddWithValue("@LoanID", loanId);
                        using (SqlDataReader reader = cmdLoan.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                object termObj = reader.GetValue(0);
                                term = (termObj == null || termObj == DBNull.Value) ? 0 : int.TryParse(termObj.ToString(), out int parsedTerm) ? parsedTerm : 0;
                                monthlyPayment = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                                newBalance = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Loan details not found.");
                                return false;
                            }
                        }
                    }

                    // [Get Disbursement date]
                    DateTime disbursementDate;
                    string getDateQuery = "SELECT TOP 1 DisbursedAt FROM Disbursement WHERE LoanID = @LoanID ORDER BY DisbursedAt DESC";
                    using (SqlCommand cmdDate = new SqlCommand(getDateQuery, conn, transaction))
                    {
                        cmdDate.Parameters.AddWithValue("@LoanID", loanId);
                        object dateResult = cmdDate.ExecuteScalar();
                        if (dateResult == null || dateResult == DBNull.Value)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Disbursement date not found.");
                            return false;
                        }
                        disbursementDate = Convert.ToDateTime(dateResult);
                    }

                    // [Insert PaymentSchedule]
                    for (int i = 1; i <= term; i++)
                    {
                        DateTime dueDate = disbursementDate.AddMonths(i);
                        decimal scheduledBalance = newBalance - (monthlyPayment * i);
                        if (scheduledBalance < 0) scheduledBalance = 0;

                        string insertSchedule = @"
                    INSERT INTO PaymentSchedule (LoanID, MonthIndex, DueDate, MonthlyPayment, ScheduledBalance)
                    VALUES (@LoanID, @MonthIndex, @DueDate, @MonthlyPayment, @ScheduledBalance)";
                        using (SqlCommand cmdInsert = new SqlCommand(insertSchedule, conn, transaction))
                        {
                            cmdInsert.Parameters.AddWithValue("@LoanID", loanId);
                            cmdInsert.Parameters.AddWithValue("@MonthIndex", i);
                            cmdInsert.Parameters.AddWithValue("@DueDate", dueDate);
                            cmdInsert.Parameters.AddWithValue("@MonthlyPayment", monthlyPayment);
                            cmdInsert.Parameters.AddWithValue("@ScheduledBalance", scheduledBalance);
                            cmdInsert.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
                    return false;
                }
            }
        }





        public DataTable GetAllDisbursements()
        {
            DataTable dt = new DataTable();
            string query = @"
SELECT 
    L.LoanID,  -- Include LoanID
    (U.FirstName + ' ' + U.LastName) AS Loanee,
    L.Amount AS Loan_Amount,
    D.DisbursedAt AS Disbursed_Date
FROM Loan L
INNER JOIN Users U ON L.UserID = U.UserID
LEFT JOIN Disbursement D ON D.LoanID = L.LoanID
WHERE L.Status = 'Disbursed'";

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

        public DataTable SearchDisbursements(string keyword)
        {
            DataTable dt = new DataTable();
            string query = @"
SELECT 
    L.LoanID,  -- ✅ Make sure this is included!
    (U.FirstName + ' ' + U.LastName) AS Loanee,
    L.Amount AS Loan_Amount,
    D.DisbursedAt AS Disbursed_Date
FROM Loan L
INNER JOIN Users U ON L.UserID = U.UserID
LEFT JOIN Disbursement D ON D.LoanID = L.LoanID
WHERE L.Status = 'Disbursed' AND 
      (U.FirstName LIKE @Keyword OR U.LastName LIKE @Keyword)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }




        public string GetLoanStatusById(int loanId)
        {
            string status = "";
            string query = "SELECT Status FROM Loan WHERE LoanID = @LoanID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LoanID", loanId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        status = result.ToString();
                    }
                }
            }

            return status;
        }





//        DECLARE @Term INT, @MonthlyPayment DECIMAL(18,2), @StartDate DATE, @NewBalance DECIMAL(18,2);

//-- Get loan details
//SELECT
//    @Term = Term,
//    @MonthlyPayment = MonthlyPayment,
//    @StartDate = Disbursement.DisbursedAt,
//    @NewBalance = NewBalance
//FROM Loan
//INNER JOIN Disbursement ON Loan.LoanID = Disbursement.LoanID
//WHERE Loan.LoanID = @LoanID;

//-- Generate sequence of months starting from 1 to @Term
//WITH PaymentSchedule AS(
//    SELECT 1 AS[MonthIndex], DATEADD(MONTH, 1, @StartDate) AS[ExpectedDate]  -- due date is 1 month after disbursed date
//    UNION ALL
//    SELECT[MonthIndex] + 1, DATEADD(MONTH, 1, [ExpectedDate])
//    FROM PaymentSchedule
//    WHERE[MonthIndex] < @Term
//)

//-- Combine schedule with actual payments
//SELECT
//    ps.MonthIndex,
//    FORMAT(ps.ExpectedDate, 'yyyy-MM-dd') AS[Due Date],
//    ISNULL(p.PaymentDate, NULL) AS[Payment Date],
//    @MonthlyPayment AS[Monthly Payment],
//    -- Calculate remaining balance after payments made for each month, don't let it go below 0
//    CASE
//        WHEN(@NewBalance - (@MonthlyPayment* ps.MonthIndex)) < 0 THEN 0
//        ELSE(@NewBalance - (@MonthlyPayment* ps.MonthIndex))
//    END AS[Balance],
//    ISNULL(p.Status, 'Not yet paid') AS[Status],
//    ISNULL(p.Remarks, '') AS[Remarks]
//FROM PaymentSchedule ps
//LEFT JOIN(
//    SELECT
//        ROW_NUMBER() OVER (ORDER BY PaymentDate) AS PaymentIndex,  -- Payments are 1-based here to match MonthIndex
//        PaymentDate,
//        Status,
//        Remarks
//    FROM Payments
//    WHERE LoanID = @LoanID
//) p ON ps.MonthIndex = p.PaymentIndex
//ORDER BY ps.MonthIndex
//OPTION (MAXRECURSION 100);"





        public DataTable GetPaymentHistoryByLoanId(int loanId)
        {
            DataTable dt = new DataTable();

            string query = @"
SELECT 
    ps.MonthIndex,
    FORMAT(ps.DueDate, 'yyyy-MM-dd') AS [Due Date],
    FORMAT(p.PaymentDate, 'yyyy-MM-dd') AS [Payment Date],
    ps.MonthlyPayment AS [Monthly Payment],
    ps.ScheduledBalance AS [Balance],
    ISNULL(p.Status, 'Not yet paid') AS [Status],
    ISNULL(p.Remarks, '') AS [Remarks]
FROM PaymentSchedule ps
LEFT JOIN (
    SELECT 
        ROW_NUMBER() OVER (ORDER BY PaymentDate) AS PaymentIndex,
        PaymentDate,
        Status,
        Remarks,
        LoanID
    FROM Payments
    WHERE LoanID = @LoanID
) p ON ps.LoanID = p.LoanID AND ps.MonthIndex = p.PaymentIndex
WHERE ps.LoanID = @LoanID
ORDER BY ps.MonthIndex;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LoanID", loanId);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving generated payment schedule: " + ex.Message);
            }

            return dt;
        }






        public decimal GetUserCreditBalance(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CreditBalance FROM Users WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0m;
                }
            }
        }




        public DataTable GetActiveLoansByUser(int userId)
        {
            DataTable dt = new DataTable();

            string query = @"  
SELECT  
    l.LoanID, -- Include but won't display  
    l.Amount AS [Principal],  
    l.LoanPurpose AS [Loan Purpose],  
    l.monthlyPayment AS [Monthly Payment],  
    l.Term,  
    l.Status  
FROM  
    Loan l  
WHERE  
    l.Status IN ('Approved', 'Disbursed') AND l.UserID = @UserID";


            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        public decimal GetAdminTotalBalance()
        {
            decimal totalBalance = 0m;

            string query = "SELECT TOP 1 TotalBalance FROM AdminWallet ORDER BY WalletID DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        totalBalance = Convert.ToDecimal(result);
                    }
                }
            }

            return totalBalance;
        }

        public bool AddPaymentAndUpdateLoan(int userId, int loanId, decimal monthlyPayment)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Get loan disbursement date (start date for payments)
                    string getLoanDate = "SELECT DisbursedAt FROM Disbursement WHERE LoanID = @LoanID";
                    SqlCommand cmdDate = new SqlCommand(getLoanDate, conn, transaction);
                    cmdDate.Parameters.AddWithValue("@LoanID", loanId);
                    DateTime loanStartDate = Convert.ToDateTime(cmdDate.ExecuteScalar());


                    // Count existing payments
                    string countQuery = "SELECT COUNT(*) FROM Payments WHERE LoanID = @LoanID";
                    SqlCommand cmdCount = new SqlCommand(countQuery, conn, transaction);
                    cmdCount.Parameters.AddWithValue("@LoanID", loanId);
                    int paymentsMade = (int)cmdCount.ExecuteScalar();

                    // Compute due date for current payment
                    DateTime expectedDueDate = loanStartDate.AddMonths(paymentsMade);
                    DateTime today = DateTime.Now;

                    string remark;
                    if (today.Date < expectedDueDate.Date)
                        remark = "Early";
                    else if (today.Date == expectedDueDate.Date)
                        remark = "On Time";
                    else
                        remark = "Late";

                    // Get user's credit balance
                    string creditQuery = "SELECT CreditBalance FROM [Users] WHERE UserID = @UserID";
                    SqlCommand cmdCredit = new SqlCommand(creditQuery, conn, transaction);
                    cmdCredit.Parameters.AddWithValue("@UserID", userId);
                    decimal creditBalance = Convert.ToDecimal(cmdCredit.ExecuteScalar());

                    if (creditBalance < monthlyPayment)
                    {
                        MessageBox.Show("Insufficient credit balance for this payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        transaction.Rollback();
                        return false;
                    }

                    // Subtract from user's credit balance
                    string updateUser = @"UPDATE [Users]
                                  SET CreditBalance = CreditBalance - @MonthlyPayment
                                  WHERE UserID = @UserID";
                    SqlCommand cmdUser = new SqlCommand(updateUser, conn, transaction);
                    cmdUser.Parameters.AddWithValue("@MonthlyPayment", monthlyPayment);
                    cmdUser.Parameters.AddWithValue("@UserID", userId);
                    cmdUser.ExecuteNonQuery();

                    // Subtract from loan's new balance
                    string updateLoan = @"UPDATE Loan
                                  SET NewBalance = NewBalance - @MonthlyPayment
                                  WHERE LoanID = @LoanID";
                    SqlCommand cmdLoan = new SqlCommand(updateLoan, conn, transaction);
                    cmdLoan.Parameters.AddWithValue("@MonthlyPayment", monthlyPayment);
                    cmdLoan.Parameters.AddWithValue("@LoanID", loanId);
                    cmdLoan.ExecuteNonQuery();

                    // Insert payment record
                    string insertPayment = @"INSERT INTO Payments (LoanID, Balance, Status, Remarks, PaymentDate)
                         VALUES (@LoanID, @Balance, 'Paid', @Remarks, GETDATE())";

                    SqlCommand cmdPayment = new SqlCommand(insertPayment, conn, transaction);
                    cmdPayment.Parameters.AddWithValue("@LoanID", loanId);
                    cmdPayment.Parameters.AddWithValue("@Balance", monthlyPayment);
                    cmdPayment.Parameters.AddWithValue("@Remarks", remark);
                    cmdPayment.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error processing payment: " + ex.Message);
                    return false;
                }
            }
        }


        public void UpdateUserMaxLoanAmount(int userId, decimal maxLoanAmount)
        {
         
            string query = @"
        UPDATE Users
        SET max_loan_amount = @MaxLoanAmount
        WHERE userID = @UserID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaxLoanAmount", maxLoanAmount);
                cmd.Parameters.AddWithValue("@UserID", userId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    throw new Exception("No user found with the specified ID.");
                }
            }
        }


        public decimal GetCurrentInterestRate()
        {
            decimal rate = 0.10m; // fallback default if not found

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TOP 1 Rate FROM Interest ORDER BY ID DESC"; // assumes ID is auto-increment

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        rate = Convert.ToDecimal(result);
                    }
                }
            }

            return rate;
        }

        public bool UpdateInterestRate(decimal newRate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Interest SET Rate = @Rate WHERE ID = (SELECT TOP 1 ID FROM Interest ORDER BY ID DESC)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Rate", newRate);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }




















    }
}

