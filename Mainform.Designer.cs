namespace Tyrtyvshin
{
    partial class Mainform
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
            sidebarPanel = new Panel();
            btnNavSettings = new Button();
            btnNavReports = new Button();
            btnNavReviewers = new Button();
            btnNavMovies = new Button();
            navHeaderPanel = new Panel();
            lblAppName = new Label();
            btnNavLogout = new Button();
            topBarPanel = new Panel();
            lblPageTitle = new Label();
            contentPanel = new Panel();
            sidebarPanel.SuspendLayout();
            navHeaderPanel.SuspendLayout();
            topBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.Indigo;
            sidebarPanel.Controls.Add(btnNavSettings);
            sidebarPanel.Controls.Add(btnNavReports);
            sidebarPanel.Controls.Add(btnNavReviewers);
            sidebarPanel.Controls.Add(btnNavMovies);
            sidebarPanel.Controls.Add(navHeaderPanel);
            sidebarPanel.Controls.Add(btnNavLogout);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(240, 660);
            sidebarPanel.TabIndex = 0;
            // 
            // btnNavSettings
            // 
            btnNavSettings.BackColor = Color.Orchid;
            btnNavSettings.Dock = DockStyle.Top;
            btnNavSettings.ForeColor = SystemColors.ButtonFace;
            btnNavSettings.Location = new Point(0, 204);
            btnNavSettings.Name = "btnNavSettings";
            btnNavSettings.Size = new Size(240, 44);
            btnNavSettings.TabIndex = 4;
            btnNavSettings.Text = "Settings";
            btnNavSettings.UseVisualStyleBackColor = false;
            btnNavSettings.Click += btnNavSettings_Click;
            // 
            // btnNavReports
            // 
            btnNavReports.BackColor = Color.Cyan;
            btnNavReports.Dock = DockStyle.Top;
            btnNavReports.ForeColor = SystemColors.ActiveCaptionText;
            btnNavReports.Location = new Point(0, 160);
            btnNavReports.Name = "btnNavReports";
            btnNavReports.Size = new Size(240, 44);
            btnNavReports.TabIndex = 3;
            btnNavReports.Text = "Reports";
            btnNavReports.UseVisualStyleBackColor = false;
            btnNavReports.Click += btnNavReports_Click;
            // 
            // btnNavReviewers
            // 
            btnNavReviewers.BackColor = Color.Crimson;
            btnNavReviewers.Dock = DockStyle.Top;
            btnNavReviewers.ForeColor = SystemColors.ButtonFace;
            btnNavReviewers.Location = new Point(0, 116);
            btnNavReviewers.Name = "btnNavReviewers";
            btnNavReviewers.Size = new Size(240, 44);
            btnNavReviewers.TabIndex = 2;
            btnNavReviewers.Text = "Reviewers";
            btnNavReviewers.UseVisualStyleBackColor = false;
            btnNavReviewers.Click += btnNavReviewers_Click;
            // 
            // btnNavMovies
            // 
            btnNavMovies.BackColor = Color.MediumBlue;
            btnNavMovies.Dock = DockStyle.Top;
            btnNavMovies.ForeColor = SystemColors.ButtonHighlight;
            btnNavMovies.Location = new Point(0, 72);
            btnNavMovies.Name = "btnNavMovies";
            btnNavMovies.Size = new Size(240, 44);
            btnNavMovies.TabIndex = 1;
            btnNavMovies.Text = "Movies";
            btnNavMovies.UseVisualStyleBackColor = false;
            btnNavMovies.Click += btnNavMovies_Click;
            // 
            // navHeaderPanel
            // 
            navHeaderPanel.Controls.Add(lblAppName);
            navHeaderPanel.Dock = DockStyle.Top;
            navHeaderPanel.Location = new Point(0, 0);
            navHeaderPanel.Name = "navHeaderPanel";
            navHeaderPanel.Padding = new Padding(16);
            navHeaderPanel.Size = new Size(240, 72);
            navHeaderPanel.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.Location = new Point(16, 20);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(58, 21);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Movie";
            // 
            // btnNavLogout
            // 
            btnNavLogout.BackColor = Color.Lime;
            btnNavLogout.Dock = DockStyle.Bottom;
            btnNavLogout.Location = new Point(0, 616);
            btnNavLogout.Name = "btnNavLogout";
            btnNavLogout.Size = new Size(240, 44);
            btnNavLogout.TabIndex = 5;
            btnNavLogout.Text = "Logout";
            btnNavLogout.UseVisualStyleBackColor = false;
            btnNavLogout.Click += btnNavLogout_Click;
            // 
            // topBarPanel
            // 
            topBarPanel.BackColor = Color.Red;
            topBarPanel.BorderStyle = BorderStyle.FixedSingle;
            topBarPanel.Controls.Add(lblPageTitle);
            topBarPanel.Dock = DockStyle.Top;
            topBarPanel.Location = new Point(240, 0);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Padding = new Padding(16, 14, 16, 14);
            topBarPanel.Size = new Size(763, 66);
            topBarPanel.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.Location = new Point(16, 16);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(56, 21);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Home";
            // 
            // contentPanel
            // 
            contentPanel.BackColor = SystemColors.MenuHighlight;
            contentPanel.ForeColor = Color.DarkGoldenrod;
            contentPanel.Location = new Point(240, 63);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(763, 597);
            contentPanel.TabIndex = 2;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1003, 660);
            Controls.Add(contentPanel);
            Controls.Add(topBarPanel);
            Controls.Add(sidebarPanel);
            IsMdiContainer = true;
            Name = "Mainform";
            Text = "Mainform";
            sidebarPanel.ResumeLayout(false);
            navHeaderPanel.ResumeLayout(false);
            navHeaderPanel.PerformLayout();
            topBarPanel.ResumeLayout(false);
            topBarPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel sidebarPanel;
        private Panel navHeaderPanel;
        private Label lblAppName;
        private Button btnNavMovies;
        private Button btnNavReviewers;
        private Button btnNavReports;
        private Button btnNavSettings;
        private Button btnNavLogout;
        private Panel topBarPanel;
        private Label lblPageTitle;
        private Panel contentPanel;
    }
}