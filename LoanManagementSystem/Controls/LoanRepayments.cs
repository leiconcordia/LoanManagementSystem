using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace LoanManagementSystem.Controls
{
    public partial class LoanRepayments : UserControl
    {
        private int loanID;
        private FlowLayoutPanel breadcrumbPanel;
        private LinkLabel linkDisbursements;
        private Label lblSeparator;
        private Label lblCurrentPage;

        private void LinkDisbursements_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                Disbursements dis = new Disbursements();
                mainForm.switchUserControl(dis);
            }
        }
        public LoanRepayments(int loanID)
        {
            InitializeComponent();
            breadcrumbPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10, 10, 0, 10),
                BackColor = Color.Transparent
            };

            linkDisbursements = new LinkLabel
            {
                Text = "Disbursements List",
                AutoSize = true,

                LinkColor = Color.LightBlue,
                Font = new Font("Segoe UI", 10, FontStyle.Underline),
                Cursor = Cursors.Hand
            };

            linkDisbursements.LinkClicked += LinkDisbursements_LinkClicked;

            lblSeparator = new Label
            {
                Text = " > ",
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White
            };

            lblCurrentPage = new Label
            {
                Text = "Loan Payment History",
                AutoSize = true,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.LightBlue
            };



            breadcrumbPanel.Controls.Add(linkDisbursements);
            breadcrumbPanel.Controls.Add(lblSeparator);
            breadcrumbPanel.Controls.Add(lblCurrentPage);
            this.Controls.Add(breadcrumbPanel);
            breadcrumbPanel.BringToFront();
            this.loanID = loanID;
            CustomizeDataGridView(dgvPaymentHistory);
            LoadPaymentHistory();
        }

        private void LoadPaymentHistory()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetPaymentHistoryByLoanId(loanID);

            dgvPaymentHistory.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvPaymentHistory.Rows.Add();

                dgvPaymentHistory.Rows[rowIndex].Cells["Due Date"].Value = row["Due Date"]?.ToString();
                dgvPaymentHistory.Rows[rowIndex].Cells["Payment Date"].Value = row["Payment Date"]?.ToString();
                dgvPaymentHistory.Rows[rowIndex].Cells["Monthly Payment"].Value = row["Monthly Payment"]?.ToString();
                dgvPaymentHistory.Rows[rowIndex].Cells["Balance"].Value = row["Balance"]?.ToString();
                dgvPaymentHistory.Rows[rowIndex].Cells["Status"].Value = row["Status"]?.ToString();
                dgvPaymentHistory.Rows[rowIndex].Cells["Remarks"].Value = row["Remarks"]?.ToString();

                // Set text color for all cells
                foreach (DataGridViewCell cell in dgvPaymentHistory.Rows[rowIndex].Cells)
                {
                    cell.Style.ForeColor = Color.White;
                }
            }
        }

        private void CustomizeDataGridView(DataGridView dgv)
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

            dgv.DefaultCellStyle.BackColor = Color.FromArgb(25, 30, 54);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 60, 90);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.RowTemplate.Height = 40;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 35, 60);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = null;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dgv, new object[] { true });

            dgv.Columns.Clear();

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Due Date",
                HeaderText = "Due Date",
                ReadOnly = true,
                FillWeight = 20
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Payment Date",
                HeaderText = "Payment Date",
                ReadOnly = true,
                FillWeight = 20
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Monthly Payment",
                HeaderText = "Monthly Payment",
                ReadOnly = true,
                FillWeight = 20
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Balance",
                HeaderText = "Balance",
                ReadOnly = true,
                FillWeight = 20
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                ReadOnly = true,
                FillWeight = 15
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Remarks",
                HeaderText = "Remarks",
                ReadOnly = true,
                FillWeight = 25
            });
        }
    }
}
