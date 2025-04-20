namespace LoanManagementSystem
{
    partial class UserForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.lblStatusDesc = new System.Windows.Forms.Label();
            this.btnApplyLoan = new System.Windows.Forms.Button();
            this.LoanApplicationPanel = new System.Windows.Forms.Panel();
            this.LoanApplicationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "label1";
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Location = new System.Drawing.Point(12, 52);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(35, 13);
            this.lblUserStatus.TabIndex = 1;
            this.lblUserStatus.Text = "label1";
            // 
            // lblStatusDesc
            // 
            this.lblStatusDesc.AutoSize = true;
            this.lblStatusDesc.Location = new System.Drawing.Point(12, 85);
            this.lblStatusDesc.Name = "lblStatusDesc";
            this.lblStatusDesc.Size = new System.Drawing.Size(35, 13);
            this.lblStatusDesc.TabIndex = 2;
            this.lblStatusDesc.Text = "label1";
            // 
            // btnApplyLoan
            // 
            this.btnApplyLoan.Location = new System.Drawing.Point(280, 404);
            this.btnApplyLoan.Name = "btnApplyLoan";
            this.btnApplyLoan.Size = new System.Drawing.Size(227, 34);
            this.btnApplyLoan.TabIndex = 3;
            this.btnApplyLoan.Text = "Apply Loan";
            this.btnApplyLoan.UseVisualStyleBackColor = true;
            this.btnApplyLoan.Click += new System.EventHandler(this.btnApplyLoan_Click);
            // 
            // LoanApplicationPanel
            // 
            this.LoanApplicationPanel.Controls.Add(this.btnApplyLoan);
            this.LoanApplicationPanel.Controls.Add(this.lblStatusDesc);
            this.LoanApplicationPanel.Controls.Add(this.lblUserStatus);
            this.LoanApplicationPanel.Controls.Add(this.lblUsername);
            this.LoanApplicationPanel.Location = new System.Drawing.Point(0, 0);
            this.LoanApplicationPanel.Name = "LoanApplicationPanel";
            this.LoanApplicationPanel.Size = new System.Drawing.Size(801, 453);
            this.LoanApplicationPanel.TabIndex = 4;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoanApplicationPanel);
            this.Name = "UserForm";
            this.Text = "Dashboard";
            this.LoanApplicationPanel.ResumeLayout(false);
            this.LoanApplicationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.Label lblStatusDesc;
        private System.Windows.Forms.Button btnApplyLoan;
        private System.Windows.Forms.Panel LoanApplicationPanel;
    }
}