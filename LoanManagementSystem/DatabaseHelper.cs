using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoanManagementSystem
{
    public class DatabaseHelper
    {
        // Replace with your actual SQL Server connection string
        private readonly string connectionString = "Server=DESKTOP-7GEUIL3\\SQLEXPRESS;Database=DB_LoanManagementSystem;Trusted_Connection=True;";

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
    }
}
