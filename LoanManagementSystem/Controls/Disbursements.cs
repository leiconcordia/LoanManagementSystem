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
        }
       
        private void LoadDisbursementData()
        {
            DatabaseHelper db = new DatabaseHelper();

            // Clear manually added columns
            dgvDisbursements.Columns.Clear();

            // Bind fresh data
            dgvDisbursements.DataSource = db.GetAllDisbursements();

            // Optional formatting
            dgvDisbursements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


    }
}
