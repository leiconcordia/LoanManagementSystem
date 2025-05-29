using LoanManagementSystem.Controls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoanManagementSystem
{
    public partial class UserForm : Form
    {



        public Panel UserPanelControl => UserPanel;
        public string FullName { get; private set; }
        public string Status { get; private set; }
        public int UserID { get; private set; }

        public UserForm(string fullName, string status, int userID)
        {
            InitializeComponent();
            FullName = fullName;
            Status = status;
            UserID = userID;

            // Load default control (like UserDashboard)
            var dashboard = new UserDashboard(FullName, Status, UserID, this);
            dashboard.Dock = DockStyle.Fill;
            UserPanel.Controls.Add(dashboard);
        }
            
        public void ClearLoanPanel()
        {
            UserPanel.Controls.Clear();
           UserPanel.Visible = false;
        }

        public void switchUserControl(UserControl userControl)
        {
            UserPanel.Controls.Clear();
            UserPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;

        }








        }
}
