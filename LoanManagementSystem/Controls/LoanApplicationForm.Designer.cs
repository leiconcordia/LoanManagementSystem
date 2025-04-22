namespace LoanManagementSystem.Controls
{
    partial class LoanApplicationForm
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
            this.tbLoanAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLoanTerm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoanPurpose = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUploadProof = new System.Windows.Forms.Button();
            this.btnUploadID = new System.Windows.Forms.Button();
            this.pbProof = new System.Windows.Forms.PictureBox();
            this.pbID = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOAN APPLICATION FORM";
            // 
            // tbLoanAmount
            // 
            this.tbLoanAmount.Location = new System.Drawing.Point(20, 103);
            this.tbLoanAmount.Multiline = true;
            this.tbLoanAmount.Name = "tbLoanAmount";
            this.tbLoanAmount.Size = new System.Drawing.Size(150, 24);
            this.tbLoanAmount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loan amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Term";
            // 
            // cbLoanTerm
            // 
            this.cbLoanTerm.FormattingEnabled = true;
            this.cbLoanTerm.Items.AddRange(new object[] {
            "3 months to pay",
            "6 months to pay",
            "9 months to pay",
            "1 year to pay",
            "2 years to pay",
            "3 years to pay"});
            this.cbLoanTerm.Location = new System.Drawing.Point(20, 168);
            this.cbLoanTerm.Name = "cbLoanTerm";
            this.cbLoanTerm.Size = new System.Drawing.Size(95, 21);
            this.cbLoanTerm.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Purpose of Loan ";
            // 
            // cbLoanPurpose
            // 
            this.cbLoanPurpose.FormattingEnabled = true;
            this.cbLoanPurpose.Items.AddRange(new object[] {
            "Personal",
            "Business",
            "Emergency",
            "Education",
            "Medical bills"});
            this.cbLoanPurpose.Location = new System.Drawing.Point(20, 247);
            this.cbLoanPurpose.Name = "cbLoanPurpose";
            this.cbLoanPurpose.Size = new System.Drawing.Size(95, 21);
            this.cbLoanPurpose.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Preferred Monthly Payment Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 338);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 37);
            this.label9.TabIndex = 12;
            this.label9.Text = "Loan Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Document upload";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(445, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(342, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Upload Payslip/Proof of Income";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Upload Valid ID";
            // 
            // btnUploadProof
            // 
            this.btnUploadProof.Location = new System.Drawing.Point(683, 372);
            this.btnUploadProof.Name = "btnUploadProof";
            this.btnUploadProof.Size = new System.Drawing.Size(78, 26);
            this.btnUploadProof.TabIndex = 16;
            this.btnUploadProof.Text = "Upload";
            this.btnUploadProof.UseVisualStyleBackColor = true;
            // 
            // btnUploadID
            // 
            this.btnUploadID.Location = new System.Drawing.Point(683, 195);
            this.btnUploadID.Name = "btnUploadID";
            this.btnUploadID.Size = new System.Drawing.Size(78, 26);
            this.btnUploadID.TabIndex = 17;
            this.btnUploadID.Text = "Upload";
            this.btnUploadID.UseVisualStyleBackColor = true;
            // 
            // pbProof
            // 
            this.pbProof.Location = new System.Drawing.Point(454, 130);
            this.pbProof.Name = "pbProof";
            this.pbProof.Size = new System.Drawing.Size(217, 80);
            this.pbProof.TabIndex = 18;
            this.pbProof.TabStop = false;
            // 
            // pbID
            // 
            this.pbID.Location = new System.Drawing.Point(454, 278);
            this.pbID.Name = "pbID";
            this.pbID.Size = new System.Drawing.Size(217, 80);
            this.pbID.TabIndex = 19;
            this.pbID.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Location = new System.Drawing.Point(629, 421);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(169, 29);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Calculate monthly payment";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // LoanApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pbID);
            this.Controls.Add(this.pbProof);
            this.Controls.Add(this.btnUploadID);
            this.Controls.Add(this.btnUploadProof);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbLoanPurpose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLoanTerm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLoanAmount);
            this.Controls.Add(this.label1);
            this.Name = "LoanApplicationForm";
            this.Size = new System.Drawing.Size(801, 453);
            ((System.ComponentModel.ISupportInitialize)(this.pbProof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLoanAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLoanTerm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoanPurpose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUploadProof;
        private System.Windows.Forms.Button btnUploadID;
        private System.Windows.Forms.PictureBox pbProof;
        private System.Windows.Forms.PictureBox pbID;
        private System.Windows.Forms.Button btnNext;
    }
}
