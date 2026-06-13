using BillingSystem.Database;
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

    public partial class AddUser : Form
    {
        private readonly bool _isEditMode = false;
        private readonly int _userId = 0;

        public AddUser()
        {
            InitializeComponent();
            _isEditMode = false;
        }

        public AddUser(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _isEditMode = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                UpdateUser();
            }
            else
            {
                if (UsernameExists(txtUsername.Text))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                    return;
                }
                AddNewUser();
            }

        }

        private void AddNewUser()
        {
            string username = txtUsername.Text;
            string fullname = txtFullName.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO users (Username, FullName, Password, Role) VALUES (@username, @fullname, @password, @role)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@role", role);
                    command.Parameters.AddWithValue("@fullname", fullname);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("User added successfully.");
            this.Close();
        }

        private void UpdateUser()
        {
            string fullname = txtFullName.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                string query = "UPDATE users SET FullName=@fullname, role=@role WHERE UserID=@id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fullname", fullname);
                    command.Parameters.AddWithValue("@role", role);
                    command.Parameters.AddWithValue("@id", _userId);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("User updated successfully.");
            this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new object[] { "Admin", "Cashier" });

            if (_isEditMode)
            {
                LoadUserData();
                lblAddUser.Text = "Edit User";
                btnSave.Text = "Update User";
                txtPassword.Enabled = false;
                txtUsername.ReadOnly = true;
            }
            else
            {
                lblAddUser.Text = "Add New User";
                btnSave.Text = "Add User";
            }
        }

        private void LoadUserData()
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                string query = "SELECT username,fullname,role FROM users WHERE UserID=@id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", _userId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtUsername.Text = reader.GetString("username");
                            txtFullName.Text = reader.GetString("fullname");
                            cmbRole.SelectedItem = reader.GetString("role");
                        }
                    }
                }
            }
        }

        private bool UsernameExists(string username)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username=@username";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
