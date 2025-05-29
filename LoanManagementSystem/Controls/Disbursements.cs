using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManagementSystem.Controls
{
    public partial class Disbursements : UserControl
    {
        private const string ColumnActionButton = "Action";
        private FlowLayoutPanel breadcrumbPanel;
        private LinkLabel linkDisbursement;
        private Label lblSeparator;
        private Label lblCurrentPage;
        public Disbursements()
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

            linkDisbursement = new LinkLabel
            {
                Text = "Disbursements List",
                AutoSize = true,
                LinkColor = Color.LightBlue,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                LinkBehavior = LinkBehavior.NeverUnderline
            };


            breadcrumbPanel.Controls.Add(linkDisbursement);
            breadcrumbPanel.Controls.Add(lblSeparator);
            breadcrumbPanel.Controls.Add(lblCurrentPage);
            this.Controls.Add(breadcrumbPanel);
            breadcrumbPanel.BringToFront();
            LoadDisbursementData();
            CustomizeDataGridView(dgvDisbursements);
        }

        public void LoadDisbursementData(string keyword = "")
        {
            DatabaseHelper db = new DatabaseHelper();

            dgvDisbursements.Columns.Clear();

            // Load filtered or all data
            if (string.IsNullOrEmpty(keyword))
                dgvDisbursements.DataSource = db.GetAllDisbursements();
            else
                dgvDisbursements.DataSource = db.SearchDisbursements(keyword);

            // Hide LoanID column if it exists
            if (dgvDisbursements.Columns.Contains("LoanID"))
            {
                dgvDisbursements.Columns["LoanID"].Visible = false;
            }

            dgvDisbursements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ✅ Add Action column manually AFTER setting DataSource
            if (!dgvDisbursements.Columns.Contains("Action"))
            {
                dgvDisbursements.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Action",
                    HeaderText = "Action",
                    ReadOnly = true
                });
            }

            // Re-attach handlers (if necessary, guard with -= first)
            dgvDisbursements.CellClick -= dgvDisbursements_CellClick;
            dgvDisbursements.CellClick += dgvDisbursements_CellClick;

            dgvDisbursements.CellPainting -= dgvDisbursements_CellPainting;
            dgvDisbursements.CellPainting += dgvDisbursements_CellPainting;
        }

        private void tbSearchDisbursement_TextChanged(object sender, EventArgs e)
        {
            LoadDisbursementData(tbSearchDisbursement.Text.Trim());
        }

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

        private void dgvDisbursements_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return; // Skip header

            var actionColumn = dgvDisbursements.Columns["Action"];
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

        private void dgvDisbursements_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDisbursements.Columns[e.ColumnIndex].Name == "Action")
            {
                // Access the selected row
                var selectedRow = dgvDisbursements.Rows[e.RowIndex];

                try
                {
                    // ✅ Safely get the LoanID from the hidden column
                    int loanId = Convert.ToInt32(selectedRow.Cells["LoanID"].Value);

                    // ✅ Call your method to show details
                    ShowDisbursementDetails(loanId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving Loan ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ShowDisbursementDetails(int loanId)
        {
            UserControl controlToShow = new LoanRepayments(loanId);

            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm?.switchUserControl(controlToShow);
        }















        //Design sa table
        private void CustomizeDataGridView(DataGridView dgv)
        {
            dgv.CellPainting -= dgvDisbursements_CellPainting;
            dgv.CellClick -= dgvDisbursements_CellClick;

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

            // Enable double buffering to reduce flicker
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dgv, new object[] { true });

            // Add columns if needed (example structure)
            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "LoanID",
                    HeaderText = "Loan ID",
                    Visible = false
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Loanee",
                    HeaderText = "Loanee",
                    ReadOnly = true,
                    FillWeight = 40,
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Loan Amount",
                    HeaderText = "Amount",
                    ReadOnly = true,
                    FillWeight = 30,
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Disbursed Date",
                    HeaderText = "Disbursed Date",
                    ReadOnly = true,
                    FillWeight = 20,
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Action", // Define this constant elsewhere if needed
                    HeaderText = "Action",
                    ReadOnly = true,
                    FillWeight = 20,
                });
            }
        }


    }
}
