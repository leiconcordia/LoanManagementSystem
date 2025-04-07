using System.Windows.Forms;

namespace LoanManagementSystem
{
    partial class MainForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnContactUs = new System.Windows.Forms.Button();
            this.btnCalender = new System.Windows.Forms.Button();
            this.btnUserEvaluation = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnContactUs);
            this.panel1.Controls.Add(this.btnCalender);
            this.panel1.Controls.Add(this.btnUserEvaluation);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 775);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LoanManagementSystem.Properties.Resources.dashboard_icon;
            this.pictureBox4.Location = new System.Drawing.Point(4, 136);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 124);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 64);
            this.pnlNav.TabIndex = 3;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Location = new System.Drawing.Point(3, 352);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(205, 65);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "  Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnContactUs
            // 
            this.btnContactUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContactUs.FlatAppearance.BorderSize = 0;
            this.btnContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactUs.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnContactUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnContactUs.Location = new System.Drawing.Point(0, 352);
            this.btnContactUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Size = new System.Drawing.Size(208, 47);
            this.btnContactUs.TabIndex = 4;
            this.btnContactUs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnContactUs.UseVisualStyleBackColor = true;
            this.btnContactUs.Click += new System.EventHandler(this.btnContactUs_Click);
            this.btnContactUs.Leave += new System.EventHandler(this.btnContactUs_Leave);
            // 
            // btnCalender
            // 
            this.btnCalender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalender.FlatAppearance.BorderSize = 0;
            this.btnCalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalender.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalender.Location = new System.Drawing.Point(0, 279);
            this.btnCalender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalender.Name = "btnCalender";
            this.btnCalender.Size = new System.Drawing.Size(208, 73);
            this.btnCalender.TabIndex = 3;
            this.btnCalender.Text = "  Calender";
            this.btnCalender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalender.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalender.UseVisualStyleBackColor = true;
            this.btnCalender.Click += new System.EventHandler(this.btnCalender_Click);
            this.btnCalender.Leave += new System.EventHandler(this.btnCalender_Leave);
            // 
            // btnUserEvaluation
            // 
            this.btnUserEvaluation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserEvaluation.FlatAppearance.BorderSize = 0;
            this.btnUserEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserEvaluation.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUserEvaluation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUserEvaluation.Location = new System.Drawing.Point(0, 199);
            this.btnUserEvaluation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserEvaluation.Name = "btnUserEvaluation";
            this.btnUserEvaluation.Size = new System.Drawing.Size(208, 80);
            this.btnUserEvaluation.TabIndex = 1;
            this.btnUserEvaluation.Text = "User Evaluation";
            this.btnUserEvaluation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserEvaluation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUserEvaluation.UseVisualStyleBackColor = true;
            this.btnUserEvaluation.Click += new System.EventHandler(this.btnUserEvaluation_Click);
            this.btnUserEvaluation.Leave += new System.EventHandler(this.btnUserEvaluation_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 123);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(208, 76);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 123);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(68, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADMIN";
            this.label2.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TITA NI DENOY";
            this.label1.Click += new System.EventHandler(this.panel5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoanManagementSystem.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(79, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(32, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dashboard";
            this.label3.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(32, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 103);
            this.panel3.TabIndex = 4;
            this.panel3.Click += new System.EventHandler(this.panel5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(127, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(11, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "$1234";
            this.label4.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(12, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Details of Last 28 Days";
            this.label6.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Earnings";
            this.label5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(288, 54);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 103);
            this.panel4.TabIndex = 4;
            this.panel4.Click += new System.EventHandler(this.panel5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(141, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label7.Location = new System.Drawing.Point(7, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 36);
            this.label7.TabIndex = 1;
            this.label7.Text = "12K+";
            this.label7.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 8F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label8.Location = new System.Drawing.Point(9, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Details of Last 28 Days";
            this.label8.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Active Loans";
            this.label9.Click += new System.EventHandler(this.panel5_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel4);
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Location = new System.Drawing.Point(209, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1150, 775);
            this.MainPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1358, 775);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.panel5_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pnlNav;
        private Button btnSettings;
        private Button btnContactUs;
        private Button btnCalender;
        private Button btnUserEvaluation;
        private Button btnDashboard;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;

        #region Windows Form Designer generated code



        #endregion

        private Label label3;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label6;
        private Label label5;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel MainPanel;
        private PictureBox pictureBox4;
    }
}