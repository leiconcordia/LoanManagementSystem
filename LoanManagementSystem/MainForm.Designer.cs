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
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnDisbursements = new System.Windows.Forms.Button();
            this.btnContactUs = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnUserEvaluation = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 750);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel5_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLogout.Location = new System.Drawing.Point(3, 422);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(205, 65);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            // btnDisbursements
            // 
            this.btnDisbursements.FlatAppearance.BorderSize = 0;
            this.btnDisbursements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisbursements.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDisbursements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDisbursements.Location = new System.Drawing.Point(3, 352);
            this.btnDisbursements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisbursements.Name = "btnDisbursements";
            this.btnDisbursements.Size = new System.Drawing.Size(205, 65);
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
            // btnLoan
            // 
            this.btnLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoan.FlatAppearance.BorderSize = 0;
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoan.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLoan.Location = new System.Drawing.Point(0, 279);
            this.btnLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(208, 73);
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
            this.btnUserEvaluation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUserEvaluation.Location = new System.Drawing.Point(0, 199);
            this.btnUserEvaluation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserEvaluation.Name = "btnUserEvaluation";
            this.btnUserEvaluation.Size = new System.Drawing.Size(208, 80);
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
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 123);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(208, 76);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "   Dashboard";
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
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(209, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1149, 775);
            this.MainPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1357, 750);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.panel5_Click);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;


        #region Windows Form Designer generated code



        #endregion
        private Panel MainPanel;
        private Button btnLogout;
    }
}