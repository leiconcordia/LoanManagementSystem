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
    public partial class LoanRepayments : UserControl
    {
  

        private int loanID; // store the current loan ID

        public LoanRepayments(int loanID)
        {
            InitializeComponent();
            this.loanID = loanID;
            LoadPaymentHistory(); // load data on form load
        }

        private void LoadPaymentHistory()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable dt = dbHelper.GetPaymentHistoryByLoanId(loanID);
            dgvPaymentHistory.DataSource = dt;
            dgvPaymentHistory.AutoGenerateColumns = false;

        }

    }
}
