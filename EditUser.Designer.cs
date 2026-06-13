
namespace BillingSystem
{
    partial class EditUser
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
            lblEditUser = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblEditUser
            // 
            lblEditUser.AutoSize = true;
            lblEditUser.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditUser.Location = new Point(68, 29);
            lblEditUser.Name = "lblEditUser";
            lblEditUser.Size = new Size(136, 29);
            lblEditUser.TabIndex = 0;
            lblEditUser.Text = "Edit User";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(73, 100);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(227, 97);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(221, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(77, 160);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(79, 20);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(227, 153);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(221, 27);
            txtFullName.TabIndex = 4;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(77, 222);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(42, 20);
            lblRole.TabIndex = 5;
            lblRole.Text = "Role:";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(227, 217);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(221, 28);
            cmbRole.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(227, 314);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(406, 314);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblEditUser);
            Name = "EditUser";
            Text = "EditUser";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblEditUser;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblRole;
        private ComboBox cmbRole;
        private Button btnSave;
        private Button btnCancel;
    }
}