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
        private FlowLayoutPanel breadcrumbPanel;
        private LinkLabel linkEvaluation;
        private Label lblSeparator;
        private Label lblCurrentPage;

        private void LinkEvaluation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                UserEvaluation userEvaluationControl = new UserEvaluation();
                mainForm.switchUserControl(userEvaluationControl);
            }
        }

        public UserInfo()
        {
            InitializeComponent();
            
            _dbHelper = new DatabaseHelper(); // Initialize your database helper
            breadcrumbPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10, 10, 0, 10),
                BackColor = Color.Transparent
            };

            linkEvaluation = new LinkLabel
            {
                Text = "User Evaluation",
                AutoSize = true,

                LinkColor = Color.LightBlue,
                Font = new Font("Segoe UI", 10, FontStyle.Underline),
                Cursor = Cursors.Hand
            };

            linkEvaluation.LinkClicked += LinkEvaluation_LinkClicked;

            lblSeparator = new Label
            {
                Text = " > ",
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White
            };

            lblCurrentPage = new Label
            {
                Text = "Client Information",
                AutoSize = true,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.LightBlue
            };



            breadcrumbPanel.Controls.Add(linkEvaluation);
            breadcrumbPanel.Controls.Add(lblSeparator);
            breadcrumbPanel.Controls.Add(lblCurrentPage);
            this.Controls.Add(breadcrumbPanel);
            breadcrumbPanel.BringToFront();
        }

        public UserInfo(string userId) : this()
        {
            _userId = userId;
            LoadUserData();
            UpdateUserStatusButtons();
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

        private void UpdateUserStatusButtons()
        {
            int convertedId = int.Parse(_userId);
            string status = _dbHelper.GetUserStatus(convertedId); // Use the class field

            bool isPending = string.Equals(status, "pending", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(isPending);
            btnApprove.Visible = isPending;
            btnReject.Visible = isPending;
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
                        
                        MessageBox.Show(
                            $"Client {newStatus.ToLower()} successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Log activity with user name
                        var userObj = _dbHelper.GetUserById(_userId);
                        string logMessage = $"User {newStatus}: ({userObj.FirstName} {userObj.LastName})";
                        _dbHelper.LogActivity($"User {newStatus}", logMessage);
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

        private void btnBacktoUserEval_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.ParentForm;
            if (mainForm != null)
            {
                mainForm.switchUserControl(new UserEvaluation());

            }
            else
            {
                MessageBox.Show("Parent form not found.");
            }
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            
            UpdateUserStatus("Rejected");
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            UpdateUserStatus("Approved");
        }

        private void userInfoEstatus_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}