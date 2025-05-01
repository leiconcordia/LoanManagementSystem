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
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.User.Location = new System.Drawing.Point(24, 19);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(329, 31);
            this.User.TabIndex = 0;
            this.User.Text = "CLIENT INFORMATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTACT INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONTACT DETAILS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(24, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "EMPLOYMENT DETAILS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Employment status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Monthly income";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Location = new System.Drawing.Point(44, 141);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(0, 13);
            this.fName.TabIndex = 11;
            // 
            // userInfoLname
            // 
            this.userInfoLname.AutoSize = true;
            this.userInfoLname.Location = new System.Drawing.Point(40, 154);
            this.userInfoLname.Name = "userInfoLname";
            this.userInfoLname.Size = new System.Drawing.Size(49, 13);
            this.userInfoLname.TabIndex = 12;
            this.userInfoLname.Text = "lastname";
            // 
            // userInfoFname
            // 
            this.userInfoFname.AutoSize = true;
            this.userInfoFname.Location = new System.Drawing.Point(147, 154);
            this.userInfoFname.Name = "userInfoFname";
            this.userInfoFname.Size = new System.Drawing.Size(49, 13);
            this.userInfoFname.TabIndex = 13;
            this.userInfoFname.Text = "firstname";
            // 
            // userInfoAddress
            // 
            this.userInfoAddress.AutoSize = true;
            this.userInfoAddress.Location = new System.Drawing.Point(40, 295);
            this.userInfoAddress.Name = "userInfoAddress";
            this.userInfoAddress.Size = new System.Drawing.Size(45, 13);
            this.userInfoAddress.TabIndex = 14;
            this.userInfoAddress.Text = "Address";
            // 
            // userInfoPnumber
            // 
            this.userInfoPnumber.AutoSize = true;
            this.userInfoPnumber.Location = new System.Drawing.Point(147, 295);
            this.userInfoPnumber.Name = "userInfoPnumber";
            this.userInfoPnumber.Size = new System.Drawing.Size(76, 13);
            this.userInfoPnumber.TabIndex = 15;
            this.userInfoPnumber.Text = "Phone number";
            // 
            // userInfoEstatus
            // 
            this.userInfoEstatus.AutoSize = true;
            this.userInfoEstatus.Location = new System.Drawing.Point(40, 431);
            this.userInfoEstatus.Name = "userInfoEstatus";
            this.userInfoEstatus.Size = new System.Drawing.Size(95, 13);
            this.userInfoEstatus.TabIndex = 16;
            this.userInfoEstatus.Text = "Employment status";
            // 
            // userInfoMincome
            // 
            this.userInfoMincome.AutoSize = true;
            this.userInfoMincome.Location = new System.Drawing.Point(147, 431);
            this.userInfoMincome.Name = "userInfoMincome";
            this.userInfoMincome.Size = new System.Drawing.Size(81, 13);
            this.userInfoMincome.TabIndex = 17;
            this.userInfoMincome.Text = "Monthly income";
            // 
            // userInfoDbirth
            // 
            this.userInfoDbirth.AutoSize = true;
            this.userInfoDbirth.Location = new System.Drawing.Point(40, 202);
            this.userInfoDbirth.Name = "userInfoDbirth";
            this.userInfoDbirth.Size = new System.Drawing.Size(65, 13);
            this.userInfoDbirth.TabIndex = 18;
            this.userInfoDbirth.Text = "Date of birth";
            // 
            // userInfoStatus
            // 
            this.userInfoStatus.AutoSize = true;
            this.userInfoStatus.Location = new System.Drawing.Point(418, 128);
            this.userInfoStatus.Name = "userInfoStatus";
            this.userInfoStatus.Size = new System.Drawing.Size(37, 13);
            this.userInfoStatus.TabIndex = 19;
            this.userInfoStatus.Text = "Status";
            // 
            // btnApproveStatus
            // 
            this.btnApproveStatus.BackColor = System.Drawing.Color.LightGreen;
            this.btnApproveStatus.Location = new System.Drawing.Point(489, 440);
            this.btnApproveStatus.Name = "btnApproveStatus";
            this.btnApproveStatus.Size = new System.Drawing.Size(100, 30);
            this.btnApproveStatus.TabIndex = 22;
            this.btnApproveStatus.Text = "Approve";
            this.btnApproveStatus.UseVisualStyleBackColor = false;
            this.btnApproveStatus.Click += new System.EventHandler(this.btnApproveStatus_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Status";
            // 
            // btnRejectStatus
            // 
            this.btnRejectStatus.BackColor = System.Drawing.Color.LightCoral;
            this.btnRejectStatus.Location = new System.Drawing.Point(595, 440);
            this.btnRejectStatus.Name = "btnRejectStatus";
            this.btnRejectStatus.Size = new System.Drawing.Size(100, 30);
            this.btnRejectStatus.TabIndex = 0;
            this.btnRejectStatus.Text = "Reject";
            this.btnRejectStatus.UseVisualStyleBackColor = false;
            this.btnRejectStatus.Click += new System.EventHandler(this.btnRejectStatus_Click);
            // 
            // btnBacktoUserEval
            // 
            this.btnBacktoUserEval.Location = new System.Drawing.Point(685, 21);
            this.btnBacktoUserEval.Name = "btnBacktoUserEval";
            this.btnBacktoUserEval.Size = new System.Drawing.Size(76, 28);
            this.btnBacktoUserEval.TabIndex = 23;
            this.btnBacktoUserEval.Text = "Back";
            this.btnBacktoUserEval.UseVisualStyleBackColor = true;
            this.btnBacktoUserEval.Click += new System.EventHandler(this.btnBacktoUserEval_Click);
            // 
            // UserInfo
            // 
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
