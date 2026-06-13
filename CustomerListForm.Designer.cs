

using System.Diagnostics;

namespace billingsystem
{
    partial class CustomerListForm
    {
        // Stores the CustomerID of the currently selected row.
        // 0 means no customer is currently selected.
        private int _selectedCustomerId = 0;
        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            // If no row is selected (e.g., grid is empty), do nothing
            if (dgvCustomers.CurrentRow == null) return;

            // Read the CustomerID value from the selected row
            var idCell = dgvCustomers.CurrentRow.Cells["CustomerID"].Value;

            if (idCell != null && int.TryParse(idCell.ToString(), out int id))
            {
                _selectedCustomerId = id;
                Debug.WriteLine($"Selected CustomerID: {_selectedCustomerId}");
            }
        }



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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            dgvCustomers = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            cmsCustomers = new ContextMenuStrip(components);
            archiveCustomerToolStripMenuItem = new ToolStripMenuItem();
            viewArchivedListToolStripMenuItem = new ToolStripMenuItem();
            btnAdd = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAnalytics = new Button();
            btnExportExcel = new Button();
            btnExportPdf = new Button();
            btnAuditLog = new Button();
            btnManagePermissions = new Button();
            statusStrip1 = new StatusStrip();
            lblStatusUser = new ToolStripStatusLabel();
            lblStatusSep = new ToolStripStatusLabel();
            lblStatusTime = new ToolStripStatusLabel();
            StatusTimer = new System.Windows.Forms.Timer(components);
            btnChangePassword = new Button();
            btnViewBilling = new Button();
            btnUserManagement = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            cmsCustomers.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(255, 192, 255);
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(47, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(161, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer List";
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FullName, Address, ContactNumber, Email, Balance });
            dgvCustomers.ContextMenuStrip = cmsCustomers;
            dgvCustomers.Location = new Point(47, 85);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(730, 269);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "ID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // ContactNumber
            // 
            ContactNumber.HeaderText = "Contact No.";
            ContactNumber.MinimumWidth = 6;
            ContactNumber.Name = "ContactNumber";
            ContactNumber.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Balance
            // 
            Balance.HeaderText = "Balance";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            // 
            // cmsCustomers
            // 
            cmsCustomers.ImageScalingSize = new Size(20, 20);
            cmsCustomers.Items.AddRange(new ToolStripItem[] { archiveCustomerToolStripMenuItem, viewArchivedListToolStripMenuItem });
            cmsCustomers.Name = "cmsCustomers";
            cmsCustomers.Size = new Size(203, 52);
            // 
            // archiveCustomerToolStripMenuItem
            // 
            archiveCustomerToolStripMenuItem.Name = "archiveCustomerToolStripMenuItem";
            archiveCustomerToolStripMenuItem.Size = new Size(202, 24);
            archiveCustomerToolStripMenuItem.Text = " Archive Customer ";
            archiveCustomerToolStripMenuItem.Click += archiveCustomerToolStripMenuItem_Click;
            // 
            // viewArchivedListToolStripMenuItem
            // 
            viewArchivedListToolStripMenuItem.Name = "viewArchivedListToolStripMenuItem";
            viewArchivedListToolStripMenuItem.Size = new Size(202, 24);
            viewArchivedListToolStripMenuItem.Text = "View Archived List";
            viewArchivedListToolStripMenuItem.Click += viewArchivedListToolStripMenuItem_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Yellow;
            btnAdd.Location = new Point(47, 369);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Yellow;
            btnDelete.Location = new Point(235, 369);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(128, 255, 255);
            btnLogout.Location = new Point(783, 57);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(179, 29);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(192, 255, 192);
            txtSearch.Location = new Point(388, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(243, 27);
            txtSearch.TabIndex = 5;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 128, 128);
            btnSearch.Location = new Point(653, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAnalytics
            // 
            btnAnalytics.BackColor = Color.FromArgb(128, 255, 255);
            btnAnalytics.Location = new Point(783, 85);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(179, 29);
            btnAnalytics.TabIndex = 7;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.UseVisualStyleBackColor = false;
            btnAnalytics.Click += btnAnalytics_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.FromArgb(128, 255, 255);
            btnExportExcel.Location = new Point(783, 155);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(179, 29);
            btnExportExcel.TabIndex = 8;
            btnExportExcel.Text = " Export to Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.FromArgb(128, 255, 255);
            btnExportPdf.Location = new Point(783, 190);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(179, 29);
            btnExportPdf.TabIndex = 9;
            btnExportPdf.Text = " Export to PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnAuditLog
            // 
            btnAuditLog.BackColor = Color.FromArgb(128, 255, 255);
            btnAuditLog.Location = new Point(783, 225);
            btnAuditLog.Name = "btnAuditLog";
            btnAuditLog.Size = new Size(179, 29);
            btnAuditLog.TabIndex = 10;
            btnAuditLog.Text = "Audit Log";
            btnAuditLog.UseVisualStyleBackColor = false;
            btnAuditLog.Click += btnAuditLog_Click;
            // 
            // btnManagePermissions
            // 
            btnManagePermissions.BackColor = Color.FromArgb(128, 255, 255);
            btnManagePermissions.Location = new Point(783, 120);
            btnManagePermissions.Name = "btnManagePermissions";
            btnManagePermissions.Size = new Size(179, 29);
            btnManagePermissions.TabIndex = 11;
            btnManagePermissions.Text = "Manage Permissions";
            btnManagePermissions.UseVisualStyleBackColor = false;
            btnManagePermissions.Click += btnManagePermissions_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusUser, lblStatusSep, lblStatusTime });
            statusStrip1.Location = new Point(0, 427);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(989, 26);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusUser
            // 
            lblStatusUser.Name = "lblStatusUser";
            lblStatusUser.Size = new Size(204, 20);
            lblStatusUser.Text = "User: [username] | Role: [role]";
            // 
            // lblStatusSep
            // 
            lblStatusSep.Name = "lblStatusSep";
            lblStatusSep.Size = new Size(618, 20);
            lblStatusSep.Spring = true;
            // 
            // lblStatusTime
            // 
            lblStatusTime.Name = "lblStatusTime";
            lblStatusTime.Size = new Size(152, 20);
            lblStatusTime.Text = "current date and time";
            // 
            // StatusTimer
            // 
            StatusTimer.Enabled = true;
            StatusTimer.Interval = 1000;
            StatusTimer.Tick += timer1_Tick;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(128, 255, 255);
            btnChangePassword.Location = new Point(783, 260);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(179, 29);
            btnChangePassword.TabIndex = 13;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnViewBilling
            // 
            btnViewBilling.BackColor = Color.FromArgb(128, 255, 255);
            btnViewBilling.Location = new Point(783, 295);
            btnViewBilling.Name = "btnViewBilling";
            btnViewBilling.Size = new Size(179, 29);
            btnViewBilling.TabIndex = 14;
            btnViewBilling.Text = "View Billing";
            btnViewBilling.UseVisualStyleBackColor = false;
            btnViewBilling.Click += button1_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.FromArgb(128, 255, 255);
            btnUserManagement.Location = new Point(783, 330);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(179, 29);
            btnUserManagement.TabIndex = 15;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 453);
            Controls.Add(btnUserManagement);
            Controls.Add(btnViewBilling);
            Controls.Add(btnChangePassword);
            Controls.Add(statusStrip1);
            Controls.Add(btnManagePermissions);
            Controls.Add(btnAuditLog);
            Controls.Add(btnExportPdf);
            Controls.Add(btnExportExcel);
            Controls.Add(btnAnalytics);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomers);
            Controls.Add(lblTitle);
            Name = "CustomerListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing system - Customer List ";
            Load += CustomerListForm_Load;
            Click += CustomerListForm_Click;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            cmsCustomers.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CustomerListForm_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ;
        }



        #endregion

        private Label lblTitle;
        private DataGridView dgvCustomers;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnLogout;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Balance;
        private Button btnAnalytics;
        private Button btnExportExcel;
        private Button btnExportPdf;
        private Button btnAuditLog;
        private Button btnManagePermissions;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusUser;
        private ToolStripStatusLabel lblStatusSep;
        private ToolStripStatusLabel lblStatusTime;
        private System.Windows.Forms.Timer StatusTimer;
        private Button btnChangePassword;
        private Button btnViewBilling;
        private Button btnUserManagement;
        private ContextMenuStrip cmsCustomers;
        private ToolStripMenuItem archiveCustomerToolStripMenuItem;
        private ToolStripMenuItem viewArchivedListToolStripMenuItem;
    }
}