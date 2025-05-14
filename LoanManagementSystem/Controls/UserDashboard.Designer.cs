using System.Drawing;
using System.Windows.Forms;

namespace LoanManagementSystem.Controls
{
    partial class UserDashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserCredit = new System.Windows.Forms.Label();
            this.btnApplyLoan = new System.Windows.Forms.Button();
            this.lblStatusDesc = new System.Windows.Forms.Label();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvUserLoans = new System.Windows.Forms.DataGridView();
            this.btnBacktoUserLoanTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserCredit
            // 
            this.lblUserCredit.AutoSize = true;
            this.lblUserCredit.Location = new System.Drawing.Point(25, 114);
            this.lblUserCredit.Name = "lblUserCredit";
            this.lblUserCredit.Size = new System.Drawing.Size(35, 13);
            this.lblUserCredit.TabIndex = 9;
            this.lblUserCredit.Text = "label1";
            // 
            // btnApplyLoan
            // 
            this.btnApplyLoan.Location = new System.Drawing.Point(293, 401);
            this.btnApplyLoan.Name = "btnApplyLoan";
            this.btnApplyLoan.Size = new System.Drawing.Size(227, 34);
            this.btnApplyLoan.TabIndex = 8;
            this.btnApplyLoan.Text = "Apply Loan";
            this.btnApplyLoan.UseVisualStyleBackColor = true;
            this.btnApplyLoan.Click += new System.EventHandler(this.btnApplyLoan_Click);
            // 
            // lblStatusDesc
            // 
            this.lblStatusDesc.AutoSize = true;
            this.lblStatusDesc.Location = new System.Drawing.Point(25, 82);
            this.lblStatusDesc.Name = "lblStatusDesc";
            this.lblStatusDesc.Size = new System.Drawing.Size(35, 13);
            this.lblStatusDesc.TabIndex = 7;
            this.lblStatusDesc.Text = "label1";
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Location = new System.Drawing.Point(25, 49);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(35, 13);
            this.lblUserStatus.TabIndex = 6;
            this.lblUserStatus.Text = "label1";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(25, 18);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "label1";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(724, 21);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(61, 28);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvUserLoans
            // 
            this.dgvUserLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserLoans.Location = new System.Drawing.Point(85, 153);
            this.dgvUserLoans.Name = "dgvUserLoans";
            this.dgvUserLoans.Size = new System.Drawing.Size(639, 197);
            this.dgvUserLoans.TabIndex = 11;
            this.dgvUserLoans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserLoans_CellContentClick);
            // 
            // btnBacktoUserLoanTable
            // 
            this.btnBacktoUserLoanTable.Location = new System.Drawing.Point(681, 126);
            this.btnBacktoUserLoanTable.Name = "btnBacktoUserLoanTable";
            this.btnBacktoUserLoanTable.Size = new System.Drawing.Size(42, 27);
            this.btnBacktoUserLoanTable.TabIndex = 12;
            this.btnBacktoUserLoanTable.Text = "Back";
            this.btnBacktoUserLoanTable.UseVisualStyleBackColor = true;
            this.btnBacktoUserLoanTable.Click += new System.EventHandler(this.btnBacktoUserLoanTable_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBacktoUserLoanTable);
            this.Controls.Add(this.dgvUserLoans);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUserCredit);
            this.Controls.Add(this.btnApplyLoan);
            this.Controls.Add(this.lblStatusDesc);
            this.Controls.Add(this.lblUserStatus);
            this.Controls.Add(this.lblUsername);
            this.Name = "UserDashboard";
            this.Size = new System.Drawing.Size(801, 453);
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserCredit;
        private System.Windows.Forms.Button btnApplyLoan;
        private System.Windows.Forms.Label lblStatusDesc;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvUserLoans;
        private Button btnBacktoUserLoanTable;
    }
}
