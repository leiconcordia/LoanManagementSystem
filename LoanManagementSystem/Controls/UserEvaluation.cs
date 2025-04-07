using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LoanManagementSystem;

namespace LoanManagementSystem.Controls
{
    public partial class UserEvaluation : UserControl
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public UserEvaluation()
        {
            InitializeComponent();
            
        }

        // Method to load and display users in the DataGridView
        private void LoadUsers()
        {
            List<User> users = dbHelper.GetUsers(); // Fetch users from the database

            dataGridView1.Rows.Clear(); // Clear existing rows in the DataGridView

            // Populate DataGridView with user data
            foreach (var user in users)
            {
                int rowIndex = dataGridView1.Rows.Add(); // Add a new row to the DataGridView
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                // Set the values in the row for each column
                row.Cells["Name"].Value = $"{user.FirstName} {user.LastName}";
                row.Cells["Status"].Value = $"{user.Status}";
                row.Cells["View"].Value = "View"; // You can handle "Edit" logic separately
            }
        }

        // Event handler for the UserControl load event
        private void UserEvaluation_Load(object sender, EventArgs e)
        {
            LoadUsers(); // Call LoadUsers method when the control is loaded
        }
    }
}
