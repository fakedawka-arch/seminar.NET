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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgvMovies = new DataGridView();
            movieID = new TextBox();
            title = new TextBox();
            director = new TextBox();
            year1 = new TextBox();
            btnSave = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            Clear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pctrbox1 = new PictureBox();
            txtsearch = new TextBox();
            label5 = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            groupBox1 = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrbox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMovies
            // 
            dgvMovies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(13, 20, 40);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(229, 231, 235);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(124, 58, 237);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvMovies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMovies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMovies.BackgroundColor = Color.FromArgb(11, 16, 32);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(11, 16, 32);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(229, 231, 235);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(124, 58, 237);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMovies.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMovies.GridColor = Color.FromArgb(192, 255, 255);
            dgvMovies.Location = new Point(1, 12);
            dgvMovies.Margin = new Padding(4, 3, 4, 3);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvMovies.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle5.ForeColor = Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.Blue;
            dgvMovies.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvMovies.Size = new Size(652, 312);
            dgvMovies.StandardTab = true;
            dgvMovies.TabIndex = 0;
            dgvMovies.CellClick += DgvMovies_CellClick;
            // 
            // movieID
            // 
            movieID.BackColor = SystemColors.Highlight;
            movieID.Location = new Point(13, 673);
            movieID.Margin = new Padding(4, 3, 4, 3);
            movieID.Name = "movieID";
            movieID.ReadOnly = true;
            movieID.Size = new Size(386, 25);
            movieID.TabIndex = 1;
            movieID.TextChanged += movieID_TextChanged;
            // 
            // title
            // 
            title.BackColor = SystemColors.InactiveCaption;
            title.Location = new Point(13, 623);
            title.Margin = new Padding(4, 3, 4, 3);
            title.Name = "title";
            title.Size = new Size(386, 25);
            title.TabIndex = 2;
            // 
            // director
            // 
            director.BackColor = SystemColors.InactiveCaption;
            director.Location = new Point(13, 561);
            director.Margin = new Padding(4, 3, 4, 3);
            director.Name = "director";
            director.Size = new Size(386, 25);
            director.TabIndex = 3;
            // 
            // year1
            // 
            year1.BackColor = SystemColors.InactiveCaption;
            year1.Location = new Point(13, 498);
            year1.Margin = new Padding(4, 3, 4, 3);
            year1.Name = "year1";
            year1.Size = new Size(386, 25);
            year1.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lavender;
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(19, 8);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 31);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Lavender;
            btndelete.Font = new Font("Snap ITC", 11.25F, FontStyle.Italic);
            btndelete.ForeColor = Color.IndianRed;
            btndelete.Location = new Point(124, 8);
            btndelete.Margin = new Padding(4, 3, 4, 3);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(97, 31);
            btndelete.TabIndex = 6;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.ForeColor = Color.DarkGreen;
            btnupdate.Location = new Point(229, 8);
            btnupdate.Margin = new Padding(4, 3, 4, 3);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(97, 31);
            btnupdate.TabIndex = 7;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.LightSteelBlue;
            Clear.ForeColor = SystemColors.ControlText;
            Clear.Location = new Point(334, 9);
            Clear.Margin = new Padding(4, 3, 4, 3);
            Clear.Name = "Clear";
            Clear.Size = new Size(97, 30);
            Clear.TabIndex = 8;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(13, 651);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 19);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(13, 602);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 10;
            label2.Text = "title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(13, 540);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 18);
            label3.TabIndex = 11;
            label3.Text = "director";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumSlateBlue;
            label4.Location = new Point(13, 477);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 12;
            label4.Text = "year";
            // 
            // pctrbox1
            // 
            pctrbox1.BackColor = Color.Honeydew;
            pctrbox1.Location = new Point(13, 54);
            pctrbox1.Margin = new Padding(4, 3, 4, 3);
            pctrbox1.Name = "pctrbox1";
            pctrbox1.Size = new Size(386, 407);
            pctrbox1.TabIndex = 13;
            pctrbox1.TabStop = false;
            pctrbox1.Click += pictureBox1_Click;
            // 
            // txtsearch
            // 
            txtsearch.BackColor = Color.OldLace;
            txtsearch.ForeColor = SystemColors.InactiveCaptionText;
            txtsearch.Location = new Point(487, 13);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(572, 25);
            txtsearch.TabIndex = 15;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkViolet;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 255, 128);
            label5.Location = new Point(438, 15);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 16;
            label5.Text = "search";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.FromArgb(11, 16, 32);
            webView21.Location = new Point(0, 330);
            webView21.Name = "webView21";
            webView21.Size = new Size(653, 346);
            webView21.TabIndex = 17;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(webView21);
            groupBox1.Controls.Add(dgvMovies);
            groupBox1.Location = new Point(406, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 713);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trailer";
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1, 680);
            button1.Name = "button1";
            button1.Size = new Size(652, 33);
            button1.TabIndex = 18;
            button1.Text = "Open current trailer in browser";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MovieForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Teal;
            ClientSize = new Size(1065, 769);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(txtsearch);
            Controls.Add(pctrbox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Clear);
            Controls.Add(btnupdate);
            Controls.Add(btndelete);
            Controls.Add(btnSave);
            Controls.Add(year1);
            Controls.Add(director);
            Controls.Add(title);
            Controls.Add(movieID);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(229, 231, 235);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MovieForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += MovieForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrbox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
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
        private Button btnSave;
        private Button btndelete;
        private Button btnupdate;
        private Button Clear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pctrbox1;
        private Button btnwatchtrailer;
        private TextBox txtsearch;
        private Label label5;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private GroupBox groupBox1;
        private Button button1;
    }
}