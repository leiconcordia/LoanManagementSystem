namespace LoanManagementSystem.Controls
{
    partial class Disbursements
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDisbursements = new System.Windows.Forms.DataGridView();
            this.LoaneeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisbursedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearchDisbursement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisbursements)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DISBURSEMENTS";
            // 
            // dgvDisbursements
            // 
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDisbursements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisbursements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisbursements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaneeName,
            this.LoanAmount,
            this.DisbursedDate});
            this.dgvDisbursements.Location = new System.Drawing.Point(78, 130);
            this.dgvDisbursements.Name = "dgvDisbursements";
            this.dgvDisbursements.Size = new System.Drawing.Size(701, 410);
            this.dgvDisbursements.TabIndex = 2;
            // 
            // LoaneeName
            // 
            this.LoaneeName.HeaderText = "Loanee";
            this.LoaneeName.Name = "LoaneeName";
            this.LoaneeName.Width = 218;
            // 
            // LoanAmount
            // 
            this.LoanAmount.HeaderText = "LoanAmount";
            this.LoanAmount.Name = "LoanAmount";
            this.LoanAmount.Width = 219;
            // 
            // DisbursedDate
            // 
            this.DisbursedDate.HeaderText = "Disbursed Date";
            this.DisbursedDate.Name = "DisbursedDate";
            this.DisbursedDate.Width = 218;
            // 
            // tbSearchDisbursement
            // 
            this.tbSearchDisbursement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(69)))));
            this.tbSearchDisbursement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchDisbursement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbSearchDisbursement.ForeColor = System.Drawing.Color.White;
            this.tbSearchDisbursement.Location = new System.Drawing.Point(648, 82);
            this.tbSearchDisbursement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchDisbursement.Name = "tbSearchDisbursement";
            this.tbSearchDisbursement.Size = new System.Drawing.Size(131, 25);
            this.tbSearchDisbursement.TabIndex = 3;
            this.tbSearchDisbursement.TextChanged += new System.EventHandler(this.tbSearchDisbursement_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(581, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search:";
            // 
            // Disbursements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearchDisbursement);
            this.Controls.Add(this.dgvDisbursements);
            this.Controls.Add(this.label1);
            this.Name = "Disbursements";
            this.Size = new System.Drawing.Size(862, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisbursements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDisbursements;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaneeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisbursedDate;
        private System.Windows.Forms.TextBox tbSearchDisbursement;
        private System.Windows.Forms.Label label2;
    }
}
