using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoanManagementSystem.DatabaseHelper;

namespace LoanManagementSystem.Controls
{

    public partial class UserInfo : UserControl
    {
        private readonly DatabaseHelper _dbHelper;
        private string _userId;

        public UserInfo()
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper(); // Initialize your database helper
           
        }

        public UserInfo(string userId) : this()
        {
            _userId = userId;
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                // Get user data from database
                var user = _dbHelper.GetUserById(_userId);

                if (user != null)
                {
                    // Display user information in the labels
                    userInfoFname.Text = user.FirstName ?? "Not provided";
                    userInfoLname.Text = user.LastName ?? "Not provided";
                    userInfoDbirth.Text = user.DateOfBirth?.ToString("yyyy-MM-dd") ?? "Not provided";
                    userInfoAddress.Text = user.Address ?? "Not provided";
                    userInfoPnumber.Text = user.PhoneNumber ?? "Not provided";
                    userInfoEstatus.Text = user.EmploymentStatus ?? "Not provided";
                    userInfoMincome.Text = user.MonthlyIncome?.ToString("C") ?? "Not provided";
                    userInfoStatus.Text = user.Status ?? "Not provided";

                    // Corrected line: Pass the user's status directly to the method
                    UpdateStatusDisplay(user.Status);

                    // Configure buttons based on current status
                    UpdateButtonStates(user.Status);
                }
                else
                {
                    MessageBox.Show($"User with ID {_userId} not found", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateStatusDisplay(string status)
        {
            userInfoStatus.Text = status;

            // Color coding based on status
            switch (status?.ToLower())
            {
                case "approved":
                    userInfoStatus.ForeColor = Color.Green;
                    break;
                case "pending":
                    userInfoStatus.ForeColor = Color.Orange;
                    break;
                case "rejected":
                    userInfoStatus.ForeColor = Color.Red;
                    break;
                default:
                    userInfoStatus.ForeColor = SystemColors.ControlText;
                    break;
            }
        }

        private void UpdateButtonStates(string currentStatus)
        {
            bool isPending = currentStatus?.ToLower() == "pending";

            // Option 1: Simply hide/show
            btnApproveStatus.Visible = isPending;
            btnRejectStatus.Visible = isPending;

            // Option 2: Hide and collapse layout
            if (isPending)
            {
                btnApproveStatus.Show();
                btnRejectStatus.Show();
               
            }
            else
            {
                btnApproveStatus.Hide();
                btnRejectStatus.Hide();
                
            }

            // Option 3: Fancy animation (requires additional controls)
            // AnimateButtonVisibility(isPending);
        }

        public void btnApproveStatus_Click(object sender, EventArgs e)
        {
            UpdateUserStatus("Approved");
        }
            

        private void btnRejectStatus_Click(object sender, EventArgs e)
        {
            UpdateUserStatus("Rejected");
        }

        private void UpdateUserStatus(string newStatus)
        {
            try
            {
                string action = newStatus == "Approved" ? "approve" : "reject";

                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to {action} this client?",
                    $"Confirm {newStatus}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    bool success = _dbHelper.UpdateUserStatus(_userId, newStatus);

                    if (success)
                    {
                        // Update UI
                        UpdateStatusDisplay(newStatus);
                        UpdateButtonStates(newStatus);

                        MessageBox.Show(
                            $"Client {newStatus.ToLower()} successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Failed to update status in database",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error updating status: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


     
    }
}