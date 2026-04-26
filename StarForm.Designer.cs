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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvstar1 = new DataGridView();
            txtSearch = new TextBox();
            cmbSort = new ComboBox();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            label1 = new Label();
            nudMin = new NumericUpDown();
            nudMax = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvstar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMax).BeginInit();
            SuspendLayout();
            // 
            // dgvstar1
            // 
            dgvstar1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvstar1.BackgroundColor = Color.Indigo;
            dgvstar1.BorderStyle = BorderStyle.None;
            dgvstar1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Aqua;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvstar1.DefaultCellStyle = dataGridViewCellStyle1;
            dgvstar1.GridColor = Color.DarkSlateBlue;
            dgvstar1.Location = new Point(12, 89);
            dgvstar1.Name = "dgvstar1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Indigo;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvstar1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvstar1.Size = new Size(543, 509);
            dgvstar1.TabIndex = 0;
            dgvstar1.CellContentClick += dgvstar1_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(571, 196);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(191, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Нэрээр А-Я", "Нэрээр Я-А", "Од ихээс", "", "Од багаас", "", "Огноо шинэ", "", "Огноо хуучин" });
            cmbSort.Location = new Point(571, 225);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(191, 23);
            cmbSort.TabIndex = 2;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(571, 254);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(99, 23);
            dtpFrom.TabIndex = 3;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(571, 283);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(97, 23);
            dtpTo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(571, 98);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 7;
            label1.Text = "watch based on rate";
            // 
            // nudMin
            // 
            nudMin.Location = new Point(571, 156);
            nudMin.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMin.Name = "nudMin";
            nudMin.Size = new Size(113, 23);
            nudMin.TabIndex = 9;
            nudMin.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudMin.ValueChanged += nudMin_ValueChanged;
            // 
            // nudMax
            // 
            nudMax.Location = new Point(571, 127);
            nudMax.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMax.Name = "nudMax";
            nudMax.Size = new Size(113, 23);
            nudMax.TabIndex = 10;
            nudMax.Value = new decimal(new int[] { 10, 0, 0, 0 });
            nudMax.ValueChanged += nudMax_ValueChanged;
            // 
            // StarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(766, 730);
            Controls.Add(nudMax);
            Controls.Add(nudMin);
            Controls.Add(label1);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(cmbSort);
            Controls.Add(txtSearch);
            Controls.Add(dgvstar1);
            Name = "StarForm";
            Text = "Comment / Star";
            Load += StarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvstar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstar1;
        private TextBox txtSearch;
        private ComboBox cmbSort;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Button button1;
        private Button button2;
        private Label label1;
        private NumericUpDown nudMin;
        private NumericUpDown nudMax;
    }
}
