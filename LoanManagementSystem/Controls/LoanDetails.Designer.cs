namespace LoanManagementSystem.Controls
{
    partial class LoanDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.lblLoanee = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblLoanPurpose = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDisburse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gontserrat Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOAN DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loanee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(28, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(28, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Term";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(28, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Purpose of Loan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(354, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Active Loans";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(354, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status";
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReject.Location = new System.Drawing.Point(461, 476);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(121, 33);
            this.btnReject.TabIndex = 7;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnApprove.Location = new System.Drawing.Point(618, 476);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(121, 33);
            this.btnApprove.TabIndex = 8;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // lblLoanee
            // 
            this.lblLoanee.AutoSize = true;
            this.lblLoanee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanee.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblLoanee.Location = new System.Drawing.Point(36, 118);
            this.lblLoanee.Name = "lblLoanee";
            this.lblLoanee.Size = new System.Drawing.Size(44, 16);
            this.lblLoanee.TabIndex = 9;
            this.lblLoanee.Text = "label8";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblAmount.Location = new System.Drawing.Point(36, 194);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(44, 16);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "label9";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblTerm.Location = new System.Drawing.Point(36, 286);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(51, 16);
            this.lblTerm.TabIndex = 11;
            this.lblTerm.Text = "label10";
            // 
            // lblLoanPurpose
            // 
            this.lblLoanPurpose.AutoSize = true;
            this.lblLoanPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanPurpose.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblLoanPurpose.Location = new System.Drawing.Point(36, 370);
            this.lblLoanPurpose.Name = "lblLoanPurpose";
            this.lblLoanPurpose.Size = new System.Drawing.Size(51, 16);
            this.lblLoanPurpose.TabIndex = 12;
            this.lblLoanPurpose.Text = "label11";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblStatus.Location = new System.Drawing.Point(363, 273);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 16);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "label12";
            // 
            // btnDisburse
            // 
            this.btnDisburse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDisburse.Location = new System.Drawing.Point(537, 476);
            this.btnDisburse.Name = "btnDisburse";
            this.btnDisburse.Size = new System.Drawing.Size(121, 33);
            this.btnDisburse.TabIndex = 14;
            this.btnDisburse.Text = "Disburse";
            this.btnDisburse.UseVisualStyleBackColor = false;
            this.btnDisburse.Click += new System.EventHandler(this.btnDisburse_Click);
            // 
            // LoanDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.btnDisburse);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLoanPurpose);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblLoanee);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoanDetails";
            this.Size = new System.Drawing.Size(862, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label lblLoanee;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblLoanPurpose;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDisburse;
    }
}
