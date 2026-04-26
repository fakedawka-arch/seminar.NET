namespace TyrtyvshinGl
{
    partial class reviewerForm
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
            dgvReviewer = new DataGridView();
            txtID = new TextBox();
            txtName = new TextBox();
            textBox3 = new TextBox();
            btnADd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblStats = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReviewer).BeginInit();
            SuspendLayout();
            // 
            // dgvReviewer
            // 
            dgvReviewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReviewer.Location = new Point(12, 9);
            dgvReviewer.Name = "dgvReviewer";
            dgvReviewer.Size = new Size(490, 429);
            dgvReviewer.TabIndex = 0;
            dgvReviewer.CellContentClick += dgvReviewer_CellContentClick;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(508, 9);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(508, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(508, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // btnADd
            // 
            btnADd.Location = new Point(632, 9);
            btnADd.Name = "btnADd";
            btnADd.Size = new Size(75, 23);
            btnADd.TabIndex = 4;
            btnADd.Text = "Add";
            btnADd.UseVisualStyleBackColor = true;
            btnADd.Click += btnADd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(632, 38);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(632, 67);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Location = new Point(508, 103);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(38, 15);
            lblStats.TabIndex = 7;
            lblStats.Text = "label1";
            // 
            // reviewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStats);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnADd);
            Controls.Add(textBox3);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(dgvReviewer);
            Name = "reviewerForm";
            Text = "reviewerForm";
            Load += reviewerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReviewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReviewer;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox textBox3;
        private Button btnADd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblStats;
    }
}