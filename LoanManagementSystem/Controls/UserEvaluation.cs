using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            // In your form constructor or Load event:
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        // Method to load and display users in the DataGridView
        private void LoadUsers()
        {

            List<DatabaseHelper.User> users = dbHelper.GetUsers(); // Fetch users from the database


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
                dataGridView1.Columns["View"].DefaultCellStyle.BackColor = Color.LightBlue;

            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Skip header clicks and invalid rows
            if (e.RowIndex < 0) return;

            // Get 1-based row number (2 for second row, etc.)
            int rowNumber = e.RowIndex + 1;

            // Create UserInfo control with the row number
            UserInfo userInfoControl = new UserInfo(rowNumber.ToString());

           

       
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm?.switchUserControl(userInfoControl);
        }







        // Event handler for the UserControl load event
        private void UserEvaluation_Load(object sender, EventArgs e)
        {
            LoadUsers(); // Call LoadUsers method when the control is loaded
            
          
        }
    }
}
