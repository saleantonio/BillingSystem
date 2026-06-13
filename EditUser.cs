using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingSystem.Database;
using MySql.Data.MySqlClient;


namespace BillingSystem
{
    public partial class EditUser : Form
    {
        private readonly int userId = 0;
        public EditUser(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadUser();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Users SET Username=@Username, FullName=@FullName, Role=@Role WHERE UserID=@UserID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@UserID", userId);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error updating user.");
                }
            }
        }
        private void LoadUser()
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Users WHERE UserID=@UserID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtUsername.Text = reader["Username"].ToString();
                    txtFullName.Text = reader["FullName"].ToString();
                    cmbRole.Text = reader["Role"].ToString();
                }

                reader.Close();
            }
        }
    }
    }

        
    
