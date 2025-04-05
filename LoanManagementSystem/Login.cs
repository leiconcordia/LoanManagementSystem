using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoanManagementSystem
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
           
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
           
        }

        

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
        private void logAdmin_click(object sender, EventArgs e)
        {
            
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
    }
}
