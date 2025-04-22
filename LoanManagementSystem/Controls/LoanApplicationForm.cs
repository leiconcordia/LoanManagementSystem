using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManagementSystem.Controls
{
    public partial class LoanApplicationForm : UserControl
    {
        
        public LoanApplicationForm()
        {
            InitializeComponent();
        }

        public string LoanAmount { get; set; }
        public string LoanTerm { get; set; }
        public string LoanPurpose { get; set; }
        public DateTime PreferredPaymentDate { get; set; }
        public Image ProofOfIncome { get; set; }
        public Image ValidID { get; set; }
        public object LoanApplicationPanel { get; private set; }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (TryCalculateMonthlyPayment(out decimal monthly, out string displayMessage))
            {
                // Show confirmation message box
                DialogResult result = MessageBox.Show(
                    displayMessage + "\n\nDo you want to proceed?",
                    "Confirm Loan Application",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                   
                }
                // If No, do nothing (stay on the current form)
            }
            else
            {
                MessageBox.Show(displayMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private int ExtractMonthsFromTerm(string term)
        {
            if (term.Contains("3 months")) return 3;
            if (term.Contains("6 months")) return 6;
            if (term.Contains("9 months")) return 9;
            if (term.Contains("1 year")) return 12;
            if (term.Contains("2 years")) return 24;
            if (term.Contains("3 years")) return 36;

            return 0;
        }

        private bool TryCalculateMonthlyPayment(out decimal monthlyPayment, out string message)
        {
            monthlyPayment = 0;
            message = "";

            // Validate Loan Amount
            if (!decimal.TryParse(tbLoanAmount.Text.Trim(), out decimal loanAmount) || loanAmount < 1000)
            {
                message = "Loan amount must be at least ₱1000 and a valid number.";
                return false;
            }

            // Validate Loan Term
            if (cbLoanTerm.SelectedItem == null)
            {
                message = "Please select a loan term.";
                return false;
            }

            string termText = cbLoanTerm.SelectedItem.ToString();
            int months = ExtractMonthsFromTerm(termText);
            if (months <= 0)
            {
                message = "Invalid loan term.";
                return false;
            }

            // Interest calculation: 10% of loan amount
            decimal interest = loanAmount * 0.10m;
            decimal totalAmount = loanAmount + interest;

            monthlyPayment = totalAmount / months;

            // Format the output message
            string date = dateTimePicker1.Value.ToString("dd"); // e.g., April 15
            message = $"You will pay ₱{monthlyPayment:F2} every {date}of the month for {months} months.";

            return true;
        }



        //LoanAmount = tbLoanAmount.Text.Trim(),
        //LoanTerm = cbLoanTerm.SelectedItem?.ToString(),
        //LoanPurpose = cbLoanPurpose.SelectedItem?.ToString(),
        //PreferredPaymentDate = dateTimePicker1.Value,
        //ProofOfIncome = pbProof.Image,
        //ValidID = pbID.Image
    }
}
