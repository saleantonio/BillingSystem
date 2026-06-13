using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   
using BillingSystem.Database;

namespace BillingSystem
{
    public partial class frmBillingHistory : Form
    {
        public int viewbillinghistory = 0;
        public frmBillingHistory(int customerid)
        {
            InitializeComponent();
            viewbillinghistory = customerid;
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBillingHistory_Load(object sender, EventArgs e)
        {
          LoadBillingHistory();
        }
        private void LoadBillingHistory()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string CustomerName = @"SELECT
                                            FullName
                                            FROM billingdb.customers
                                            WHERE CustomerID = @CustomerID;";
                    using (var cmd = new MySqlCommand(CustomerName, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", viewbillinghistory);
                        var result = cmd.ExecuteScalar();
                        lblTitle.Text = result != null ? "Billing History - "+result.ToString() : "Customer Not Found";
                    }


                    string query = @"SELECT BillingID,
                                        CustomerID,
                                        BillingMonth,
                                        PreviousReading,
                                        PresentReading,
                                        Consumption,
                                        RatePerCubic,
                                        TotalAmount,
                                        Status
                                        from billingdb.billing
                                        where CustomerID=@CustomerID
                                        order by BillingMonth ASC;";
                    using (var adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", viewbillinghistory);   
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvBillingHistory.DataSource = dt;
                        if (dt.Rows.Count == 0 )
                        {
                            MessageBox.Show("No billing history found for this customer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            
            catch (Exception ex)
            {
            MessageBox.Show($"Error loading billing history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
