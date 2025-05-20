using System.Drawing;

namespace LoanManagementSystem.Controls
{
    partial class UserInfo
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
            this.User = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.userInfoLname = new System.Windows.Forms.Label();
            this.userInfoFname = new System.Windows.Forms.Label();
            this.userInfoAddress = new System.Windows.Forms.Label();
            this.userInfoPnumber = new System.Windows.Forms.Label();
            this.userInfoEstatus = new System.Windows.Forms.Label();
            this.userInfoMincome = new System.Windows.Forms.Label();
            this.userInfoDbirth = new System.Windows.Forms.Label();
            this.userInfoStatus = new System.Windows.Forms.Label();
            this.btnApproveStatus = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRejectStatus = new System.Windows.Forms.Button();
            this.btnBacktoUserEval = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.User.Location = new System.Drawing.Point(36, 29);
            this.User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(353, 41);
            this.User.TabIndex = 0;
            this.User.Text = "CLIENT INFORMATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(49, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(454, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employment Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(66, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(66, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(66, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(59, 348);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(59, 385);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(466, 179);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Employment Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(466, 216);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Monthly Income";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fName.Location = new System.Drawing.Point(66, 217);
            this.fName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(0, 25);
            this.fName.TabIndex = 11;
            // 
            // userInfoLname
            // 
            this.userInfoLname.AutoSize = true;
            this.userInfoLname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.userInfoLname.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.userInfoLname.Location = new System.Drawing.Point(177, 165);
            this.userInfoLname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoLname.Name = "userInfoLname";
            this.userInfoLname.Size = new System.Drawing.Size(89, 25);
            this.userInfoLname.TabIndex = 12;
            this.userInfoLname.Text = "lastname";
            // 
            // userInfoFname
            // 
            this.userInfoFname.AutoSize = true;
            this.userInfoFname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.userInfoFname.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.userInfoFname.Location = new System.Drawing.Point(177, 195);
            this.userInfoFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoFname.Name = "userInfoFname";
            this.userInfoFname.Size = new System.Drawing.Size(93, 25);
            this.userInfoFname.TabIndex = 13;
            this.userInfoFname.Text = "firstname";
            // 
            // userInfoAddress
            // 
            this.userInfoAddress.AutoSize = true;
            this.userInfoAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.userInfoAddress.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.userInfoAddress.Location = new System.Drawing.Point(147, 348);
            this.userInfoAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoAddress.Name = "userInfoAddress";
            this.userInfoAddress.Size = new System.Drawing.Size(80, 25);
            this.userInfoAddress.TabIndex = 14;
            this.userInfoAddress.Text = "Address";
            // 
            // userInfoPnumber
            // 
            this.userInfoPnumber.AutoSize = true;
            this.userInfoPnumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.userInfoPnumber.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.userInfoPnumber.Location = new System.Drawing.Point(204, 385);
            this.userInfoPnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoPnumber.Name = "userInfoPnumber";
            this.userInfoPnumber.Size = new System.Drawing.Size(137, 25);
            this.userInfoPnumber.TabIndex = 15;
            this.userInfoPnumber.Text = "Phone number";
            // 
            // userInfoEstatus
            // 
            this.userInfoEstatus.AutoSize = true;
            this.userInfoEstatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.userInfoEstatus.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.userInfoEstatus.Location = new System.Drawing.Point(651, 179);
            this.userInfoEstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoEstatus.Name = "userInfoEstatus";
            this.userInfoEstatus.Size = new System.Drawing.Size(157, 21);
            this.userInfoEstatus.TabIndex = 16;
            this.userInfoEstatus.Text = "Employment status";
            // 
            // userInfoMincome
            // 
            this.userInfoMincome.AutoSize = true;
            this.userInfoMincome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.userInfoMincome.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.userInfoMincome.Location = new System.Drawing.Point(626, 217);
            this.userInfoMincome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoMincome.Name = "userInfoMincome";
            this.userInfoMincome.Size = new System.Drawing.Size(136, 21);
            this.userInfoMincome.TabIndex = 17;
            this.userInfoMincome.Text = "Monthly income";
            // 
            // userInfoDbirth
            // 
            this.userInfoDbirth.AutoSize = true;
            this.userInfoDbirth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.userInfoDbirth.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.userInfoDbirth.Location = new System.Drawing.Point(197, 225);
            this.userInfoDbirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoDbirth.Name = "userInfoDbirth";
            this.userInfoDbirth.Size = new System.Drawing.Size(122, 25);
            this.userInfoDbirth.TabIndex = 18;
            this.userInfoDbirth.Text = "Date of birth";
            // 
            // userInfoStatus
            // 
            this.userInfoStatus.AutoSize = true;
            this.userInfoStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.userInfoStatus.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.userInfoStatus.Location = new System.Drawing.Point(553, 334);
            this.userInfoStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoStatus.Name = "userInfoStatus";
            this.userInfoStatus.Size = new System.Drawing.Size(65, 25);
            this.userInfoStatus.TabIndex = 19;
            this.userInfoStatus.Text = "Status";
            // 
            // btnApproveStatus
            // 
            this.btnApproveStatus.BackColor = System.Drawing.Color.LightGreen;
            this.btnApproveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproveStatus.Location = new System.Drawing.Point(257, 664);
            this.btnApproveStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApproveStatus.Name = "btnApproveStatus";
            this.btnApproveStatus.Size = new System.Drawing.Size(150, 50);
            this.btnApproveStatus.TabIndex = 22;
            this.btnApproveStatus.Text = "Approve";
            this.btnApproveStatus.UseVisualStyleBackColor = false;
            this.btnApproveStatus.Click += new System.EventHandler(this.btnApproveStatus_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(466, 334);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Status";
            // 
            // btnRejectStatus
            // 
            this.btnRejectStatus.BackColor = System.Drawing.Color.LightCoral;
            this.btnRejectStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejectStatus.Location = new System.Drawing.Point(424, 664);
            this.btnRejectStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRejectStatus.Name = "btnRejectStatus";
            this.btnRejectStatus.Size = new System.Drawing.Size(150, 50);
            this.btnRejectStatus.TabIndex = 0;
            this.btnRejectStatus.Text = "Reject";
            this.btnRejectStatus.UseVisualStyleBackColor = false;
            this.btnRejectStatus.Click += new System.EventHandler(this.btnRejectStatus_Click);
            // 
            // btnBacktoUserEval
            // 
            this.btnBacktoUserEval.Location = new System.Drawing.Point(714, 29);
            this.btnBacktoUserEval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBacktoUserEval.Name = "btnBacktoUserEval";
            this.btnBacktoUserEval.Size = new System.Drawing.Size(84, 41);
            this.btnBacktoUserEval.TabIndex = 23;
            this.btnBacktoUserEval.Text = "Back";
            this.btnBacktoUserEval.UseVisualStyleBackColor = true;
            this.btnBacktoUserEval.Click += new System.EventHandler(this.btnBacktoUserEval_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnBacktoUserEval);
            this.Controls.Add(this.btnRejectStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnApproveStatus);
            this.Controls.Add(this.userInfoStatus);
            this.Controls.Add(this.userInfoDbirth);
            this.Controls.Add(this.userInfoMincome);
            this.Controls.Add(this.userInfoEstatus);
            this.Controls.Add(this.userInfoPnumber);
            this.Controls.Add(this.userInfoAddress);
            this.Controls.Add(this.userInfoFname);
            this.Controls.Add(this.userInfoLname);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(965, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label userInfoLname;
        private System.Windows.Forms.Label userInfoFname;
        private System.Windows.Forms.Label userInfoAddress;
        private System.Windows.Forms.Label userInfoPnumber;
        private System.Windows.Forms.Label userInfoEstatus;
        private System.Windows.Forms.Label userInfoMincome;
        private System.Windows.Forms.Label userInfoDbirth;
        private System.Windows.Forms.Label userInfoStatus;
        private System.Windows.Forms.Button btnApproveStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRejectStatus;
        private System.Windows.Forms.Button btnBacktoUserEval;
    }
}
