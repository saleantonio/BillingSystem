
namespace BillingSystem
{
    partial class frmChangePassword
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

        private TextBox GetTxtCurrentPassword()
        {
            return txtCurrentPassword;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCurrentPassword = new TextBox();
            lblCurrentPassword = new Label();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblRetypedPassword = new Label();
            txtRetypedPassword = new TextBox();
            lblChangePassword = new Label();
            btnSave = new Button();
            btnClose = new Button();
            lblError = new Label();
            lblSame = new Label();
            SuspendLayout();
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(274, 130);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(196, 27);
            txtCurrentPassword.TabIndex = 1;
            txtCurrentPassword.TextChanged += ChangePass;
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Location = new Point(110, 137);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(122, 20);
            lblCurrentPassword.TabIndex = 2;
            lblCurrentPassword.Text = "Current Password";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(115, 179);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(104, 20);
            lblNewPassword.TabIndex = 3;
            lblNewPassword.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(274, 172);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(192, 27);
            txtNewPassword.TabIndex = 4;
            txtNewPassword.TextChanged += ChangePass;
            // 
            // lblRetypedPassword
            // 
            lblRetypedPassword.AutoSize = true;
            lblRetypedPassword.Location = new Point(110, 223);
            lblRetypedPassword.Name = "lblRetypedPassword";
            lblRetypedPassword.Size = new Size(129, 20);
            lblRetypedPassword.TabIndex = 5;
            lblRetypedPassword.Text = "Retyped Password";
            // 
            // txtRetypedPassword
            // 
            txtRetypedPassword.Location = new Point(273, 216);
            txtRetypedPassword.Name = "txtRetypedPassword";
            txtRetypedPassword.PasswordChar = '*';
            txtRetypedPassword.Size = new Size(193, 27);
            txtRetypedPassword.TabIndex = 6;
            txtRetypedPassword.TextChanged += ChangePass;
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChangePassword.Location = new Point(252, 28);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(214, 31);
            lblChangePassword.TabIndex = 7;
            lblChangePassword.Text = "Changed Password";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(527, 128);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(549, 175);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(177, 280);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 11;
            // 
            // lblSame
            // 
            lblSame.AutoSize = true;
            lblSame.Location = new Point(177, 256);
            lblSame.Name = "lblSame";
            lblSame.Size = new Size(0, 20);
            lblSame.TabIndex = 12;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 450);
            Controls.Add(lblSame);
            Controls.Add(lblError);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lblChangePassword);
            Controls.Add(txtRetypedPassword);
            Controls.Add(lblRetypedPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblCurrentPassword);
            Controls.Add(txtCurrentPassword);
            Name = "frmChangePassword";
            Text = " frmChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCurrentPassword;
        private Label lblCurrentPassword;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblRetypedPassword;
        private TextBox txtRetypedPassword;
        private Label lblChangePassword;
        private Button btnSave;
        private EventHandler txtCurrentPassword_TextChanged;
        private Button btnClose;
        private Label lblError;
        private Label lblSame;
    }
}