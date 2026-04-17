namespace Tyrtyvshin
{
    partial class StarForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvstar1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvstar1).BeginInit();
            SuspendLayout();
            // 
            // dgvstar1
            // 
            dgvstar1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvstar1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvstar1.GridColor = Color.Salmon;
            dgvstar1.Location = new Point(12, 12);
            dgvstar1.Name = "dgvstar1";
            dataGridViewCellStyle1.BackColor = Color.Yellow;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(192, 0, 192);
            dgvstar1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvstar1.Size = new Size(529, 297);
            dgvstar1.TabIndex = 0;
            dgvstar1.CellContentClick += dgvstar1_CellContentClick;
            // 
            // StarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(635, 475);
            Controls.Add(dgvstar1);
            Name = "StarForm";
            Text = "Comment / Star";
            Load += StarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvstar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstar1;
    }
}
