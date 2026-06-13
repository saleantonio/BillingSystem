namespace BillingSystem
{
    partial class frmBillingHistory
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
            dgvBillingHistory = new DataGridView();
            BillingMonth = new DataGridViewTextBoxColumn();
            PreviousReading = new DataGridViewTextBoxColumn();
            PresentReading = new DataGridViewTextBoxColumn();
            Consumption = new DataGridViewTextBoxColumn();
            RatePerCubic = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBillingHistory).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(70, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(255, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Billing History - Name";
            // 
            // dgvBillingHistory
            // 
            dgvBillingHistory.AllowUserToAddRows = false;
            dgvBillingHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBillingHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBillingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillingHistory.Columns.AddRange(new DataGridViewColumn[] { BillingMonth, PreviousReading, PresentReading, Consumption, RatePerCubic, TotalAmount, Status });
            dgvBillingHistory.Location = new Point(12, 85);
            dgvBillingHistory.Name = "dgvBillingHistory";
            dgvBillingHistory.RowHeadersVisible = false;
            dgvBillingHistory.RowHeadersWidth = 51;
            dgvBillingHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBillingHistory.Size = new Size(938, 265);
            dgvBillingHistory.TabIndex = 1;
            // 
            // BillingMonth
            // 
            BillingMonth.DataPropertyName = "BillingMonth";
            BillingMonth.HeaderText = "Billing Month";
            BillingMonth.MinimumWidth = 6;
            BillingMonth.Name = "BillingMonth";
            // 
            // PreviousReading
            // 
            PreviousReading.DataPropertyName = "PreviousReading";
            PreviousReading.HeaderText = "Previous Reading";
            PreviousReading.MinimumWidth = 6;
            PreviousReading.Name = "PreviousReading";
            // 
            // PresentReading
            // 
            PresentReading.DataPropertyName = "PresentReading";
            PresentReading.HeaderText = "Present Reading";
            PresentReading.MinimumWidth = 6;
            PresentReading.Name = "PresentReading";
            // 
            // Consumption
            // 
            Consumption.DataPropertyName = "Consumption";
            Consumption.HeaderText = "Consumption";
            Consumption.MinimumWidth = 6;
            Consumption.Name = "Consumption";
            // 
            // RatePerCubic
            // 
            RatePerCubic.DataPropertyName = "RatePerCubic";
            RatePerCubic.HeaderText = "Rate";
            RatePerCubic.MinimumWidth = 6;
            RatePerCubic.Name = "RatePerCubic";
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "Total";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(567, 372);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(105, 36);
            btnClose.TabIndex = 2;
            btnClose.Tag = "";
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmBillingHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 453);
            Controls.Add(btnClose);
            Controls.Add(dgvBillingHistory);
            Controls.Add(lblTitle);
            Name = "frmBillingHistory";
            Text = "Billing History";
            Load += frmBillingHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBillingHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvBillingHistory;
        private Button btnClose;
        private DataGridViewTextBoxColumn BillingMonth;
        private DataGridViewTextBoxColumn PreviousReading;
        private DataGridViewTextBoxColumn PresentReading;
        private DataGridViewTextBoxColumn Consumption;
        private DataGridViewTextBoxColumn RatePerCubic;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn Status;
    }
}