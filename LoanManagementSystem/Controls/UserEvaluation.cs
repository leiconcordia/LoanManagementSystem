﻿using System;
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
             // Load users when the control is initialized
            // In your form constructor or Load event:
            dgvUserList.CellClick += DataGridView1_CellClick;
        }

        // Method to load and display users in the DataGridView
        public void LoadUsers()
        {

            List<DatabaseHelper.User> users = dbHelper.GetUsers(); // Fetch users from the database


            dgvUserList.Rows.Clear(); // Clear existing rows in the DataGridView

            // Populate DataGridView with user data
            foreach (var user in users)
            {
                int rowIndex = dgvUserList.Rows.Add(); // Add a new row to the DataGridView
                DataGridViewRow row = dgvUserList.Rows[rowIndex];

                // Set the values in the row for each column
                row.Cells["colName"].Value = $"{user.FirstName} {user.LastName}";
                row.Cells["colStatus"].Value = $"{user.Status}";
                row.Cells["colView"].Value = "View"; // You can handle "Edit" logic separately
                dgvUserList.Columns["colView"].DefaultCellStyle.BackColor = Color.LightBlue;
                dgvUserList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

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
        public void UserEvaluation_Load(object sender, EventArgs e)
        {
            LoadUsers(); // Call LoadUsers method when the control is loaded
           

            
        }
    }
}
