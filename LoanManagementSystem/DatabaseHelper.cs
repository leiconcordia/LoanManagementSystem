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

        //ALTER TABLE Users
        //ADD ValidID VARBINARY(MAX),
        //ProofOfIncome VARBINARY(MAX);
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
        //    LoanPurpose VARCHAR(255) NULL,
        //    PaymentDate DATETIME NULL;

        //        ALTER TABLE Loan
        //ADD Interest DECIMAL(10,2) NOT NULL DEFAULT 0.00,
        //    NewBalance DECIMAL(10,2) NOT NULL DEFAULT 0.00;


        //CREATE TABLE Disbursement(
        //DisbursementID INT PRIMARY KEY IDENTITY(1,1),
        //        LoanID INT NOT NULL,
        //        Amount DECIMAL(18,2) NOT NULL,
        //        DisbursedAt DATETIME DEFAULT GETDATE(),
        //        FOREIGN KEY(LoanID) REFERENCES Loan(LoanID)
        //);


//        CREATE TABLE Payments(
//            PaymentID INT PRIMARY KEY IDENTITY(1,1),  -- Auto-incrementing primary key
//            LoanID INT NOT NULL,
//    Balance DECIMAL(18,2) NOT NULL,
//    Status VARCHAR(50) NOT NULL,
//    Remarks VARCHAR(255) NULL,
//    CreatedDate DATETIME DEFAULT GETDATE(),
    
//    -- Add foreign key constraint to link with Loan table
//    CONSTRAINT FK_Payments_Loan FOREIGN KEY(LoanID)
//    REFERENCES Loan(LoanID)
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



        public bool InsertLoan(int userID, decimal amount, string term, string loanPurpose, decimal monthlyPayment, decimal newBalance, decimal interest)
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
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Insert into Disbursement table
                    string insertQuery = "INSERT INTO Disbursement (LoanID, Amount) VALUES (@LoanID, @Amount)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction))
                    {
                        insertCmd.Parameters.AddWithValue("@LoanID", loanId);
                        insertCmd.Parameters.AddWithValue("@Amount", amount);
                        insertCmd.ExecuteNonQuery();
                    }

                    // 2. Get the UserID from Loan table
                    int userId;
                    string getUserQuery = "SELECT UserID FROM Loan WHERE LoanID = @LoanID";
                    using (SqlCommand getUserCmd = new SqlCommand(getUserQuery, conn, transaction))
                    {
                        getUserCmd.Parameters.AddWithValue("@LoanID", loanId);
                        object result = getUserCmd.ExecuteScalar();
                        if (result == null)
                        {
                            transaction.Rollback();
                            return false;
                        }
                        userId = Convert.ToInt32(result);
                    }

                    // 3. Update CreditBalance for the user
                    string updateCreditQuery = "UPDATE Users SET CreditBalance = CreditBalance + @Amount WHERE UserID = @UserID";
                    using (SqlCommand updateCmd = new SqlCommand(updateCreditQuery, conn, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@Amount", amount);
                        updateCmd.Parameters.AddWithValue("@UserID", userId);
                        updateCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
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

        public bool AddPayment(int loanId, decimal remainingPrincipal, decimal amountPaid, DateTime paymentDate, string remarks)
        {
            string query = @"
        INSERT INTO Payments (LoanID, RemainingPrincipal, AmountPaid, PaymentDate, Remarks)
        VALUES (@LoanID, @RemainingPrincipal, @AmountPaid, @PaymentDate, @Remarks)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@LoanID", loanId);
                cmd.Parameters.AddWithValue("@RemainingPrincipal", remainingPrincipal);
                cmd.Parameters.AddWithValue("@AmountPaid", amountPaid);
                cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                cmd.Parameters.AddWithValue("@Remarks", remarks ?? (object)DBNull.Value);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }






        public DataTable GetPaymentHistoryByLoanId(int loanId)
        {
            DataTable dt = new DataTable();
            string query = @"
        -- If no payments exist, return Loan.NewBalance as the initial balance
        IF NOT EXISTS (SELECT 1 FROM Payments WHERE LoanID = @LoanID)
        BEGIN
            SELECT 
                GETDATE() AS [Payment Date],
                l.MonthlyPayment AS [Monthly Payment],  -- Changed from PaymentAmount
                l.NewBalance AS [Balance],
                'Initial Balance' AS [Status],
                'Loan created' AS [Remarks]
            FROM Loan l
            WHERE l.LoanID = @LoanID
        END
        ELSE
        BEGIN
            -- Return actual payments
            SELECT 
                p.PaymentDate AS [Payment Date],
                l.MonthlyPayment AS [Monthly Payment],  -- Changed from PaymentAmount
                p.Balance AS [Balance],
                p.Status,
                p.Remarks
            FROM Payments p
            INNER JOIN Loan l ON p.LoanID = l.LoanID
            WHERE p.LoanID = @LoanID
            ORDER BY p.PaymentDate
        END";

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
                throw new Exception("Error retrieving payment history: " + ex.Message);
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














    }
}

