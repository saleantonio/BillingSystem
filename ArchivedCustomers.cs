using BillingSystem.Database;
using BillingSystem.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class dgvArchivedCustomers : Form
    {
        public dgvArchivedCustomers()
        {
            InitializeComponent();
            InitialLoad();
        }

        private int _selectedCustomer = 0;

        private void dgvArchivedCustomers_Load_1(object sender, EventArgs e)
        {
            LoadArchiveCustomer();
        }

        private void LoadArchiveCustomer()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT CustomerID, FullName, Address, Status " +
                        "FROM customers WHERE IsArchived = 1 ;";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvArchiveCustomers.DataSource = dt;

                            if (dt.Rows.Count == 0)
                            {
                                lblArchivedCstomers.Text = $"Archived Customers (0 Record(s))";
                            }
                            else
                            {
                                lblArchivedCstomers.Text = $"Archived Customers: ({dt.Rows.Count} Record(s))";
                            }

                            this.BeginInvoke((MethodInvoker)delegate
                            {
                                dgvArchiveCustomers.ClearSelection();
                                dgvArchiveCustomers.CurrentCell = null;
                                _selectedCustomer = 0;
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading archived customers: " + ex.Message);
            }
        }

        private void btnUnarchived_Click(object sender, EventArgs e)
        {
            // Step 1: Make sure a customer is selected
            if (_selectedCustomer == 0)
            {
                MessageBox.Show("Please select a customer to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to unarchive this customer?",
                "Confirm Unarchiving",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                UnarchiveCustomer(_selectedCustomer);

                LoadArchiveCustomer();
            }
        }

        private void dgvArchiveCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArchiveCustomers.CurrentRow == null) return;

            var idCell = dgvArchiveCustomers.CurrentRow.Cells["CustomerID"].Value;

            if (idCell != null && int.TryParse(idCell.ToString(), out int id))
            {
                _selectedCustomer = id;
            }
        }

        private void UnarchiveCustomer(int customerId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE customers SET IsArchived = 0 WHERE CustomerID = @CustomerID";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            AuditLogger.Log("UNARCHIVE_CUSTOMER",
                                $"Customer ID {customerId} unarchived by {AppSession.CurrentUsername}.");
                            MessageBox.Show("Customer unarchived successfully.");
                            LoadArchiveCustomer();
                        }
                        else
                        {
                            MessageBox.Show("Failed to unarchive customer.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error unarchiving customer: " + ex.Message);
            }
        }

        private void InitialLoad()
        {
            dgvArchiveCustomers.AutoGenerateColumns = false;
            dgvArchiveCustomers.Columns["CustomerID"].DataPropertyName = "CustomerID";
            dgvArchiveCustomers.Columns["FullName"].DataPropertyName = "FullName";
            dgvArchiveCustomers.Columns["Address"].DataPropertyName = "Address";
            dgvArchiveCustomers.Columns["Status"].DataPropertyName = "Status";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
