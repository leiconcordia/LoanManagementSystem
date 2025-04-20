using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManagementSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();

        }
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            label6.Visible = false;

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
                this.Hide();
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

        private void tbUsername_TextChanged_1(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void tbPassword_TextChanged_1(object sender, EventArgs e)
        {
            label6.Visible = false;
        }
    }
}
