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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(13, 20, 40);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(229, 231, 235);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(124, 58, 237);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvMovies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMovies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvMovies.BackgroundColor = Color.FromArgb(11, 16, 32);
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 16, 32);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(229, 231, 235);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(124, 58, 237);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMovies.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMovies.GridColor = Color.FromArgb(31, 41, 55);
            dgvMovies.Location = new Point(515, 43);
            dgvMovies.Margin = new Padding(4, 3, 4, 3);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dgvMovies.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvMovies.Size = new Size(854, 335);
            dgvMovies.StandardTab = true;
            dgvMovies.TabIndex = 0;
            dgvMovies.CellClick += DgvMovies_CellClick;
            // 
            // movieID
            // 
            movieID.BackColor = SystemColors.Highlight;
            movieID.Location = new Point(13, 756);
            movieID.Margin = new Padding(4, 3, 4, 3);
            movieID.Name = "movieID";
            movieID.ReadOnly = true;
            movieID.Size = new Size(128, 25);
            movieID.TabIndex = 1;
            movieID.TextChanged += movieID_TextChanged;
            // 
            // title
            // 
            title.BackColor = SystemColors.InactiveCaption;
            title.Location = new Point(13, 697);
            title.Margin = new Padding(4, 3, 4, 3);
            title.Name = "title";
            title.Size = new Size(128, 25);
            title.TabIndex = 2;
            // 
            // director
            // 
            director.BackColor = SystemColors.InactiveCaption;
            director.Location = new Point(13, 635);
            director.Margin = new Padding(4, 3, 4, 3);
            director.Name = "director";
            director.Size = new Size(128, 25);
            director.TabIndex = 3;
            // 
            // year1
            // 
            year1.BackColor = SystemColors.InactiveCaption;
            year1.Location = new Point(13, 572);
            year1.Margin = new Padding(4, 3, 4, 3);
            year1.Name = "year1";
            year1.Size = new Size(128, 25);
            year1.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.AntiqueWhite;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(19, 8);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 28);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btndelete
            // 
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Snap ITC", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btndelete.ForeColor = Color.Red;
            btndelete.Location = new Point(124, 8);
            btndelete.Margin = new Padding(4, 3, 4, 3);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(97, 28);
            btndelete.TabIndex = 6;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.ForeColor = Color.DarkGreen;
            btnupdate.Location = new Point(229, 8);
            btnupdate.Margin = new Padding(4, 3, 4, 3);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(97, 28);
            btnupdate.TabIndex = 7;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // Clear
            // 
            Clear.FlatStyle = FlatStyle.Flat;
            Clear.Location = new Point(334, 9);
            Clear.Margin = new Padding(4, 3, 4, 3);
            Clear.Name = "Clear";
            Clear.Size = new Size(97, 28);
            Clear.TabIndex = 8;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(13, 725);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 19);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(13, 676);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 19);
            label2.TabIndex = 10;
            label2.Text = "title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(13, 614);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 11;
            label3.Text = "director";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(13, 551);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(35, 19);
            label4.TabIndex = 12;
            label4.Text = "year";
            // 
            // pctrbox1
            // 
            pctrbox1.BackColor = Color.Honeydew;
            pctrbox1.Location = new Point(13, 43);
            pctrbox1.Margin = new Padding(4, 3, 4, 3);
            pctrbox1.Name = "pctrbox1";
            pctrbox1.Size = new Size(489, 488);
            pctrbox1.TabIndex = 13;
            pctrbox1.TabStop = false;
            pctrbox1.Click += pictureBox1_Click;
            // 
            // txtsearch
            // 
            txtsearch.ForeColor = SystemColors.MenuBar;
            txtsearch.Location = new Point(801, 8);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(568, 25);
            txtsearch.TabIndex = 15;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 255, 128);
            label5.Location = new Point(682, 11);
            label5.Name = "label5";
            label5.Size = new Size(48, 19);
            label5.TabIndex = 16;
            label5.Text = "search";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.FromArgb(11, 16, 32);
            webView21.Location = new Point(0, 24);
            webView21.Name = "webView21";
            webView21.Size = new Size(833, 346);
            webView21.TabIndex = 17;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(webView21);
            groupBox1.Location = new Point(508, 384);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 485);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trailer";
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(13, 392);
            button1.Name = "button1";
            button1.Size = new Size(826, 33);
            button1.TabIndex = 18;
            button1.Text = "Open current trailer in browser";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(11, 16, 32);
            ClientSize = new Size(1487, 881);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(dgvMovies);
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
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(229, 231, 235);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MovieForm";
            Text = "MovieForm";
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