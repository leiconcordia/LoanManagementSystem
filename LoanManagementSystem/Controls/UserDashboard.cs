using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserStatus.Text = "Status: " + status;
            lblUserStatus.Font = new Font("Segoe UI", 10F);
            lblUserCredit.Text = "Credit Score: " + db.GetUserCreditBalance(userID).ToString("N0");
            lblUserCredit.Font = new Font("Segoe UI", 10F);

            switch (status.ToLower())
            {
                case "pending":
                    lblStatusDesc.Text = "Your loan application is under review. Please wait for admin approval.";
                    lblUserStatus.ForeColor = Color.Goldenrod;
                    btnApplyLoan.Visible = false;
                    break;
                case "rejected":
                    lblStatusDesc.Text = "Unfortunately, you are not eligible for a loan at this time.";
                    lblUserStatus.ForeColor = Color.Red;
                    btnApplyLoan.Visible = false;
                    break;
                case "approved":
                    lblStatusDesc.Text = "You are eligible to apply for a loan. Please proceed with your application.";
                    lblUserStatus.ForeColor = Color.Green;
                    btnApplyLoan.Visible = true;
                    break;
                default:
                    lblStatusDesc.Text = "Loan status not recognized. Please contact support.";
                    lblUserStatus.ForeColor = Color.Gray;
                    break;
            }
        }

        private void btnApplyLoan_Click(object sender, EventArgs e)
        {
            parentForm.UserPanel.Controls.Clear();
            LoanApplicationForm loanForm = new LoanApplicationForm(parentForm.UserID, parentForm)
            {
                Dock = DockStyle.Fill
            };
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
            DataTable loans = db.GetActiveLoansByUser(userID);
            dgvUserLoans.DataSource = loans;
        }

        private void SetupUserLoanGrid()
        {
            dgvUserLoans.Columns.Clear();

            DatabaseHelper DB = new DatabaseHelper();
            dgvUserLoans.DataSource = DB.GetActiveLoansByUser(userID);

            dgvUserLoans.EnableHeadersVisualStyles = false;
            dgvUserLoans.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvUserLoans.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUserLoans.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvUserLoans.RowTemplate.Height = 30;
            dgvUserLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvUserLoans.Columns.Contains("LoanID"))
                dgvUserLoans.Columns["LoanID"].Visible = false;

            DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn
            {
                Name = "ViewDetails",
                HeaderText = "Action",
                Text = "View",
                UseColumnTextForButtonValue = true
            };
            dgvUserLoans.Columns.Add(viewButton);

            DataGridViewButtonColumn payButton = new DataGridViewButtonColumn
            {
                Name = "Pay",
                HeaderText = "",
                Text = "Pay",
                UseColumnTextForButtonValue = true
            };
            dgvUserLoans.Columns.Add(payButton);
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            LoadUserLoans();
            SetupUserLoanGrid();
        }

        private void dgvUserLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = dgvUserLoans.Columns[e.ColumnIndex].Name;

            int loanId = Convert.ToInt32(dgvUserLoans.Rows[e.RowIndex].Cells["LoanID"].Value);

            if (columnName == "ViewDetails")
            {
                PaymentHistory historyForm = new PaymentHistory(loanId);
                historyForm.ShowDialog();
            }
            else if (columnName == "Pay")
            {
                decimal monthlyPayment = Convert.ToDecimal(dgvUserLoans.Rows[e.RowIndex].Cells["Monthly Payment"].Value);
                DatabaseHelper db = new DatabaseHelper();
                decimal creditBalance = db.GetUserCreditBalance(userID);

                string message =
                    $"Monthly Payment: ₱{monthlyPayment:N2}\n\nDo you want to proceed with this payment?";

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
                        SetupUserLoanGrid();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while processing the payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
