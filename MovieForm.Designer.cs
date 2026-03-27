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
            this.wmpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmpPlayer.Location = new System.Drawing.Point(500, 300);
            this.wmpPlayer.Size = new System.Drawing.Size(400, 250);
            this.wmpPlayer.Name = "wmpPlayer";
            this.Controls.Add(this.wmpPlayer);
            ((System.ComponentModel.ISupportInitialize)wmpPlayer).BeginInit(); // ← ЭНД нэмэх
            SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrbox1).BeginInit();
            SuspendLayout();
            // 
            // dgvMovies
            // 
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(20, 12);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dgvMovies.Size = new Size(456, 288);
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
            // btnSave
            // 
            btnSave.Location = new Point(20, 321);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(101, 321);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 6;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(182, 321);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(75, 23);
            btnupdate.TabIndex = 7;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(263, 321);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 23);
            Clear.TabIndex = 8;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
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
            pctrbox1.Location = new Point(512, 12);
            pctrbox1.Name = "pctrbox1";
            pctrbox1.Size = new Size(531, 601);
            pctrbox1.TabIndex = 13;
            pctrbox1.TabStop = false;
            pctrbox1.Click += pictureBox1_Click;
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 625);
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
            Controls.Add(dgvMovies);
            Name = "MovieForm";
            Text = "MovieForm";
            Load += MovieForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrbox1).EndInit();
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
        private Control wmpPlayer;
        private DataGridView dgvMovie;
    }
}