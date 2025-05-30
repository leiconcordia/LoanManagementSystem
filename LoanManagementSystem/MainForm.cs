using LoanManagementSystem.Controls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LoanManagementSystem
{
    public partial class MainForm : Form
    {
        Controls.UserEvaluation UserEvaluation = new Controls.UserEvaluation();
        Controls.Loans Loans = new Controls.Loans();
        Controls.Disbursements Disbursements = new Controls.Disbursements();
        Controls.AdminDashboard ad = new Controls.AdminDashboard();

        public MainForm()
        {
            InitializeComponent();

            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            switchUserControl(ad);


        }


        private void panel5_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void switchUserControl(UserControl userControl)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            if (userControl is Loans L)
            {
                L.LoadLoanData();
            }

            if (userControl is UserEvaluation ue)
            {
                ue.LoadUsers();

            }
            if (userControl is Disbursements d)
            {
                d.LoadDisbursementData();
            }
            if (userControl is AdminDashboard ad)
            {
                
                ad.LoadRecentActivity();
                ad.LoadActiveLoanCount();
                ad.LoadPendingLoans();
                ad.LoadDisbursedAmount();
                ad.LoadAdminBalance();

            }

        }   

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            switchUserControl(ad);
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnUserEvaluation_Click(object sender, EventArgs e)
        {
           pnlNav.Height = btnUserEvaluation.Height;
           pnlNav.Top = btnUserEvaluation.Top;
           btnUserEvaluation.BackColor = Color.FromArgb(46, 51, 73);

            //function
            //MainPanel.Controls.Clear();
            //MainPanel.Controls.Add(UserEvaluation);
            //MainPanel.Controls.Clear();
            //UserEvaluation.Dock = DockStyle.Fill;
            
            switchUserControl(UserEvaluation);

        }

       

        private void btnLoan_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLoan.Height;
            pnlNav.Top = btnLoan.Top;
            btnLoan.BackColor = Color.FromArgb(46, 51, 73);


           

            switchUserControl(Loans);




        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDisbursements_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDisbursements.Height;
            pnlNav.Top = btnDisbursements.Top;
            btnDisbursements.BackColor = Color.FromArgb(46, 51, 73);

            switchUserControl(Disbursements);



        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnLogout.Height;
            pnlNav.Top = btnLogout.Top;
            btnLogout.BackColor = Color.FromArgb(46, 51, 73);
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnUserEvaluation_Leave(object sender, EventArgs e)
        {
            btnUserEvaluation.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLoan_Leave(object sender, EventArgs e)
        {
            btnLoan.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnDisbursements_Leave(object sender, EventArgs e)
        {
            btnDisbursements.BackColor = Color.FromArgb(24, 30, 54);
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
           //pang full screen
           // this.WindowState = FormWindowState.Maximized;
        }

        private string ShowInputDialog(string title, string prompt)
        {
            Form inputForm = new Form();
            inputForm.Width = 400;
            inputForm.Height = 150;
            inputForm.Text = title;
            inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputForm.StartPosition = FormStartPosition.CenterParent;
            inputForm.MinimizeBox = false;
            inputForm.MaximizeBox = false;

            Label textLabel = new Label() { Left = 20, Top = 20, Text = prompt, Width = 340 };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340 };

            Button confirmation = new Button() { Text = "OK", Left = 280, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            inputForm.AcceptButton = confirmation;

            // Hook KeyPress and Leave events
            textBox.KeyPress += (sender, e) =>
            {
                // Allow digits and control characters (e.g., Backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (decimal.TryParse(textBox.Text.Trim(), out decimal val))
                {
                    if (val >= 0 && val <= 100)
                    {
                        textBox.Text = $"{val}%";
                    }
                    else
                    {
                        MessageBox.Show("Please enter a value between 0 and 100.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter numeric value only.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            };

            inputForm.Controls.Add(textLabel);
            inputForm.Controls.Add(textBox);
            inputForm.Controls.Add(confirmation);

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                return textBox.Text.Replace("%", "").Trim(); // Return only the numeric value
            }

            return null;
        }



      




        private void btnChangeInterest_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            // Get current interest rate and show it as default input
            decimal currentRate = db.GetCurrentInterestRate();
            string input = ShowInputDialog("Change Interest Rate", $"Enter new interest rate (current: {currentRate:P0}):");

            pnlNav.Height = btnChangeInterest.Height;
            pnlNav.Top = btnLoan.Top;
            btnChangeInterest.BackColor = Color.FromArgb(46, 51, 73);

            if (!string.IsNullOrWhiteSpace(input) && decimal.TryParse(input, out decimal percentage))
            {
                if (percentage >= 0 && percentage <= 100)
                {
                    decimal decimalRate = percentage / 100m;  // Convert 20 → 0.20

                    bool updated = db.UpdateInterestRate(decimalRate);
                    if (updated)
                        MessageBox.Show($"Interest rate updated to {decimalRate:P0}.", "Success");
                    else
                        MessageBox.Show("Failed to update interest rate.", "Error");
                }
                else
                {
                    MessageBox.Show("Please enter a value between 0 and 100.", "Invalid Input");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for interest rate.", "Error");
            }

        }

    }

}


