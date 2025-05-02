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
        int LoanID;
        public LoanRepayments(int LoanIDuserID)
        {
            InitializeComponent();
            this.LoanID = LoanID;
        }
    }
}
