using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LoanManagementSystem;

namespace LoanManagementSystem.Controls
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Linq;
    using System.Windows.Forms;

    public partial class UserEvaluation : UserControl
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private FlowLayoutPanel breadcrumbPanel;
        private LinkLabel linkDashboard;
        private Label lblSeparator;
        private Label lblCurrentPage;

        public UserEvaluation()
        {
            InitializeComponent();

            // Breadcrumb setup
            breadcrumbPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10, 10, 0, 10),
                BackColor = Color.Transparent
            };

            linkDashboard = new LinkLabel
            {
                Text = "User Evaluation",
                AutoSize = true,
                LinkColor = Color.LightBlue,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                LinkBehavior = LinkBehavior.NeverUnderline
            };


            //linkDashboard.Click += (s, e) =>
            //{
            //    // Reload this same dashboard control
            //    parentForm.UserPanel.Controls.Clear();
            //    UserDashboard dashboard = new UserDashboard(lblUsername.Text.Replace("Welcome! ", ""), userID, parentForm)
            //    {
            //        Dock = DockStyle.Fill
            //    };
            //    parentForm.UserPanel.Controls.Add(dashboard);
            //};

            breadcrumbPanel.Controls.Add(linkDashboard);
            breadcrumbPanel.Controls.Add(lblSeparator);
            breadcrumbPanel.Controls.Add(lblCurrentPage);
            this.Controls.Add(breadcrumbPanel);
            breadcrumbPanel.BringToFront();

            // Customize and prepare DataGridView
            CustomizeDataGridView(dgvUserList);

            // Attach event handlers
            dgvUserList.CellClick += dgvUserList_CellClick;
            dgvUserList.CellPainting += dgvUserList_CellPainting;

            // Load users on control load
            this.Load += UserEvaluation_Load;
        }

        private void UserEvaluation_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // Load users from DB and fill DataGridView
        public void LoadUsers(string searchTerm = "")
        {
            List<DatabaseHelper.User> users = dbHelper.GetUsers(searchTerm);

            dgvUserList.Rows.Clear();

            foreach (var user in users)
            {
                int rowIndex = dgvUserList.Rows.Add();
                DataGridViewRow row = dgvUserList.Rows[rowIndex];

                row.Cells["colName"].Value = $"{user.FirstName} {user.LastName}";
                row.Cells["colStatus"].Value = user.Status;
                row.Cells["colUser Id"].Value = user.UserId;
            }
        }

        private void tbSearchUser_TextChanged(object sender, EventArgs e)
        {
            LoadUsers(tbSearchUser.Text.Trim());
        }



        private void CustomizeDataGridView(DataGridView dgv)
        {

            dgv.CellPainting -= dgvUserList_CellPainting;
            dgv.CellClick -= dgvUserList_CellClick;

            dgv.Columns.Clear();
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;

            // GENERAL GRID SETTINGS
            dgv.BackgroundColor = Color.FromArgb(25, 30, 54);
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.FromArgb(45, 50, 70);
            dgv.EnableHeadersVisualStyles = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // HEADER STYLE
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 64);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.GridColor = Color.FromArgb(45, 50, 70);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 45;

            // CELL STYLE
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(25, 30, 54);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 60, 90);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.RowTemplate.Height = 60;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // Alternate row style
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 35, 60);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = null;

            dgv.RowTemplate.Height = 60;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Enable double buffering to reduce flicker
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dgv, new object[] { true });

            // Add columns if not already added
            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colName",
                    HeaderText = "Name",
                    ReadOnly = true,
                    FillWeight = 40,
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colStatus",
                    HeaderText = "Status",
                    ReadOnly = true,
                    FillWeight = 20,
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colUser Id",
                    HeaderText = "User  ID",
                    ReadOnly = true,
                    Visible = false // Make it hidden
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ActionColumn",  // <-- This name must be exactly "ActionColumn"
                    HeaderText = "Action",
                    ReadOnly = true,
                    FillWeight = 10,
                });
            }

        }

        // Helper: Creates a rounded rectangle path
        private GraphicsPath GetRoundPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void dgvUserList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return; // Skip header

            var actionColumn = dgvUserList.Columns["ActionColumn"];
            if (actionColumn == null) return;

            if (e.ColumnIndex == actionColumn.Index)
            {
                e.PaintBackground(e.ClipBounds, true);
                e.Handled = true;

                Rectangle cellBounds = e.CellBounds;

                int buttonWidth = 70;
                int buttonHeight = 30;

                // Center the button in the cell
                int buttonX = cellBounds.X + (cellBounds.Width - buttonWidth) / 2;
                int buttonY = cellBounds.Y + (cellBounds.Height - buttonHeight) / 2;

                Rectangle viewRect = new Rectangle(buttonX, buttonY, buttonWidth, buttonHeight);
                int radius = 10;

                using (GraphicsPath viewPath = GetRoundPath(viewRect, radius))
                using (SolidBrush viewBrush = new SolidBrush(Color.FromArgb(52, 152, 219))) // Blue
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                using (Font btnFont = new Font("Segoe UI", 9F, FontStyle.Bold))
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    e.Graphics.FillPath(viewBrush, viewPath);
                    e.Graphics.DrawString("View", btnFont, textBrush, viewRect, sf);
                }
            }
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var actionColumn = dgvUserList.Columns["ActionColumn"];
            if (actionColumn == null) return;

            if (e.ColumnIndex == actionColumn.Index)
            {
                // Get the user ID from the hidden column
                string userId = dgvUserList.Rows[e.RowIndex].Cells["colUser Id"].Value.ToString();

                // Proceed to open the UserInfo control
                UserInfo userInfoControl = new UserInfo(userId);
                var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                mainForm?.switchUserControl(userInfoControl);
            }
        }


    }

}
