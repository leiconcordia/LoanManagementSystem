using System;
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbLoanSearch = new System.Windows.Forms.TextBox();
            this.cbLoanFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 79);
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
            this.dgvLoanList.Location = new System.Drawing.Point(69, 126);
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(0, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            // 
            // tbLoanSearch
            // 
            this.tbLoanSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(69)))));
            this.tbLoanSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLoanSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbLoanSearch.ForeColor = System.Drawing.Color.White;
            this.tbLoanSearch.Location = new System.Drawing.Point(662, 82);
            this.tbLoanSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLoanSearch.Name = "tbLoanSearch";
            this.tbLoanSearch.Size = new System.Drawing.Size(131, 25);
            this.tbLoanSearch.TabIndex = 4;
            this.tbLoanSearch.TextChanged += new System.EventHandler(this.tbLoanSearch_TextChanged);
            // 
            // cbLoanFilter
            // 
            this.cbLoanFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(69)))));
            this.cbLoanFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoanFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoanFilter.ForeColor = System.Drawing.Color.White;
            this.cbLoanFilter.FormattingEnabled = true;
            this.cbLoanFilter.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Approved",
            "Disbursed",
            "Rejected",
            "Completed"});
            this.cbLoanFilter.Location = new System.Drawing.Point(169, 88);
            this.cbLoanFilter.Name = "cbLoanFilter";
            this.cbLoanFilter.Size = new System.Drawing.Size(98, 21);
            this.cbLoanFilter.SelectedItem = "All";
            this.cbLoanFilter.TabIndex = 0;
            this.cbLoanFilter.SelectedIndexChanged += new System.EventHandler(this.cbLoanFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search:";
            // 
            // Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLoanSearch);
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

        private void TbLoanSearch_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private TextBox tbLoanSearch;
        private Label label2;
    }
}
