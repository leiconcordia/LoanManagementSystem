using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private FlowLayoutPanel breadcrumbPanel;
        private LinkLabel linkLoanList;
        private Label lblSeparator;
        private Label lblCurrentPage;
        private void LinkLoanList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                Loans loanList = new Loans();
                mainForm.switchUserControl(loanList);
            }
        }

        public LoanDetails(int LoanID)
        {
            InitializeComponent();

            // Breadcrumb setup
            breadcrumbPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10, 10, 0, 10),
                BackColor = Color.Transparent
            };

            linkLoanList = new LinkLabel
            {
                Text = "Loans List",
                AutoSize = true,

                LinkColor = Color.LightBlue,
                Font = new Font("Segoe UI", 10, FontStyle.Underline),
                Cursor = Cursors.Hand
            };

            linkLoanList.LinkClicked += LinkLoanList_LinkClicked;

            lblSeparator = new Label
            {
                Text = " > ",
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White
            };

            lblCurrentPage = new Label
            {
                Text = "Loan Details",
                AutoSize = true,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.LightBlue
            };



            breadcrumbPanel.Controls.Add(linkLoanList);
            breadcrumbPanel.Controls.Add(lblSeparator);
            breadcrumbPanel.Controls.Add(lblCurrentPage);
            this.Controls.Add(breadcrumbPanel);
            breadcrumbPanel.BringToFront();
            this.LoanID = LoanID;
            this.Load += LoanDetails_Load;
            // This line should be in your constructor or InitializeComponent()



        }


        private void DisplayLoanDetails(int loanId)
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable loanDetails = db.GetLoanDetailsByLoanId(loanId);

            if (loanDetails != null && loanDetails.Rows.Count > 0)
            {
                DataRow loan = loanDetails.Rows[0];

                lblLoanee.Text = loan["Loanee"].ToString();
                lblAmount.Text = loan["Loan_Amount"].ToString();
                lblTerm.Text = loan["Term"].ToString();
                lblLoanPurpose.Text = loan["LoanPurpose"].ToString();
                lblStatus.Text = loan["Status"].ToString();

                // ✅ Get UserID from LoanID
                int userId = db.GetUserIdByLoanId(loanId);

                // ✅ Get count of 'Disbursed' loans for this user
                int disbursedLoanCount = db.GetDisbursedLoanCountByUserId(userId);

                // ✅ Set label
                lblActiveLoans.Text = disbursedLoanCount.ToString();

                string status = loan["Status"].ToString();
                UpdateButtonVisibility(status);
                // ✅ Load images
                if (loan["ValidID"] != DBNull.Value)
                {
                    byte[] validIdBytes = (byte[])loan["ValidID"];
                    using (MemoryStream ms = new MemoryStream(validIdBytes))
                    {
                        pbValidID.Image = Image.FromStream(ms);
                    }
                }

                if (loan["ProofOfIncome"] != DBNull.Value)
                {
                    byte[] proofBytes = (byte[])loan["ProofOfIncome"];
                    using (MemoryStream ms = new MemoryStream(proofBytes))
                    {
                        pbProof.Image = Image.FromStream(ms);
                    }
                }
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

                string loaneeNameFromLabel = lblLoanee.Text; // Get the loanee's name from the label
                string logMessage = $"approved loan for '{loaneeNameFromLabel}')";
                db.LogActivity($"Loan Approved", logMessage);
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

                string loaneeNameFromLabel = lblLoanee.Text; // Get the loanee's name from the label
                string logMessage = $"rejected loan for '{loaneeNameFromLabel}')";
                db.LogActivity($"Loan rejected", logMessage);
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

            string loaneeNameFromLabel = lblLoanee.Text; // Assuming this is already set
            string message = $"Are you sure you want to disburse ₱{amount:N2} to {loaneeNameFromLabel}?";

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

                    string logMessage = $"disbursed loan for '{loaneeNameFromLabel}' amount '{amount}')"; // Corrected log message
                    db.LogActivity($"Loan Disbursed", logMessage);
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

        private void LoanDetails_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
