using LoanManagementSystem.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoanManagementSystem.DatabaseHelper;

namespace LoanManagementSystem
{
    public partial class UserForm : Form
    {

        private int userID;

        public UserForm()
        {
            InitializeComponent();
            

           

        }
        public UserForm(string fullName, string status, int userID)
        {
           

            InitializeComponent();
            this.userID = userID;

            lblUsername.Text = "Welcome! " + fullName;
            lblUserStatus.Text = "Status: " + status;

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
            LoanApplicationPanel.Controls.Clear();

            LoanApplicationForm loanForm = new LoanApplicationForm(this.userID); 
            loanForm.Dock = DockStyle.Fill;
            LoanApplicationPanel.Controls.Add(loanForm);
           
        }





    }
}
