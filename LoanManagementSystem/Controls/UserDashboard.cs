﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LoanManagementSystem.Controls
{
    public partial class UserDashboard : UserControl
    {

        private int userID;

        private UserForm parentForm;
        public UserDashboard(string fullName, string status, int userID, UserForm parent)
        {
            InitializeComponent();

            this.userID = userID;
            this.parentForm = parent;

            DatabaseHelper db = new DatabaseHelper();



            lblUsername.Text = "Welcome! " + fullName;
            lblUserStatus.Text = "Status: " + status;
            lblUserCredit.Text = "Credit Score: " + db.GetUserCreditBalance(userID).ToString();

            // Show description based on status
            if (status.ToLower() == "pending")
            {
                lblStatusDesc.Text = "Your loan application is under review. Please wait for admin approval.";
                btnApplyLoan.Visible = false;
            }
            else if (status.ToLower() == "rejected")
            {
                lblStatusDesc.Text = "Unfortunately, you are not eligible for a loan at this time.";
                btnApplyLoan.Visible = false;
            }
            else if (status.ToLower() == "approved")
            {

                lblStatusDesc.Text = "You are eligible to apply for a loan. Please proceed with your application.";
                btnApplyLoan.Visible = true;
            }

            else
            {
                lblStatusDesc.Text = "Loan status not recognized. Please contact support.";
            }
        }



        private void btnApplyLoan_Click(object sender, EventArgs e)
        {
            parentForm.UserPanel.Controls.Clear();

            LoanApplicationForm loanForm = new LoanApplicationForm(parentForm.UserID, parentForm);
            loanForm.Dock = DockStyle.Fill;

            parentForm.UserPanel.Controls.Add(loanForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            parentForm.Hide();
            Login login = new Login();
            login.Show();
        }


        private void LoadUserLoans()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable loans = db.GetActiveLoansByUser(userID); // use your logged-in user's ID
            dgvUserLoans.DataSource = loans;

            // Optional: Add buttons to the Action column
            foreach (DataGridViewRow row in dgvUserLoans.Rows)
            {

                DataGridViewButtonCell viewButton = new DataGridViewButtonCell();
                viewButton.Value = "View";

            }
        }

        private void SetupUserLoanGrid()
        {
            dgvUserLoans.Columns.Clear();

            DatabaseHelper DB = new DatabaseHelper();
            dgvUserLoans.DataSource = DB.GetActiveLoansByUser(userID);

            // Hide LoanID for privacy
            if (dgvUserLoans.Columns.Contains("LoanID"))
                dgvUserLoans.Columns["LoanID"].Visible = false;

            // 🔘 1st Action button: View (with "Action" header)
            DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn();
            viewButton.Name = "ViewDetails";
            viewButton.HeaderText = "Action";
            viewButton.Text = "View";
            viewButton.UseColumnTextForButtonValue = true;
            dgvUserLoans.Columns.Add(viewButton);

            // 💸 2nd button: Pay (no header)
            DataGridViewButtonColumn payButton = new DataGridViewButtonColumn();
            payButton.Name = "Pay";
            payButton.HeaderText = ""; // No header
            payButton.Text = "Pay";
            payButton.UseColumnTextForButtonValue = true;
            dgvUserLoans.Columns.Add(payButton);
        }



        private void UserDashboard_Load(object sender, EventArgs e)
        {
            LoadUserLoans();
            SetupUserLoanGrid();


        }



        private void dgvUserLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvUserLoans.Columns[e.ColumnIndex].Name;

                if (columnName == "ViewDetails")
                {
                    int loanId = Convert.ToInt32(dgvUserLoans.Rows[e.RowIndex].Cells["LoanID"].Value);
                    PaymentHistory historyForm = new PaymentHistory(loanId);
                    historyForm.ShowDialog();

                    

                }
                else if (columnName == "Pay")
                {
                    int loanId = Convert.ToInt32(dgvUserLoans.Rows[e.RowIndex].Cells["LoanID"].Value);
                    decimal monthlyPayment = Convert.ToDecimal(dgvUserLoans.Rows[e.RowIndex].Cells["Monthly Payment"].Value);
                    //decimal balance = Convert.ToDecimal(dgvUserLoans.Rows[e.RowIndex].Cells["Balance"].Value);
                    DatabaseHelper db = new DatabaseHelper();
                    decimal creditBalance = db.GetUserCreditBalance(userID);

                    string message = 
                                     $"Monthly Payment: ₱{monthlyPayment:N2}\n" +
                                     $"\n" +
                                     $"\n" +

                                     "Do you want to proceed with this payment?";

                    DialogResult result = MessageBox.Show(message, "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {


                        if (creditBalance < monthlyPayment)
                        {
                            MessageBox.Show("Insufficient credit balance to make this payment.", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        bool paymentSuccess = db.AddPaymentAndUpdateLoan(userID, loanId, monthlyPayment);
                        if (paymentSuccess)
                        {
                            MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Refresh the table or UI here if needed
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while processing the payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        
                    }
                }

            }
        }





        private void btnBacktoUserLoanTable_Click(object sender, EventArgs e)
        {
            LoadUserLoans();
            
        }
    }
}