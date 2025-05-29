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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.userInfoLname = new System.Windows.Forms.Label();
            this.userInfoFname = new System.Windows.Forms.Label();
            this.userInfoDbirth = new System.Windows.Forms.Label();
            this.userInfoStatus = new System.Windows.Forms.Label();
            this.btnApproveStatus = new System.Windows.Forms.Button();
            this.btnRejectStatus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userInfoMincome = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.userInfoEstatus = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userInfoPnumber = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.userInfoAddress = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnApprove = new LoanManagementSystem.RoundedButton();
            this.btnReject = new LoanManagementSystem.RoundedButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.User.Location = new System.Drawing.Point(36, 47);
            this.User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(238, 28);
            this.User.TabIndex = 0;
            this.User.Text = "CLIENT INFORMATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "General Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(24, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(26, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(26, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of Birth:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(26, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Employment Status:";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fName.Location = new System.Drawing.Point(36, 119);
            this.fName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(0, 15);
            this.fName.TabIndex = 11;
            // 
            // userInfoLname
            // 
            this.userInfoLname.AutoSize = true;
            this.userInfoLname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoLname.ForeColor = System.Drawing.Color.White;
            this.userInfoLname.Location = new System.Drawing.Point(167, 58);
            this.userInfoLname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoLname.Name = "userInfoLname";
            this.userInfoLname.Size = new System.Drawing.Size(64, 17);
            this.userInfoLname.TabIndex = 12;
            this.userInfoLname.Text = "lastname";
            // 
            // userInfoFname
            // 
            this.userInfoFname.AutoSize = true;
            this.userInfoFname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoFname.ForeColor = System.Drawing.Color.White;
            this.userInfoFname.Location = new System.Drawing.Point(167, 104);
            this.userInfoFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoFname.Name = "userInfoFname";
            this.userInfoFname.Size = new System.Drawing.Size(67, 17);
            this.userInfoFname.TabIndex = 13;
            this.userInfoFname.Text = "firstname";
            // 
            // userInfoDbirth
            // 
            this.userInfoDbirth.AutoSize = true;
            this.userInfoDbirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoDbirth.ForeColor = System.Drawing.Color.White;
            this.userInfoDbirth.Location = new System.Drawing.Point(167, 152);
            this.userInfoDbirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoDbirth.Name = "userInfoDbirth";
            this.userInfoDbirth.Size = new System.Drawing.Size(88, 17);
            this.userInfoDbirth.TabIndex = 18;
            this.userInfoDbirth.Text = "Date of birth";
            // 
            // userInfoStatus
            // 
            this.userInfoStatus.AutoSize = true;
            this.userInfoStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.userInfoStatus.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.userInfoStatus.Location = new System.Drawing.Point(38, 88);
            this.userInfoStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoStatus.Name = "userInfoStatus";
            this.userInfoStatus.Size = new System.Drawing.Size(53, 20);
            this.userInfoStatus.TabIndex = 19;
            this.userInfoStatus.Text = "Status";
            // 
            // btnApproveStatus
            // 
            this.btnApproveStatus.Location = new System.Drawing.Point(0, 0);
            this.btnApproveStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnApproveStatus.Name = "btnApproveStatus";
            this.btnApproveStatus.Size = new System.Drawing.Size(56, 19);
            this.btnApproveStatus.TabIndex = 27;
            // 
            // btnRejectStatus
            // 
            this.btnRejectStatus.Location = new System.Drawing.Point(0, 0);
            this.btnRejectStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnRejectStatus.Name = "btnRejectStatus";
            this.btnRejectStatus.Size = new System.Drawing.Size(56, 19);
            this.btnRejectStatus.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.userInfoFname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.fName);
            this.panel1.Controls.Add(this.userInfoLname);
            this.panel1.Controls.Add(this.userInfoDbirth);
            this.panel1.Location = new System.Drawing.Point(41, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 197);
            this.panel1.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.userInfoMincome);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.userInfoEstatus);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(41, 391);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 197);
            this.panel4.TabIndex = 29;
            // 
            // userInfoMincome
            // 
            this.userInfoMincome.AutoSize = true;
            this.userInfoMincome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoMincome.ForeColor = System.Drawing.Color.White;
            this.userInfoMincome.Location = new System.Drawing.Point(167, 124);
            this.userInfoMincome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoMincome.Name = "userInfoMincome";
            this.userInfoMincome.Size = new System.Drawing.Size(109, 17);
            this.userInfoMincome.TabIndex = 21;
            this.userInfoMincome.Text = "Monthly income";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(26, 124);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "Monthly Income:";
            // 
            // userInfoEstatus
            // 
            this.userInfoEstatus.AutoSize = true;
            this.userInfoEstatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoEstatus.ForeColor = System.Drawing.Color.White;
            this.userInfoEstatus.Location = new System.Drawing.Point(167, 76);
            this.userInfoEstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoEstatus.Name = "userInfoEstatus";
            this.userInfoEstatus.Size = new System.Drawing.Size(127, 17);
            this.userInfoEstatus.TabIndex = 19;
            this.userInfoEstatus.Text = "Employment status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(19, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Employment Details";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(36, 141);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 15);
            this.label17.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.userInfoPnumber);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.userInfoAddress);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Location = new System.Drawing.Point(427, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 197);
            this.panel2.TabIndex = 30;
            // 
            // userInfoPnumber
            // 
            this.userInfoPnumber.AutoSize = true;
            this.userInfoPnumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoPnumber.ForeColor = System.Drawing.Color.White;
            this.userInfoPnumber.Location = new System.Drawing.Point(167, 124);
            this.userInfoPnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoPnumber.Name = "userInfoPnumber";
            this.userInfoPnumber.Size = new System.Drawing.Size(99, 17);
            this.userInfoPnumber.TabIndex = 25;
            this.userInfoPnumber.Text = "Phone number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(26, 124);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Phone Number:";
            // 
            // userInfoAddress
            // 
            this.userInfoAddress.AutoSize = true;
            this.userInfoAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoAddress.ForeColor = System.Drawing.Color.White;
            this.userInfoAddress.Location = new System.Drawing.Point(167, 74);
            this.userInfoAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoAddress.Name = "userInfoAddress";
            this.userInfoAddress.Size = new System.Drawing.Size(57, 17);
            this.userInfoAddress.TabIndex = 23;
            this.userInfoAddress.Text = "Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(26, 74);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 22;
            this.label16.Text = "Address:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(19, 11);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Contact Details";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(36, 137);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 15);
            this.label19.TabIndex = 11;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(737, 41);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(88, 34);
            this.btnApprove.TabIndex = 25;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Red;
            this.btnReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(616, 41);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(88, 34);
            this.btnReject.TabIndex = 24;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnRejectStatus);
            this.Controls.Add(this.btnApproveStatus);
            this.Controls.Add(this.userInfoStatus);
            this.Controls.Add(this.User);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(965, 492);
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label userInfoLname;
        private System.Windows.Forms.Label userInfoFname;
        private System.Windows.Forms.Label userInfoDbirth;
        private System.Windows.Forms.Label userInfoStatus;
        private System.Windows.Forms.Button btnApproveStatus;
        private System.Windows.Forms.Button btnRejectStatus;
        private RoundedButton btnReject;
        private RoundedButton btnApprove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label userInfoMincome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label userInfoEstatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userInfoPnumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label userInfoAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}
