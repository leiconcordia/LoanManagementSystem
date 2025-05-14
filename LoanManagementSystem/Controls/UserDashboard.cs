using System;
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
            // Clear existing columns if any
            dgvUserLoans.Columns.Clear();

            DatabaseHelper DB = new DatabaseHelper();

            // Set your data source (after fetching from DB)
            dgvUserLoans.DataSource = DB.GetActiveLoansByUser(userID);

            // Then hide the LoanID column
            if (dgvUserLoans.Columns.Contains("LoanID"))
            {
                dgvUserLoans.Columns["LoanID"].Visible = false;
            }

            // Add a View Details button column
            DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn();
            viewButton.Name = "ViewDetails";
            viewButton.HeaderText = "Action";
            viewButton.Text = "View";
            viewButton.UseColumnTextForButtonValue = true;
            dgvUserLoans.Columns.Add(viewButton);





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

                if (dgvUserLoans.Columns[e.ColumnIndex].Name == "ViewDetails")
                {
                    int loanId = Convert.ToInt32(dgvUserLoans.Rows[e.RowIndex].Cells["LoanID"].Value);
                    DatabaseHelper dbHelper = new DatabaseHelper();
                    DataTable dt = dbHelper.GetPaymentHistoryByLoanId(loanId);
                    dgvUserLoans.DataSource = dt;
                    dgvUserLoans.AutoGenerateColumns = true;

                }
            }

        }

        private void btnBacktoUserLoanTable_Click(object sender, EventArgs e)
        {
            LoadUserLoans();
            SetupUserLoanGrid();
        }
    }
}