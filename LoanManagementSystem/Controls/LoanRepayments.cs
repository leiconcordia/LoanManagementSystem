using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManagementSystem.Controls
{
    public partial class LoanRepayments : UserControl
    {
  

        private int loanID; // store the current loan ID

        public LoanRepayments(int loanID)
        {
            InitializeComponent();
            this.loanID = loanID;
            LoadPaymentHistory(); // load data on form load
            CustomizeDataGridView(dgvPaymentHistory);
        }

        private void LoadPaymentHistory()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetPaymentHistoryByLoanId(loanID);
            dgvPaymentHistory.DataSource = dt;

            // Optional: hide internal IDs
            if (dgvPaymentHistory.Columns.Contains("PaymentID"))
                dgvPaymentHistory.Columns["PaymentID"].Visible = false;




        }

        private void CustomizeDataGridView(DataGridView dgvPaymentHistory)
        {
            // Set background and grid color
            dgvPaymentHistory.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgvPaymentHistory.GridColor = Color.Gray;

            // Remove borders and make it modern
            dgvPaymentHistory.BorderStyle = BorderStyle.None;
            dgvPaymentHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPaymentHistory.EnableHeadersVisualStyles = false;

            // Column header styling
            dgvPaymentHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 45);
            dgvPaymentHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPaymentHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Row styling
            dgvPaymentHistory.DefaultCellStyle.BackColor = Color.White;  // base row color
            dgvPaymentHistory.DefaultCellStyle.ForeColor = Color.Black;
            dgvPaymentHistory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 80, 100);
            dgvPaymentHistory.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternate row styling
            dgvPaymentHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(58, 63, 85);  // slightly lighter
            dgvPaymentHistory.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            // Row height (optional)
            dgvPaymentHistory.RowTemplate.Height = 30;

            // Header height (optional)
            dgvPaymentHistory.ColumnHeadersHeight = 35;
        }



    }
}
