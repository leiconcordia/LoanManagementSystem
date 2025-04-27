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
        private int _userID;

        private DatabaseHelper _dbHelper; // Renamed field to avoid ambiguity

        public LoanApplicationForm(int userID)
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper(); // Updated to use the renamed field
            _userID = userID;
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
                    SaveImages();
                    SubmitLoanApplication();
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
            string date = dtPaymentDate.Value.ToString("dd"); // e.g., April 15
            message = $"You will pay ₱{monthlyPayment:F2} every {date} of the month for {months} months.";

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

        private void SaveImages()
        {
            if (_selectedValidIdImage == null || _selectedProofImage == null)
            {
                MessageBox.Show("Please upload both ID and Proof of Income", "Warning",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_userID <= 0)
            {
                MessageBox.Show("No user selected", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = _dbHelper.SaveUserImages(_userID, _selectedValidIdImage, _selectedProofImage);

            if (success)
            {
                MessageBox.Show("Images saved successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save images", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SubmitLoanApplication()
        {
            DateTime paymentDate = dtPaymentDate.Value;
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

            // Now call DatabaseHelper to insert the loan
            DatabaseHelper db = new DatabaseHelper();
            bool success = db.InsertLoan(_userID, loanAmount, loanTerm, loanPurpose, paymentDate);

            if (success)
            {
                MessageBox.Show("Loan application submitted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to submit loan application. Please try again.");
            }
        }

    }




    //DateTime paymentDate = dtPaymentDate.Value;
    //string loanPurpose = cbLoanPurpose.SelectedItem.ToString() : "";
    //string loanTerm =  cbLoanTerm.SelectedItem.ToString() : "";
    //decimal loanAmount = 0;


}

