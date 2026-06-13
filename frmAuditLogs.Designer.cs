namespace BillingSystem
{
    partial class frmAuditLogs
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
            lblTitle = new Label();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnSearch = new Button();
            dgvAuditLogs = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(48, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(205, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Audit Log Report ";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(48, 91);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(50, 20);
            lblFrom.TabIndex = 1;
            lblFrom.Text = " From:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(134, 86);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(231, 27);
            dtpFrom.TabIndex = 2;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(440, 91);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(28, 20);
            lblTo.TabIndex = 3;
            lblTo.Text = "To:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(512, 84);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(187, 27);
            dtpTo.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(761, 82);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = " Search ";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvAuditLogs
            // 
            dgvAuditLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditLogs.Location = new Point(74, 134);
            dgvAuditLogs.Name = "dgvAuditLogs";
            dgvAuditLogs.RowHeadersWidth = 51;
            dgvAuditLogs.Size = new Size(733, 254);
            dgvAuditLogs.TabIndex = 6;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(684, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // frmAuditLogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 503);
            Controls.Add(btnClose);
            Controls.Add(dgvAuditLogs);
            Controls.Add(btnSearch);
            Controls.Add(dtpTo);
            Controls.Add(lblTo);
            Controls.Add(dtpFrom);
            Controls.Add(lblFrom);
            Controls.Add(lblTitle);
            Name = "frmAuditLogs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " 'Audit Log Report'";
            Load += frmAuditLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Button btnSearch;
        private DataGridView dgvAuditLogs;
        private Button btnClose;
    }
}