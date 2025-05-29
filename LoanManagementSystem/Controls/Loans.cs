
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace LoanManagementSystem.Controls
{
    public partial class Loans : UserControl
    {
        private const string ColumnLoanee = "Loanee";
        private const string ColumnLoanAmount = "Loan_Amount";
        private const string ColumnStatus = "Status";
        private const string ColumnActionButton = "actionButton";
        private const string ColumnUserID = "LoanID";
        private FlowLayoutPanel breadcrumbPanel;
        private LinkLabel linkLoanList;
        private Label lblSeparator;
        private Label lblCurrentPage;

        public Loans()
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

            linkLoanList = new LinkLabel
            {
                Text = "Loans List",
                AutoSize = true,
                LinkColor = Color.LightBlue,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                LinkBehavior = LinkBehavior.NeverUnderline
            };


            breadcrumbPanel.Controls.Add(linkLoanList);
            breadcrumbPanel.Controls.Add(lblSeparator);
            breadcrumbPanel.Controls.Add(lblCurrentPage);
            this.Controls.Add(breadcrumbPanel);
            breadcrumbPanel.BringToFront();
            CustomizeDataGridView(dgvLoanList);
            if (!dgvLoanList.Columns.Contains("LoanID"))
            {
                var loanIdColumn = new DataGridViewTextBoxColumn();
                loanIdColumn.Name = "LoanID";
                loanIdColumn.HeaderText = "LoanID";
                loanIdColumn.Visible = false; // hide it
                dgvLoanList.Columns.Add(loanIdColumn);
                LoadLoanData();

            }


            dgvLoanList.CellPainting += dgvLoanList_CellPainting;
            dgvLoanList.CellClick += dgvLoanList_CellClick;

        }

        public void LoadLoanData()
        {
            try
            {
                string selectedStatus = cbLoanFilter.SelectedItem?.ToString() ?? "All";
                string keyword = tbLoanSearch.Text.Trim(); // This already gets the value

                var loanData = FetchLoanData(selectedStatus, keyword);

                if (loanData != null)
                {
                    BindLoanDataToGrid(loanData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading loan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private DataTable FetchLoanData(string statusFilter, string keyword)
        {
            var db = new DatabaseHelper();

            if (statusFilter == "All")
            {
                return db.SearchLoansByName(keyword); // 🔍 Search without status filter
            }
            else
            {
                return db.SearchLoansByNameAndStatus(keyword, statusFilter); // 🔍🔍 Search + Status filter
            }
        }


       




        private void BindLoanDataToGrid(DataTable loanData)
        {
            dgvLoanList.Rows.Clear();

            foreach (DataRow row in loanData.Rows)
            {
                int rowIndex = dgvLoanList.Rows.Add();
                dgvLoanList.Rows[rowIndex].Cells[ColumnLoanee].Value = row[ColumnLoanee]?.ToString();
                dgvLoanList.Rows[rowIndex].Cells[ColumnLoanAmount].Value = row[ColumnLoanAmount]?.ToString();
                dgvLoanList.Rows[rowIndex].Cells[ColumnStatus].Value = row[ColumnStatus]?.ToString();
                dgvLoanList.Rows[rowIndex].Cells["LoanID"].Value = row["LoanID"];
               
                // Set text color for the cells
                dgvLoanList.Rows[rowIndex].Cells[ColumnLoanee].Style.ForeColor = Color.White;
                dgvLoanList.Rows[rowIndex].Cells[ColumnLoanAmount].Style.ForeColor = Color.White;
                dgvLoanList.Rows[rowIndex].Cells[ColumnStatus].Style.ForeColor = Color.White;


                // Optional styling
                var status = row["Status"].ToString();
                var statusCell = dgvLoanList.Rows[rowIndex].Cells["Status"];

                //if (status == "Approved")
                //{
                //    statusCell.Style.ForeColor = Color.White;
                //    statusCell.Style.BackColor = Color.Green;
                //}
                //else if (status == "Rejected")
                //{
                //    statusCell.Style.ForeColor = Color.White;
                //    statusCell.Style.BackColor = Color.Red;
                //}
                //else if (status == "Pending")
                //{
                //    statusCell.Style.ForeColor = Color.Black;
                //    statusCell.Style.BackColor = Color.Yellow;
                //}
                //else if (status == "Disbursed")
                //{
                //    statusCell.Style.ForeColor = Color.White;
                //    statusCell.Style.BackColor = Color.FromArgb(33, 150, 243);
                //}
            }
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

        private void dgvLoanList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return; // Skip header

            var actionColumn = dgvLoanList.Columns["actionButton"];
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








        private void dgvLoanList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLoanList.Columns[e.ColumnIndex].Name == ColumnActionButton && e.RowIndex >= 0)
            {
                try
                {
                    int loanId = Convert.ToInt32(dgvLoanList.Rows[e.RowIndex].Cells["LoanID"].Value);
                    OpenLoanDetails(loanId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while processing the action: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLoanList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLoanList.Columns[e.ColumnIndex].Name == ColumnActionButton)
            {
                try
                {
                    int loanId = Convert.ToInt32(dgvLoanList.Rows[e.RowIndex].Cells["LoanID"].Value);
                    OpenLoanDetails(loanId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while processing the action: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void OpenLoanDetails(int LoanID)
        {


            UserControl controlToShow;



            controlToShow = new LoanDetails(LoanID); // Open regular LoanDetails user control


            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm?.switchUserControl(controlToShow);
        }



        private void cbLoanFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cbLoanFilter.SelectedItem?.ToString() ?? "All";
            string keyword = tbLoanSearch.Text.Trim(); // Optional: search box used too

            var filteredData = FetchLoanData(selectedStatus, keyword);
            if (filteredData != null)
            {
                BindLoanDataToGrid(filteredData);
            }
        }




        private void tbLoanSearch_TextChanged(object sender, EventArgs e)
        {
            LoadLoanData(); 
        }



        private void CustomizeDataGridView(DataGridView dgv)
        {
            dgv.CellPainting -= dgvLoanList_CellPainting;
            dgv.CellClick -= dgvLoanList_CellClick;

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
                    Name = "Loan_Amount",
                    HeaderText = "Amount",
                    ReadOnly = true,
                    FillWeight = 30,
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Status",
                    HeaderText = "Status",
                    ReadOnly = true,
                    FillWeight = 20,
                });

                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = ColumnActionButton, // Define this constant elsewhere if needed
                    HeaderText = "Action",
                    ReadOnly = true,
                    FillWeight = 15,
                });
            }
        }



    }
}
