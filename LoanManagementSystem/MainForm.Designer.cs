using System;
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
            this.btnChangeInterest = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnDisbursements = new System.Windows.Forms.Button();
            this.btnContactUs = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnUserEvaluation = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnChangeInterest);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnDisbursements);
            this.panel1.Controls.Add(this.btnContactUs);
            this.panel1.Controls.Add(this.btnLoan);
            this.panel1.Controls.Add(this.btnUserEvaluation);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 609);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel5_Click);
            // 
            // btnChangeInterest
            // 
            this.btnChangeInterest.FlatAppearance.BorderSize = 0;
            this.btnChangeInterest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeInterest.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangeInterest.ForeColor = System.Drawing.Color.LightBlue;
            this.btnChangeInterest.Location = new System.Drawing.Point(2, 343);
            this.btnChangeInterest.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeInterest.Name = "btnChangeInterest";
            this.btnChangeInterest.Size = new System.Drawing.Size(154, 53);
            this.btnChangeInterest.TabIndex = 7;
            this.btnChangeInterest.Text = "Change interest rate";
            this.btnChangeInterest.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnChangeInterest.UseVisualStyleBackColor = true;
            this.btnChangeInterest.Click += new System.EventHandler(this.btnChangeInterest_Click);
           
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogout.Location = new System.Drawing.Point(2, 556);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(154, 53);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 101);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(2, 52);
            this.pnlNav.TabIndex = 3;
            // 
            // btnDisbursements
            // 
            this.btnDisbursements.FlatAppearance.BorderSize = 0;
            this.btnDisbursements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisbursements.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDisbursements.ForeColor = System.Drawing.Color.LightBlue;
            this.btnDisbursements.Location = new System.Drawing.Point(2, 286);
            this.btnDisbursements.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisbursements.Name = "btnDisbursements";
            this.btnDisbursements.Size = new System.Drawing.Size(154, 53);
            this.btnDisbursements.TabIndex = 5;
            this.btnDisbursements.Text = "  Disubursements";
            this.btnDisbursements.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDisbursements.UseVisualStyleBackColor = true;
            this.btnDisbursements.Click += new System.EventHandler(this.btnDisbursements_Click);
            this.btnDisbursements.Leave += new System.EventHandler(this.btnDisbursements_Leave);
            // 
            // btnContactUs
            // 
            this.btnContactUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContactUs.FlatAppearance.BorderSize = 0;
            this.btnContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactUs.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnContactUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnContactUs.Location = new System.Drawing.Point(0, 286);
            this.btnContactUs.Margin = new System.Windows.Forms.Padding(2);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Size = new System.Drawing.Size(156, 38);
            this.btnContactUs.TabIndex = 4;
            this.btnContactUs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnContactUs.UseVisualStyleBackColor = true;
            this.btnContactUs.Click += new System.EventHandler(this.btnContactUs_Click);
            this.btnContactUs.Leave += new System.EventHandler(this.btnContactUs_Leave);
            // 
            // btnLoan
            // 
            this.btnLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoan.FlatAppearance.BorderSize = 0;
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoan.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoan.ForeColor = System.Drawing.Color.LightBlue;
            this.btnLoan.Location = new System.Drawing.Point(0, 227);
            this.btnLoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(156, 59);
            this.btnLoan.TabIndex = 3;
            this.btnLoan.Text = "Loans";
            this.btnLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            this.btnLoan.Leave += new System.EventHandler(this.btnLoan_Leave);
            // 
            // btnUserEvaluation
            // 
            this.btnUserEvaluation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserEvaluation.FlatAppearance.BorderSize = 0;
            this.btnUserEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserEvaluation.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUserEvaluation.ForeColor = System.Drawing.Color.LightBlue;
            this.btnUserEvaluation.Location = new System.Drawing.Point(0, 162);
            this.btnUserEvaluation.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserEvaluation.Name = "btnUserEvaluation";
            this.btnUserEvaluation.Size = new System.Drawing.Size(156, 65);
            this.btnUserEvaluation.TabIndex = 1;
            this.btnUserEvaluation.Text = "User Evaluation";
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
            this.btnDashboard.ForeColor = System.Drawing.Color.LightBlue;
            this.btnDashboard.Location = new System.Drawing.Point(0, 100);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(156, 62);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 100);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoanManagementSystem.Properties.Resources.draft_logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, -13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.panel5_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(157, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(862, 630);
            this.MainPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1018, 609);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.panel5_Click);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pnlNav;
        private Button btnDisbursements;
        private Button btnContactUs;
        private Button btnLoan;
        private Button btnUserEvaluation;
        private Button btnDashboard;
        private Panel panel2;
        private PictureBox pictureBox1;


        #region Windows Form Designer generated code



        #endregion
        private Panel MainPanel;
        private Button btnLogout;
        private Button btnChangeInterest;
    }
}