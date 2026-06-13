namespace BillingSystem
{
    partial class dgvArchivedCustomers
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
            lblArchivedCstomers = new Label();
            dgvArchiveCustomers = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnUnarchived = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArchiveCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblArchivedCstomers
            // 
            lblArchivedCstomers.AutoSize = true;
            lblArchivedCstomers.BackColor = Color.Yellow;
            lblArchivedCstomers.Location = new Point(73, 33);
            lblArchivedCstomers.Name = "lblArchivedCstomers";
            lblArchivedCstomers.Size = new Size(170, 23);
            lblArchivedCstomers.TabIndex = 0;
            lblArchivedCstomers.Text = "Archived Customers";
            // 
            // dgvArchiveCustomers
            // 
            dgvArchiveCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchiveCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FullName, Address, Status });
            dgvArchiveCustomers.Location = new Point(12, 79);
            dgvArchiveCustomers.Name = "dgvArchiveCustomers";
            dgvArchiveCustomers.RowHeadersWidth = 51;
            dgvArchiveCustomers.Size = new Size(620, 188);
            dgvArchiveCustomers.TabIndex = 1;
            dgvArchiveCustomers.SelectionChanged += dgvArchiveCustomers_SelectionChanged;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerID.HeaderText = "Customer ID";
            CustomerID.MinimumWidth = 10;
            CustomerID.Name = "CustomerID";
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // btnUnarchived
            // 
            btnUnarchived.BackColor = Color.FromArgb(255, 128, 0);
            btnUnarchived.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUnarchived.Location = new Point(159, 328);
            btnUnarchived.Name = "btnUnarchived";
            btnUnarchived.Size = new Size(117, 39);
            btnUnarchived.TabIndex = 2;
            btnUnarchived.Text = "Unarchived";
            btnUnarchived.UseVisualStyleBackColor = false;
            btnUnarchived.Click += btnUnarchived_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 0);
            btnClose.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(335, 328);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 39);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvArchivedCustomers
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 518);
            Controls.Add(btnClose);
            Controls.Add(btnUnarchived);
            Controls.Add(dgvArchiveCustomers);
            Controls.Add(lblArchivedCstomers);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "dgvArchivedCustomers";
            Text = "ArchivedCustomers";
            Load += dgvArchivedCustomers_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvArchiveCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArchivedCstomers;
        private DataGridView dgvArchiveCustomers;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Status;
        private Button btnUnarchived;
        private Button btnClose;
    }
}