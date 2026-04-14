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
            sidebarPanel.Controls.Add(btnNavSettings);
            sidebarPanel.Controls.Add(btnNavReports);
            sidebarPanel.Controls.Add(btnNavReviewers);
            sidebarPanel.Controls.Add(btnNavMovies);
            sidebarPanel.Controls.Add(navHeaderPanel);
            sidebarPanel.Controls.Add(btnNavLogout);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(240, 600);
            sidebarPanel.TabIndex = 0;
            // 
            // btnNavSettings
            // 
            btnNavSettings.Dock = DockStyle.Top;
            btnNavSettings.Location = new Point(0, 204);
            btnNavSettings.Name = "btnNavSettings";
            btnNavSettings.Size = new Size(240, 44);
            btnNavSettings.TabIndex = 4;
            btnNavSettings.Text = "Settings";
            btnNavSettings.UseVisualStyleBackColor = true;
            btnNavSettings.Click += btnNavSettings_Click;
            // 
            // btnNavReports
            // 
            btnNavReports.Dock = DockStyle.Top;
            btnNavReports.Location = new Point(0, 160);
            btnNavReports.Name = "btnNavReports";
            btnNavReports.Size = new Size(240, 44);
            btnNavReports.TabIndex = 3;
            btnNavReports.Text = "Reports";
            btnNavReports.UseVisualStyleBackColor = true;
            btnNavReports.Click += btnNavReports_Click;
            // 
            // btnNavReviewers
            // 
            btnNavReviewers.Dock = DockStyle.Top;
            btnNavReviewers.Location = new Point(0, 116);
            btnNavReviewers.Name = "btnNavReviewers";
            btnNavReviewers.Size = new Size(240, 44);
            btnNavReviewers.TabIndex = 2;
            btnNavReviewers.Text = "Reviewers";
            btnNavReviewers.UseVisualStyleBackColor = true;
            btnNavReviewers.Click += btnNavReviewers_Click;
            // 
            // btnNavMovies
            // 
            btnNavMovies.Dock = DockStyle.Top;
            btnNavMovies.Location = new Point(0, 72);
            btnNavMovies.Name = "btnNavMovies";
            btnNavMovies.Size = new Size(240, 44);
            btnNavMovies.TabIndex = 1;
            btnNavMovies.Text = "Movies";
            btnNavMovies.UseVisualStyleBackColor = true;
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
            btnNavLogout.Dock = DockStyle.Bottom;
            btnNavLogout.Location = new Point(0, 556);
            btnNavLogout.Name = "btnNavLogout";
            btnNavLogout.Size = new Size(240, 44);
            btnNavLogout.TabIndex = 5;
            btnNavLogout.Text = "Logout";
            btnNavLogout.UseVisualStyleBackColor = true;
            btnNavLogout.Click += btnNavLogout_Click;
            // 
            // topBarPanel
            // 
            topBarPanel.Controls.Add(lblPageTitle);
            topBarPanel.Dock = DockStyle.Top;
            topBarPanel.Location = new Point(240, 0);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Padding = new Padding(16, 14, 16, 14);
            topBarPanel.Size = new Size(760, 56);
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
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(240, 56);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(760, 544);
            contentPanel.TabIndex = 2;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(contentPanel);
            Controls.Add(topBarPanel);
            Controls.Add(sidebarPanel);
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