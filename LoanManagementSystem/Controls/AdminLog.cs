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
    public partial class AdminLog : UserControl
    {
        private Login parentForm;
        public AdminLog(Login parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }





        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            // Simple validation to check if fields are not empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                // Invalid login: Show a message indicating that the username or password is incorrect

            }
            else if (username == "admin" && password == "123")
            {
                Form parentForm = this.FindForm(); // gets the Login form
                if (parentForm != null)
                {
                    parentForm.Hide(); // you can also use parentForm.Close(); if you want to close it entirely
                }
                MainForm mf = new MainForm();
                mf.Show();

            }
            else
            {
                // Invalid login: Show a message indicating that the username or password is incorrect
                MessageBox.Show("Invalid username or password.");
                tbPassword.Text = "";
                tbUsername.Text = "";
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parentForm.LoginPanel.Controls.Clear(); // ✅ use the stored reference
            UserLogin UserLogin = new UserLogin(parentForm);
            UserLogin.Dock = DockStyle.Fill;
            parentForm.LoginPanel.Controls.Add(UserLogin);
        }
    }
}