using System.Windows.Forms;

namespace LoanManagementSystem.Controls
{
    partial class Loans
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoanList = new System.Windows.Forms.DataGridView();
            this.Lender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loan_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loans ";
            // 
            // dgvLoanList
            // 
            this.dgvLoanList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lender,
            this.Loan_Amount,
            this.Status,
            this.actionButton});
            this.dgvLoanList.Location = new System.Drawing.Point(46, 97);
            this.dgvLoanList.Name = "dgvLoanList";
            this.dgvLoanList.Size = new System.Drawing.Size(724, 364);
            this.dgvLoanList.TabIndex = 1;
            this.dgvLoanList.AllowUserToAddRows = false;
            // 
            // Lender
            // 
            this.Lender.FillWeight = 144.9716F;
            this.Lender.HeaderText = "Lender";
            this.Lender.Name = "Lender";
            this.Lender.ReadOnly = true;
            // 
            // Loan_Amount
            // 
            this.Loan_Amount.FillWeight = 144.9716F;
            this.Loan_Amount.HeaderText = "Amount";
            this.Loan_Amount.Name = "Loan_Amount";
            this.Loan_Amount.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 60.9137F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // actionButton
            // 
            this.actionButton.HeaderText = "Action";
            this.actionButton.Name = "actionButton";
            this.actionButton.Text = "View Details";
            this.actionButton.UseColumnTextForButtonValue = true;
            // 
            // Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.dgvLoanList);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Loans";
            this.Size = new System.Drawing.Size(862, 630);
            this.Load += new System.EventHandler(this.Loans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoanList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loan_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn actionButton;
    }
}
