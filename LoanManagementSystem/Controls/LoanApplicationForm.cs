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




namespace LoanManagementSystem.Controls
{
    public partial class LoanApplicationForm : UserControl
    {
        private int _userID;

        private UserForm _parentForm;
        private DatabaseHelper _dbHelper; // Renamed field to avoid ambiguity

        public LoanApplicationForm(int userID, UserForm parentForm)
        {
            InitializeComponent();
            this._userID = userID;
            _parentForm = parentForm;

            _dbHelper = new DatabaseHelper();
        }

        public string LoanAmount { get; set; }
        public string LoanTerm { get; set; }
        public string LoanPurpose { get; set; }
        public DateTime PreferredPaymentDate { get; set; }
        public Image ProofOfIncome { get; set; }
        public Image ValidID { get; set; }
        public object LoanApplicationPanel { get; private set; }

        private Image _selectedValidIdImage;
        private Image _selectedProofImage;

        private void BtnNext_Click(object sender, EventArgs e)
{
    if (!SaveImages()) // This ensures both images are checked and saved first
    {
        return; // Stop here if images are missing or saving failed
    }

    if (TryCalculateMonthlyPayment(out decimal monthly, out decimal totalInterest, out decimal newBalance, out string displayMessage))
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
            SubmitLoanApplication(); // only reaches here if images are saved
        }
    }
    else
    {
        MessageBox.Show(displayMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}



        // Removed duplicate method definition
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!SaveImages()) // This ensures both images are checked and saved first
            {
                return; // Stop here if images are missing or saving failed
            }

            if (TryCalculateMonthlyPayment(out decimal monthly, out decimal totalInterest, out decimal newBalance, out string displayMessage))
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
                    SubmitLoanApplication(); // only reaches here if images are saved
                }
            }
            else
            {
                MessageBox.Show(displayMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private bool TryCalculateMonthlyPayment(out decimal monthlyPayment, out decimal Interest, out decimal newBalance, out string message)
        {
            monthlyPayment = 0;
            Interest = 0;
            newBalance = 0;
            message = "";

            if (!decimal.TryParse(tbLoanAmount.Text.Trim(), out decimal loanAmount) || loanAmount < 1000)
            {
                message = "Loan amount must be at least ₱1000 and a valid number.";
                return false;
            }

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

            // Amortization logic
            decimal annualInterestRate = 0.10m; // 10%
            decimal monthlyInterestRate = annualInterestRate / 12;

            if (monthlyInterestRate == 0)
            {
                monthlyPayment = loanAmount / months;
            }
            else
            {
                double P = (double)loanAmount;
                double r = (double)monthlyInterestRate;
                int n = months;

                monthlyPayment = (decimal)(P * r * Math.Pow(1 + r, n) / (Math.Pow(1 + r, n) - 1));
                Interest = (monthlyPayment * months) - loanAmount;
            }

            newBalance = loanAmount + Interest;

          
            message = $"You will pay ₱{monthlyPayment:F2} for {months} months.";

            return true;
        }



        private void btnUploadID_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select Valid ID";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _selectedValidIdImage = Image.FromFile(openFileDialog.FileName);
                        pbID.Image = _selectedValidIdImage;

                        // Optional: Show success message
                        lblIDStatus.Text = "ID uploaded successfully!";
                        lblIDStatus.ForeColor = Color.Green;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUploadProof_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select Proof of Income";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _selectedProofImage = Image.FromFile(openFileDialog.FileName);
                        pbProof.Image = _selectedProofImage;

                        // Optional: Show success message
                        lblProofStatus.Text = "Proof uploaded successfully!";
                        lblProofStatus.ForeColor = Color.Green;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool SaveImages()
        {
            if (_selectedValidIdImage == null || _selectedProofImage == null)
            {
                MessageBox.Show("Please upload both ID and Proof of Income", "Warning",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // <-- must return false here
            }

            if (_userID <= 0)
            {
                MessageBox.Show("No user selected", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // <-- also must return false here
            }

            bool success = _dbHelper.SaveUserImages(_userID, _selectedValidIdImage, _selectedProofImage);

            if (success)
            {
                
                return true;
            }
            else
            {
             
                return false;
            }
        }

        



        private void SubmitLoanApplication()
        {
           
            string loanPurpose = cbLoanPurpose.SelectedItem != null ? cbLoanPurpose.SelectedItem.ToString() : "";
            string loanTerm = cbLoanTerm.SelectedItem != null ? cbLoanTerm.SelectedItem.ToString() : "";
            decimal loanAmount = 0;

            if (!decimal.TryParse(tbLoanAmount.Text, out loanAmount))
            {
                MessageBox.Show("Invalid loan amount. Please enter a valid number.");
                return;
            }

            if (string.IsNullOrEmpty(loanPurpose) || string.IsNullOrEmpty(loanTerm))
            {
                MessageBox.Show("Please select both Loan Purpose and Loan Term.");
                return;
            }

            int months = ExtractMonthsFromTerm(loanTerm);
            if (months <= 0)
            {
                MessageBox.Show("Invalid loan term selected.");
                return;
            }

            TryCalculateMonthlyPayment(out decimal monthlyPayment, out decimal Interest, out decimal NewBalance, out string message);



            DatabaseHelper db = new DatabaseHelper();
            

            bool success = db.InsertLoan(_userID, loanAmount, months, loanPurpose, monthlyPayment, NewBalance, Interest);



            if (success)

            {
                MessageBox.Show("Loan application submitted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to submit loan application. Please try again.");
            }
        }


        private void btnBacktoDashboard_Click(object sender, EventArgs e)
        {
            // Updated constructor call to include the required 'parent' parameter
            var dashboard = new UserDashboard(_parentForm.FullName, _parentForm.Status, _parentForm.UserID, _parentForm);
            dashboard.Dock = DockStyle.Fill;

            _parentForm.UserPanel.Controls.Clear();
            _parentForm.UserPanel.Controls.Add(dashboard);
        }




    }





    //DateTime paymentDate = dtPaymentDate.Value;
    //string loanPurpose = cbLoanPurpose.SelectedItem.ToString() : "";
    //string loanTerm =  cbLoanTerm.SelectedItem.ToString() : "";
    //decimal loanAmount = 0;


}

