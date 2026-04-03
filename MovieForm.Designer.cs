namespace Tyrtyvshin
{
    partial class MovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieForm));
            dgvMovies = new DataGridView();
            movieID = new TextBox();
            title = new TextBox();
            director = new TextBox();
            year1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pctrbox1 = new PictureBox();
            txtSearch = new TextBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            tolStrip1 = new ToolStrip();
            tlbtnsave = new ToolStripButton();
            tlbtnclear = new ToolStripButton();
            tlbtndelete = new ToolStripButton();
            tlbtnupdate = new ToolStripButton();
            tlbtnsearch = new ToolStripTextBox();
            mediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            groupBox1 = new GroupBox();
            btnopenvideo = new Button();
            tlbtnseach = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrbox1).BeginInit();
            tolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mediaplayer).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMovies
            // 
            dgvMovies.BackgroundColor = SystemColors.InactiveCaption;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(12, 27);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dgvMovies.Size = new Size(446, 288);
            dgvMovies.TabIndex = 0;
            dgvMovies.CellClick += DgvMovies_CellClick;
            dgvMovies.CellContentClick += DgvMovies_CellClick;
            // 
            // movieID
            // 
            movieID.Location = new Point(20, 360);
            movieID.Name = "movieID";
            movieID.ReadOnly = true;
            movieID.Size = new Size(100, 23);
            movieID.TabIndex = 1;
            // 
            // title
            // 
            title.Location = new Point(20, 404);
            title.Name = "title";
            title.Size = new Size(100, 23);
            title.TabIndex = 2;
            // 
            // director
            // 
            director.Location = new Point(20, 448);
            director.Name = "director";
            director.Size = new Size(100, 23);
            director.TabIndex = 3;
            // 
            // year1
            // 
            year1.Location = new Point(20, 492);
            year1.Name = "year1";
            year1.Size = new Size(100, 23);
            year1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(20, 386);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(20, 430);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 10;
            label2.Text = "title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(20, 474);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 11;
            label3.Text = "director";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(20, 518);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 12;
            label4.Text = "year";
            // 
            // pctrbox1
            // 
            pctrbox1.Location = new Point(464, 368);
            pctrbox1.Name = "pctrbox1";
            pctrbox1.Size = new Size(188, 287);
            pctrbox1.TabIndex = 13;
            pctrbox1.TabStop = false;
            pctrbox1.Click += pictureBox1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(238, 360);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 15;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(153, 404);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Location = new Point(24, 585);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 18;
            // 
            // tolStrip1
            // 
            tolStrip1.Items.AddRange(new ToolStripItem[] { tlbtnsave, tlbtnclear, tlbtndelete, tlbtnupdate, tlbtnsearch, tlbtnseach });
            tolStrip1.Location = new Point(0, 0);
            tolStrip1.Name = "tolStrip1";
            tolStrip1.Size = new Size(1076, 25);
            tolStrip1.TabIndex = 19;
            tolStrip1.Text = "toolStrip1";
            tolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // tlbtnsave
            // 
            tlbtnsave.BackColor = SystemColors.InactiveCaption;
            tlbtnsave.ForeColor = SystemColors.MenuText;
            tlbtnsave.Image = (Image)resources.GetObject("tlbtnsave.Image");
            tlbtnsave.ImageTransparentColor = Color.Magenta;
            tlbtnsave.Name = "tlbtnsave";
            tlbtnsave.Size = new Size(50, 22);
            tlbtnsave.Text = "save";
            tlbtnsave.Click += tlbtnsave_Click;
            // 
            // tlbtnclear
            // 
            tlbtnclear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlbtnclear.Image = (Image)resources.GetObject("tlbtnclear.Image");
            tlbtnclear.ImageTransparentColor = Color.Magenta;
            tlbtnclear.Name = "tlbtnclear";
            tlbtnclear.Size = new Size(52, 22);
            tlbtnclear.Text = "clear";
            tlbtnclear.Click += tlbtnclear_Click;
            // 
            // tlbtndelete
            // 
            tlbtndelete.Image = (Image)resources.GetObject("tlbtndelete.Image");
            tlbtndelete.ImageTransparentColor = Color.Magenta;
            tlbtndelete.Name = "tlbtndelete";
            tlbtndelete.Size = new Size(59, 22);
            tlbtndelete.Text = "delete";
            tlbtndelete.Click += tlbtndelete_Click;
            // 
            // tlbtnupdate
            // 
            tlbtnupdate.Image = (Image)resources.GetObject("tlbtnupdate.Image");
            tlbtnupdate.ImageTransparentColor = Color.Magenta;
            tlbtnupdate.Name = "tlbtnupdate";
            tlbtnupdate.Size = new Size(64, 22);
            tlbtnupdate.Text = "update";
            tlbtnupdate.Click += tlbtnupdate_Click;
            // 
            // tlbtnsearch
            // 
            tlbtnsearch.BackColor = SystemColors.GradientActiveCaption;
            tlbtnsearch.BorderStyle = BorderStyle.FixedSingle;
            tlbtnsearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlbtnsearch.Name = "tlbtnsearch";
            tlbtnsearch.Size = new Size(100, 25);
            tlbtnsearch.Text = "find films";
            tlbtnsearch.Click += tlbtnsearch_Click;
            // 
            // mediaplayer
            // 
            mediaplayer.Enabled = true;
            mediaplayer.Location = new Point(0, 1);
            mediaplayer.Name = "mediaplayer";
            mediaplayer.OcxState = (AxHost.State)resources.GetObject("mediaplayer.OcxState");
            mediaplayer.Size = new Size(600, 318);
            mediaplayer.TabIndex = 20;
            mediaplayer.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnopenvideo);
            groupBox1.Controls.Add(mediaplayer);
            groupBox1.Location = new Point(464, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 335);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnopenvideo
            // 
            btnopenvideo.Location = new Point(0, 325);
            btnopenvideo.Name = "btnopenvideo";
            btnopenvideo.Size = new Size(600, 23);
            btnopenvideo.TabIndex = 22;
            btnopenvideo.Text = "wath trailer";
            btnopenvideo.UseVisualStyleBackColor = true;
            btnopenvideo.Click += btnopenvideo_Click;
            // 
            // tlbtnseach
            // 
            tlbtnseach.Name = "tlbtnseach";
            tlbtnseach.Size = new Size(0, 22);
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1076, 697);
            Controls.Add(groupBox1);
            Controls.Add(tolStrip1);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(txtSearch);
            Controls.Add(pctrbox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(year1);
            Controls.Add(director);
            Controls.Add(title);
            Controls.Add(movieID);
            Controls.Add(dgvMovies);
            Name = "MovieForm";
            Text = "MovieForm";
            Load += MovieForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrbox1).EndInit();
            tolStrip1.ResumeLayout(false);
            tolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mediaplayer).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMovies;
        private TextBox movieID;
        private TextBox title;
        private TextBox director;
        private TextBox year1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pctrbox1;
        private TextBox txtSearch;
        private ComboBox comboBox1;
        private Panel panel1;
        private ToolStrip tolStrip1;
        private ToolStripButton tlbtnsave;
        private ToolStripButton tlbtnupdate;
        private ToolStripButton tlbtnclear;
        private ToolStripButton tlbtndelete;
        private AxWMPLib.AxWindowsMediaPlayer mediaplayer;
        private GroupBox groupBox1;
        private Button btnopenvideo;
        private ToolStripTextBox tlbtnsearch;
        private ToolStripLabel tlbtnseach;
    }
}