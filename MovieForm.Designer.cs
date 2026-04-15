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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieForm));
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
            resources.ApplyResources(dgvMovies, "dgvMovies");
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
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dgvMovies.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvMovies.StandardTab = true;
            dgvMovies.CellClick += DgvMovies_CellClick;
            // 
            // movieID
            // 
            movieID.BackColor = SystemColors.Highlight;
            resources.ApplyResources(movieID, "movieID");
            movieID.Name = "movieID";
            movieID.ReadOnly = true;
            movieID.TextChanged += movieID_TextChanged;
            // 
            // title
            // 
            title.BackColor = SystemColors.InactiveCaption;
            resources.ApplyResources(title, "title");
            title.Name = "title";
            // 
            // director
            // 
            director.BackColor = SystemColors.InactiveCaption;
            resources.ApplyResources(director, "director");
            director.Name = "director";
            // 
            // year1
            // 
            year1.BackColor = SystemColors.InactiveCaption;
            resources.ApplyResources(year1, "year1");
            year1.Name = "year1";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.AntiqueWhite;
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btndelete
            // 
            resources.ApplyResources(btndelete, "btndelete");
            btndelete.ForeColor = Color.Red;
            btndelete.Name = "btndelete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            resources.ApplyResources(btnupdate, "btnupdate");
            btnupdate.ForeColor = Color.DarkGreen;
            btnupdate.Name = "btnupdate";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // Clear
            // 
            resources.ApplyResources(Clear, "Clear");
            Clear.Name = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.Highlight;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.Highlight;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.Highlight;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = SystemColors.Highlight;
            label4.Name = "label4";
            // 
            // pctrbox1
            // 
            pctrbox1.BackColor = Color.Honeydew;
            resources.ApplyResources(pctrbox1, "pctrbox1");
            pctrbox1.Name = "pctrbox1";
            pctrbox1.TabStop = false;
            pctrbox1.Click += pictureBox1_Click;
            // 
            // txtsearch
            // 
            txtsearch.ForeColor = SystemColors.MenuBar;
            resources.ApplyResources(txtsearch, "txtsearch");
            txtsearch.Name = "txtsearch";
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.FromArgb(255, 255, 128);
            label5.Name = "label5";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.FromArgb(11, 16, 32);
            resources.ApplyResources(webView21, "webView21");
            webView21.Name = "webView21";
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(webView21);
            groupBox1.Controls.Add(dgvMovies);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.ForeColor = Color.Black;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MovieForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 16, 32);
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
            ForeColor = Color.FromArgb(229, 231, 235);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MovieForm";
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