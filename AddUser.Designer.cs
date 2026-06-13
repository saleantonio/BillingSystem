namespace BillingSystem
{
    partial class AddUser
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
            lblUsername = new Label();
            lblAddUser = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(57, 109);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // lblAddUser
            // 
            lblAddUser.AutoSize = true;
            lblAddUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddUser.Location = new Point(47, 39);
            lblAddUser.Name = "lblAddUser";
            lblAddUser.Size = new Size(112, 31);
            lblAddUser.TabIndex = 1;
            lblAddUser.Text = "Add User";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(213, 102);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(195, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(57, 165);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(213, 158);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(195, 27);
            txtPassword.TabIndex = 4;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(57, 218);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(79, 20);
            lblFullName.TabIndex = 5;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(213, 211);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(195, 27);
            txtFullName.TabIndex = 6;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(62, 271);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(42, 20);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role:";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(215, 270);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(193, 28);
            cmbRole.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(207, 356);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(374, 356);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblAddUser);
            Controls.Add(lblUsername);
            Name = "AddUser";
            Text = "AddUser";
            Load += AddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblAddUser;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblRole;
        private ComboBox cmbRole;
        private Button btnSave;
        private Button btnCancel;
    }
}