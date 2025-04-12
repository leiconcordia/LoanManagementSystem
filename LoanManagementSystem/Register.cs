using System;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;


using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoanManagementSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }


        

        private DatabaseHelper dbHelper = new DatabaseHelper(); // Create an instance of DatabaseHelper

        public object BCrypt { get; private set; }

        private void RegUser_Click(object sender, EventArgs e)
        {
            // Step 1: Retrieve input values
            string firstName = tbFName.Text.Trim();
            string lastName = tbLName.Text.Trim();
            string phoneNumber = tbPhoneNumber.Text.Trim();
            string address = tbAddress.Text.Trim();
            DateTime dateOfBirth = DOB.Value;
            string employmentStatus = cmbEmploymentStatus.SelectedItem?.ToString();
            string monthlyIncome = tbMonthlyIncome.Text.Trim();
            string Username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            // Step 2: Validate inputs
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phoneNumber) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(employmentStatus) || string.IsNullOrEmpty(monthlyIncome) ||
                string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(monthlyIncome, out decimal incomeValue))
            {
                MessageBox.Show("Monthly Income must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            // Step 3: Check if Phone Number or Username already exists
            string checkQuery = "SELECT 1 FROM Users WHERE PhoneNumber = @PhoneNumber OR Username = @Username";
            SqlParameter[] checkParams =
            {
            new SqlParameter("@PhoneNumber", phoneNumber),
            new SqlParameter("@Username", Username) // Update variable name to match actual username input
};

            if (dbHelper.ValueExists(checkQuery, checkParams))
            {
                MessageBox.Show("Phone number or username already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Step 4: Hash password
            // string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            // Step 5: Insert User into Database
            string insertQuery = @"INSERT INTO Users (FirstName, LastName, PhoneNumber, Address, DateOfBirth, EmploymentStatus, MonthlyIncome, Username, passwordHash)
                                   VALUES (@FirstName, @LastName, @PhoneNumber, @Address, @DateOfBirth, @EmploymentStatus, @MonthlyIncome, @Username, @PasswordHash)";

            SqlParameter[] insertParams =
            {
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@PhoneNumber", phoneNumber),
                new SqlParameter("@Address", address),
                new SqlParameter("@DateOfBirth", dateOfBirth),
                new SqlParameter("@EmploymentStatus", employmentStatus),
                new SqlParameter("@MonthlyIncome", incomeValue),
                new SqlParameter("@Username", Username),
                new SqlParameter("@PasswordHash", password)
            };



            if (dbHelper.ExecuteQuery(insertQuery, insertParams))
            {
                MessageBox.Show("Registration Successful!", "Success",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the current registration form
                this.Close();

                // Create and show the login form
                Login loginForm = new Login();
                loginForm.Show();

            }
            else
            {
                MessageBox.Show("Registration Failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
