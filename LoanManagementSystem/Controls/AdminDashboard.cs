using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManagementSystem.Controls
{
    public partial class AdminDashboard : UserControl
    {
        public AdminDashboard()
        {
            InitializeComponent();
            
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {



            LoadRecentActivity();
            LoadActiveLoanCount();
            LoadPendingLoans();
            LoadDisbursedAmount();
            LoadPendingUser();
            LoadAdminBalance();
            LoadUsersWithNearDueDates();

        }

        public void LoadPendingUser()
        {
            DatabaseHelper db = new DatabaseHelper();
            int PendingUsers = db.GetPendingUsers();
            lblAdminMoney.Text = PendingUsers.ToString();
        }
        public void LoadDisbursedAmount()
        {
            DatabaseHelper db = new DatabaseHelper();
            decimal total = db.GetTotalDisbursedAmount();
            lblDisbursedTotal.Text = "₱ " + total.ToString("N2");
        }


        public void LoadPendingLoans()
        {
            DatabaseHelper db = new DatabaseHelper();
            int PendingLoan = db.GetPendingLoans();
            lblPendingLoans.Text = PendingLoan.ToString();
        }

        public void LoadActiveLoanCount()
        {
            DatabaseHelper db = new DatabaseHelper();
            int activeLoans = db.GetActiveLoanCount();
            lblActiveLoans.Text = activeLoans.ToString();
        }

        public void LoadAdminBalance()
        {
            DatabaseHelper db = new DatabaseHelper();
            decimal balance = db.GetAdminTotalBalance();

            lblAdminMoney.Text = balance.ToString("C"); // formats as currency, e.g. $1,234.56
        }


        public void LoadRecentActivity()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable activityData = db.GetRecentActivities();

            dgvActivityLog.DataSource = activityData;

            CustomizeActivityGrid(dgvActivityLog);
        }

        public void LoadUsersWithNearDueDates()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable nearDueUsers = db.GetUsersWithNearDueDates();

            dgvNearDueUsers.DataSource = nearDueUsers;

            // Customize if needed
            CustomizeNearDueGrid(dgvNearDueUsers);
        }

        private void CustomizeNearDueGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.BackgroundColor = Color.FromArgb(25, 30, 54);
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.FromArgb(45, 50, 70);
            dgv.EnableHeadersVisualStyles = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 64);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 45;
            dgv.RowTemplate.Height = 35;
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(25, 30, 54);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 60, 90);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 35, 60);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            // Optional: reset alternating row style if needed
            dgv.AlternatingRowsDefaultCellStyle = null;

            // Enable double buffering for smoother performance
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dgv, new object[] { true });
        }


        private void CustomizeActivityGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.BackgroundColor = Color.FromArgb(25, 30, 54);
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.FromArgb(45, 50, 70);
            dgv.EnableHeadersVisualStyles = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 64);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 45;
            dgv.RowTemplate.Height = 35;
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(25, 30, 54);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 60, 90);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 35, 60);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = null;
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dgv, new object[] { true });
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}