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
            menuStrip1 = new MenuStrip();
            movieToolStripMenuItem = new ToolStripMenuItem();
            commentToolStripMenuItem = new ToolStripMenuItem();
            rateToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { movieToolStripMenuItem, commentToolStripMenuItem, rateToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1096, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // movieToolStripMenuItem
            // 
            movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            movieToolStripMenuItem.Size = new Size(70, 20);
            movieToolStripMenuItem.Text = "MovieList";
            movieToolStripMenuItem.Click += movieToolStripMenuItem_Click;
            // 
            // commentToolStripMenuItem
            // 
            commentToolStripMenuItem.Name = "commentToolStripMenuItem";
            commentToolStripMenuItem.Size = new Size(73, 20);
            commentToolStripMenuItem.Text = "Comment";
            commentToolStripMenuItem.Click += commentToolStripMenuItem_Click;
            // 
            // rateToolStripMenuItem
            // 
            rateToolStripMenuItem.Name = "rateToolStripMenuItem";
            rateToolStripMenuItem.Size = new Size(42, 20);
            rateToolStripMenuItem.Text = "Rate";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 511);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Mainform";
            Text = "Mainform";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem movieToolStripMenuItem;
        private ToolStripMenuItem commentToolStripMenuItem;
        private ToolStripMenuItem rateToolStripMenuItem;
    }
}