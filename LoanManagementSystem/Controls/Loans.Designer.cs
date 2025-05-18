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
            this.Loanee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loan_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbLoanFilter = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
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
            this.dgvLoanList.AllowUserToAddRows = false;
            this.dgvLoanList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Loanee,
            this.Loan_Amount,
            this.Status,
            this.actionButton,
            this.LoanID,
            this.Column1});
            this.dgvLoanList.Location = new System.Drawing.Point(46, 97);
            this.dgvLoanList.Name = "dgvLoanList";
            this.dgvLoanList.Size = new System.Drawing.Size(724, 364);
            this.dgvLoanList.TabIndex = 1;
            this.dgvLoanList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoanList_CellContentClick);
            // 
            // Loanee
            // 
            this.Loanee.FillWeight = 144.9716F;
            this.Loanee.HeaderText = "Loanee";
            this.Loanee.Name = "Loanee";
            this.Loanee.ReadOnly = true;
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
            // LoanID
            // 
            this.LoanID.HeaderText = "Column1";
            this.LoanID.Name = "LoanID";
            this.LoanID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // cbLoanFilter
            // 
            this.cbLoanFilter.FormattingEnabled = true;
            this.cbLoanFilter.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Approved",
            "Disbursed",
            "Rejected"});
            this.cbLoanFilter.Location = new System.Drawing.Point(631, 70);
            this.cbLoanFilter.Name = "cbLoanFilter";
            this.cbLoanFilter.Size = new System.Drawing.Size(76, 21);
            this.cbLoanFilter.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(713, 68);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(57, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbLoanFilter);
            this.Controls.Add(this.dgvLoanList);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Loans";
            this.Size = new System.Drawing.Size(862, 630);
           
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoanList;
        private DataGridViewTextBoxColumn Loanee;
        private DataGridViewTextBoxColumn Loan_Amount;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn actionButton;
        private DataGridViewTextBoxColumn LoanID;
        private DataGridViewTextBoxColumn Column1;
        private ComboBox cbLoanFilter;
        private Button btnSubmit;
    }
}
