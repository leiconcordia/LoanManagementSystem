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
    public partial class UserInfo : UserControl
    {
        private string _userId; // Field to store the user ID

        // Default constructor (required for designer)
        public UserInfo()
        {
            InitializeComponent();
        }

        // New constructor that accepts userId
        public UserInfo(string userId) : this() // Calls the default constructor first
        {
            _userId = userId;

            // You can either load data here or in the Load event
            // If loading is quick, do it here. If it's complex, do it in Load
            LoadUserData(_userId);

            
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            // Alternative place to load data if you prefer
            // if (!string.IsNullOrEmpty(_userId)) LoadUserData(_userId);
        }

        private void LoadUserData(string userId)
        {
            try
            {
                // TODO: Implement your data loading logic here
                // Example:
                // var user = UserRepository.GetUserById(userId);
                // txtFirstName.Text = user.FirstName;
                // txtLastName.Text = user.LastName;
                // etc.

                // For now, just display the ID for testing:
                if (this.Controls.OfType<Label>().Any())
                {
                    var firstLabel = this.Controls.OfType<Label>().First();
                    firstLabel.Text = $"User ID: {userId}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}");
            }
        }
    }
}