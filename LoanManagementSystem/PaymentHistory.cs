using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManagementSystem
{
    public partial class PaymentHistory : Form
    {
        private int loanId;

        public PaymentHistory(int loanId)
        {
            InitializeComponent();
            this.loanId = loanId;
        }

        private void PaymentHistory_Load(object sender, EventArgs e)
        {
            LoadPaymentHistory();
        }

        private void LoadPaymentHistory()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetPaymentHistoryByLoanId(loanId);
            dgvPaymentHistory.DataSource = dt;

            // Optional: hide internal IDs
            if (dgvPaymentHistory.Columns.Contains("PaymentID"))
                dgvPaymentHistory.Columns["PaymentID"].Visible = false;

          
        }

        
    }
}
