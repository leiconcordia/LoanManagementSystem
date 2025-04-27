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
    public partial class Loans : UserControl
    {
        public Loans()
        {
            InitializeComponent();
        }


        private void LoadLoanData()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable loanData = db.GetLoansWithUserNames();

            if (loanData != null)
            {
                dgvLoanList.Rows.Clear(); // Clear existing rows first

                foreach (DataRow row in loanData.Rows)
                {
                    int rowIndex = dgvLoanList.Rows.Add();
                    dgvLoanList.Rows[rowIndex].Cells["Lender"].Value = row["Lender"].ToString();
                    dgvLoanList.Rows[rowIndex].Cells["Loan_Amount"].Value = row["Loan_Amount"].ToString();
                    dgvLoanList.Rows[rowIndex].Cells["Status"].Value = row["Status"].ToString();
                    // If you have an Action button, no need to fill here


                    // 🎨 Set text color (ForeColor)
                    dgvLoanList.Rows[rowIndex].Cells["Lender"].Style.ForeColor = Color.Black;
                    dgvLoanList.Rows[rowIndex].Cells["Loan_Amount"].Style.ForeColor = Color.Black;
                    dgvLoanList.Rows[rowIndex].Cells["Status"].Style.ForeColor = Color.Black;
                }
            }
        }


        private void Loans_Load(object sender, EventArgs e)
        {
            LoadLoanData();
        }
    }
}
