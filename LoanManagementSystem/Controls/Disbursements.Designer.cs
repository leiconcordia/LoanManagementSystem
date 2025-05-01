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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDisbursements = new System.Windows.Forms.DataGridView();
            this.LoaneeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisbursedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisbursements)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gontserrat Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "DISBURSEMENTS";
            // 
            // dgvDisbursements
            // 
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDisbursements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisbursements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisbursements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaneeName,
            this.LoanAmount,
            this.DisbursedDate});
            this.dgvDisbursements.Location = new System.Drawing.Point(53, 104);
            this.dgvDisbursements.Name = "dgvDisbursements";
            this.dgvDisbursements.Size = new System.Drawing.Size(698, 318);
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
            // Disbursements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
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
    }
}
