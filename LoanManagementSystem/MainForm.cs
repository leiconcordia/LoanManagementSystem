using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LoanManagementSystem
{
    public partial class MainForm : Form
    {
        Controls.UserEvaluation UserEvaluation = new Controls.UserEvaluation();
        public MainForm()
        {
            InitializeComponent();

            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }



      
        private void panel5_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
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
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(UserEvaluation);
            MainPanel.Controls.Clear();
            UserEvaluation.Dock = DockStyle.Fill;

        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalender.Height;
            pnlNav.Top = btnCalender.Top;
            btnCalender.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnUserEvaluation_Leave(object sender, EventArgs e)
        {
            btnUserEvaluation.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.flaticon.com/") { UseShellExecute = true });
        }

        
    }

}


