namespace Tyrtyvshin
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUser = new Label();
            txtUserName = new TextBox();
            lblPass = new TextBox();
            txtPassword = new TextBox();
            btnlogin = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Crimson;
            lblTitle.Location = new Point(40, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 57);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🎬 Movie";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.SteelBlue;
            lblSubtitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.LightGreen;
            lblSubtitle.Location = new Point(40, 109);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(340, 40);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Системд нэвтрэх";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.ForeColor = SystemColors.ButtonFace;
            lblUser.Location = new Point(40, 160);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(340, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "ХЭРЭГЛЭГЧИЙН НЭР";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(40, 183);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(340, 23);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // lblPass
            // 
            lblPass.BackColor = Color.DarkSlateBlue;
            lblPass.ForeColor = SystemColors.Menu;
            lblPass.Location = new Point(40, 234);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(340, 23);
            lblPass.TabIndex = 3;
            lblPass.Text = "НУУЦ ҮГ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(40, 263);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(340, 23);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.Green;
            btnlogin.Location = new Point(40, 292);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(340, 45);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "Нэвтрэх";
            btnlogin.Click += btnlogin_Click;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.FromArgb(239, 68, 68);
            lblError.Location = new Point(40, 385);
            lblError.Name = "lblError";
            lblError.Size = new Size(340, 25);
            lblError.TabIndex = 4;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(420, 520);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblUser);
            Controls.Add(txtUserName);
            Controls.Add(lblPass);
            Controls.Add(txtPassword);
            Controls.Add(btnlogin);
            Controls.Add(lblError);
            Name = "LoginForm";
            Text = "Нэвтрэх";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUser;
        private TextBox txtUserName;
        private TextBox lblPass;      // ← Label болгоно
        private TextBox txtPassword;
        private Button btnlogin;
        private Label lblError;
    }
}