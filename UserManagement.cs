using billingsystem;
using BillingSystem.Database;
using BillingSystem.Utils;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BillingSystem
{
    public partial class UserManagement : Form
    {

        public UserManagement()
        {
            InitializeComponent();
            LoadUserList();
        }

        private int _selectedUserId = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser frm = new AddUser();
            frm.ShowDialog();
            LoadUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserManagement_Load_1(object sender, EventArgs e)
        {
            Invoke(() =>
            {
                dgvUserList.ClearSelection();
                dgvUserList.CurrentCell = null;
                _selectedUserId = 0;
            });
            
            LoadUsers();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenEditForm();
            LoadUsers();
        }

        private void OpenEditForm()
        {
            if (_selectedUserId == 0)
            {
                MessageBox.Show("Please select a customer to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddUser editForm = new AddUser(_selectedUserId);

            editForm.ShowDialog(this);
        }

        private void LoadUsers()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT UserID, Username, FullName, Role, CreatedAt FROM Users";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvUserList.DataSource = dt;

                            dgvUserList.ClearSelection();
                            dgvUserList.CurrentCell = null;
                            _selectedUserId = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void LoadUserList()
        {
            dgvUserList.AutoGenerateColumns = false;
            dgvUserList.Columns["UserID"].DataPropertyName = "UserID";
            dgvUserList.Columns["Username"].DataPropertyName = "Username";
            dgvUserList.Columns["FullName"].DataPropertyName = "FullName";
            dgvUserList.Columns["Role"].DataPropertyName = "Role";
            dgvUserList.Columns["Created"].DataPropertyName = "CreatedAt";
        }

        private void dgvUserList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUserList.CurrentRow == null) return;

            var idCell = dgvUserList.CurrentRow.Cells["UserID"].Value;

            if (idCell != null && int.TryParse(idCell.ToString(), out int id))
            {
                _selectedUserId = id;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == 0)
            {
                MessageBox.Show("Please select a user to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_selectedUserId == AppSession.CurrentUserID)
            {
                MessageBox.Show("You cannot delete the current logged in user.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this user?\n" +
                "This user will be deleted and won't be recovered",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                DeleteUser(_selectedUserId);
            }
        }

        private void DeleteUser(int userId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    //checking of the last Admin account
                    string rolesql = @"SELECT Role FROM Users WHERE UserID = @id;";
                    string target;
                    using (var role = new MySqlCommand(rolesql, conn))
                    {
                        role.Parameters.AddWithValue("@id", userId);
                        var result = role.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Selected user no longer exists.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            LoadUsers();
                            return;
                        }

                        target = result.ToString();
                    }

                    //checking if it is the last admin account and won't be deleted
                    if(string.Equals(target, "Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        string count = @"SELECT COUNT(*) FROM Users WHERE Role = 'Admin';";
                        using (var countcmd = new MySqlCommand(count, conn))
                        {
                            long adminCount = Convert.ToInt64(countcmd.ExecuteScalar());

                            if (adminCount <= 1)
                            {
                                MessageBox.Show("This is the last Admin account. The system must have at least one Admin.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }


                    //deletion of account
                    string sql = "DELETE FROM Users WHERE UserID = @userId;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            AuditLogger.Log("DELETE_USER",
                                $"User ID {userId} deleted by {AppSession.CurrentUsername}.");


                            MessageBox.Show("User deleted successfully.",
                                "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadUsers();
                            _selectedUserId = 0;
                        }
                        else
                        {
                            MessageBox.Show("User could not be deleted. It may no longer exist.",
                                "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
