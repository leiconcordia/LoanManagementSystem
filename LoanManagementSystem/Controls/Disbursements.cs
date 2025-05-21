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
    public partial class Disbursements : UserControl
    {
        public Disbursements()
        {
            InitializeComponent();
            LoadDisbursementData();
            CustomizeDataGridView(dgvDisbursements);
        }
       
        public void LoadDisbursementData()
        {
            DatabaseHelper db = new DatabaseHelper();

            // Clear manually added columns
            dgvDisbursements.Columns.Clear();

            // Bind fresh data
            dgvDisbursements.DataSource = db.GetAllDisbursements();

            // Optional formatting
            dgvDisbursements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Design sa table
        private void CustomizeDataGridView(DataGridView dgvDisbursement)
        {
            // Set background and grid color
            dgvDisbursement.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgvDisbursement.GridColor = Color.Gray;

            // Remove borders and make it modern
            dgvDisbursement.BorderStyle = BorderStyle.None;
            dgvDisbursement.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDisbursement.EnableHeadersVisualStyles = false;

            // Column header styling
            dgvDisbursement.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 45);
            dgvDisbursement.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDisbursement.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Row styling
            dgvDisbursement.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);  // base row color
            dgvDisbursement.DefaultCellStyle.ForeColor = Color.White;
            dgvDisbursement.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 80, 100);
            dgvDisbursement.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternate row styling
            dgvDisbursement.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(58, 63, 85);  // slightly lighter
            dgvDisbursement.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            // Row height (optional)
            dgvDisbursement.RowTemplate.Height = 30;

            // Header height (optional)
            dgvDisbursement.ColumnHeadersHeight = 35;
        }


    }
}
