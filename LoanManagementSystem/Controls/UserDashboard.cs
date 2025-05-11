using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
