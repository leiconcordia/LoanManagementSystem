
using System;
using System.Data;
using System.Drawing;
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

        public Loans()
        {
            InitializeComponent();
            if (!dgvLoanList.Columns.Contains("LoanID"))
            {
                var loanIdColumn = new DataGridViewTextBoxColumn();
                loanIdColumn.Name = "LoanID";
                loanIdColumn.HeaderText = "LoanID";
                loanIdColumn.Visible = false; // hide it
                dgvLoanList.Columns.Add(loanIdColumn);
                LoadLoanData();

            }



        }

        public void LoadLoanData()
        {
            try
            {
                // Get selected value from ComboBox or default to "All"
                string selectedStatus = cbLoanFilter.SelectedItem?.ToString() ?? "All";

                // Pass status to FetchLoanData
                var loanData = FetchLoanData(selectedStatus);

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






        private DataTable FetchLoanData(string statusFilter)
        {
            var db = new DatabaseHelper();

            if (statusFilter == "All")
            {
                return db.GetLoansWithUserNames(); // Original method
            }
            else
            {
                return db.GetLoansWithUserNamesByStatus(statusFilter); // Filtered method
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


                // Create a "View Details" button in the row
                var viewButton = new DataGridViewButtonCell();
                viewButton.Value = "View Details";  // Set button text

                // Store the UserID in the Tag property
                viewButton.Tag = row["LoanID"];  // Assuming your query includes the UserID column

                // Add the button to the row
                dgvLoanList.Rows[rowIndex].Cells[ColumnActionButton] = viewButton;
                dgvLoanList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;


                // Set text color for the cells
                dgvLoanList.Rows[rowIndex].Cells[ColumnLoanee].Style.ForeColor = Color.Black;
                dgvLoanList.Rows[rowIndex].Cells[ColumnLoanAmount].Style.ForeColor = Color.Black;
                dgvLoanList.Rows[rowIndex].Cells[ColumnStatus].Style.ForeColor = Color.Black;


                // Optional styling
                var status = row["Status"].ToString();
                var statusCell = dgvLoanList.Rows[rowIndex].Cells["Status"];

                if (status == "Approved")
                {
                    statusCell.Style.ForeColor = Color.White;
                    statusCell.Style.BackColor = Color.Green;
                }
                else if (status == "Rejected")
                {
                    statusCell.Style.ForeColor = Color.White;
                    statusCell.Style.BackColor = Color.Red;
                }
                else if (status == "Pending")
                {
                    statusCell.Style.ForeColor = Color.Black;
                    statusCell.Style.BackColor = Color.Yellow;
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





        private void OpenLoanDetails(int LoanID)
        {
            DatabaseHelper db = new DatabaseHelper();
            // Query the status of the loan using LoanID
            string status = db.GetLoanStatusById(LoanID);

            UserControl controlToShow;

            if (status.ToLower() == "disbursed")
            {
                controlToShow = new LoanRepayments(LoanID); // Open LoanRepayments user control
            }
            else
            {
                controlToShow = new LoanDetails(LoanID); // Open regular LoanDetails user control
            }

            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm?.switchUserControl(controlToShow);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string selectedStatus = cbLoanFilter.SelectedItem?.ToString() ?? "All";

            var filteredData = FetchLoanData(selectedStatus);
            if (filteredData != null)
            {
                BindLoanDataToGrid(filteredData);
            }
        }

    }
}
