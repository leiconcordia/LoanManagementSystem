﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoanManagementSystem.DatabaseHelper;

namespace LoanManagementSystem.Controls
{
    public partial class LoanDetails : UserControl
    {
        private int LoanID;



        public LoanDetails(int LoanID)
        {
            InitializeComponent();
            this.LoanID = LoanID;
            this.Load += LoanDetails_Load;
            // This line should be in your constructor or `InitializeComponent()`



        }


        private void DisplayLoanDetails(int loanId)
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable loanDetails = db.GetLoanDetailsByLoanId(loanId);  // Now get details based on LoanID

            if (loanDetails != null && loanDetails.Rows.Count > 0)
            {
                DataRow loan = loanDetails.Rows[0]; // Only one row should match
                lblLoanee.Text = loan["Loanee"].ToString();
                lblAmount.Text = loan["Loan_Amount"].ToString();
                lblTerm.Text = loan["Term"].ToString();
                lblLoanPurpose.Text = loan["LoanPurpose"].ToString();
                lblStatus.Text = loan["Status"].ToString();
                string status = loan["Status"].ToString();
                // ✅ Call the visibility handler
                UpdateButtonVisibility(status);


            }
            else
            {
                MessageBox.Show("No loan details found for this loan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Make sure the userId is passed to the constructor properly
        private void LoanDetails_Load(object sender, EventArgs e)
        {

            // Display loan details for the current user
            DisplayLoanDetails(LoanID);  // Make sure userId is available and passed correctly to this method

        }






        private void btnApprove_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            if (db.UpdateLoanStatus(LoanID, "Approved"))
            {
                MessageBox.Show("Loan approved successfully!");

                DisplayLoanDetails(LoanID);
                
            }
            else
            {
                MessageBox.Show("Failed to approve loan.");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            if (db.UpdateLoanStatus(LoanID, "Rejected"))
            {
                MessageBox.Show("Loan rejected.");
                DisplayLoanDetails(LoanID);

            }
            else
            {
                MessageBox.Show("Failed to reject loan.");
            }
            
        }

        private void UpdateButtonVisibility(string status)
        {
            string cleanStatus = status?.Trim().ToLower(); // Normalize the input

            if (cleanStatus == "approved")
            {
                btnApprove.Visible = false;
                btnReject.Visible = false;
                btnDisburse.Visible = true;
            }
            else if (cleanStatus == "disbursed")
            {
                btnApprove.Visible = false;
                btnReject.Visible = false;
                btnDisburse.Visible = false;
            }
            else
            {
                btnApprove.Visible = true;
                btnReject.Visible = true;
                btnDisburse.Visible = false;
            }
        }

        private void btnDisburse_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(lblAmount.Text, out decimal amount))
            {
                MessageBox.Show("Invalid loan amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string loaneeName = lblLoanee.Text; // Assuming this is already set
            string message = $"Are you sure you want to disburse ₱{amount:N2} to {loaneeName}?";

            DialogResult result = MessageBox.Show(
                message,
                "Confirm Disbursement",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return; // User cancelled
            }

            DatabaseHelper db = new DatabaseHelper();
            bool success = db.InsertDisbursement(LoanID, amount); // Insert disbursement into the database

            if (success)
            {
                // Update loan status to "Disbursed"
                bool statusUpdated = db.UpdateLoanStatus(LoanID, "Disbursed");

                if (statusUpdated)
                {
                    MessageBox.Show("Loan successfully disbursed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDisburse.Enabled = false;
                    btnDisburse.Text = "Disbursed";
                    lblStatus.Text = "Disbursed";
                }
                else
                {
                    MessageBox.Show("Failed to update loan status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Disbursement failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBacktoLoan_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.ParentForm;
            if (mainForm != null)
            {
                mainForm.switchUserControl(new Loans());
                
            }
            else
            {
                MessageBox.Show("Parent form not found.");
            }
        }

    }
}



