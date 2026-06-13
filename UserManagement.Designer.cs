
namespace BillingSystem
{
    partial class UserManagement
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
            dgvUserList = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            lblUserManagement = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).BeginInit();
            SuspendLayout();
            // 
            // dgvUserList
            // 
            dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserList.Columns.AddRange(new DataGridViewColumn[] { UserID, UserName, FullName, Role, Created });
            dgvUserList.Location = new Point(31, 66);
            dgvUserList.Name = "dgvUserList";
            dgvUserList.RowHeadersWidth = 51;
            dgvUserList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserList.Size = new Size(679, 335);
            dgvUserList.TabIndex = 0;
            dgvUserList.SelectionChanged += dgvUserList_SelectionChanged;
            // 
            // UserID
            // 
            UserID.HeaderText = "User ID";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            UserID.Width = 125;
            // 
            // UserName
            // 
            UserName.HeaderText = "User Name";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.Width = 125;
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.Width = 125;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.Width = 125;
            // 
            // Created
            // 
            Created.HeaderText = "Created";
            Created.MinimumWidth = 6;
            Created.Name = "Created";
            Created.Width = 125;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 224, 192);
            btnAdd.Location = new Point(751, 66);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 224, 192);
            btnEdit.Location = new Point(751, 112);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 224, 192);
            btnDelete.Location = new Point(751, 157);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 224, 192);
            btnClose.Location = new Point(751, 205);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblUserManagement
            // 
            lblUserManagement.AutoSize = true;
            lblUserManagement.BackColor = Color.FromArgb(128, 255, 128);
            lblUserManagement.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserManagement.Location = new Point(48, 21);
            lblUserManagement.Name = "lblUserManagement";
            lblUserManagement.Size = new Size(210, 31);
            lblUserManagement.TabIndex = 5;
            lblUserManagement.Text = "User Management";
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 450);
            Controls.Add(lblUserManagement);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvUserList);
            Name = "UserManagement";
            Text = "User Management";
            Load += UserManagement_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvUserList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private DataGridView dgvUserList;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClose;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Created;
        private Label lblUserManagement;
    }
}