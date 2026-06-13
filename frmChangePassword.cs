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
using BillingSystem.Utils;

namespace BillingSystem
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            //InitializeComponent(GetTxtCurrentPassword());
            InitializeComponent();
        }

        private void txtCurrentPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtRetypedPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentPassword.Focus();
                return;
            }

            if (txtNewPassword.Text != txtRetypedPassword.Text)
            {
                MessageBox.Show("New password and retyped password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRetypedPassword.Focus();
                return;
            }

            PasswordChange();
        }

        private void PasswordChange()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE users SET password = @newPassword WHERE UserID = @userID AND password = @currentPassword";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newPassword", txtNewPassword.Text);
                        cmd.Parameters.AddWithValue("@userID", AppSession.CurrentUserID);
                        cmd.Parameters.AddWithValue("@currentPassword", txtCurrentPassword.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCurrentPassword.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePass(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtRetypedPassword.Text;

            bool hasMinimum = newPassword.Length >= 8;
            bool hasUpper = newPassword.Any(char.IsUpper);
            bool hasLower = newPassword.Any(char.IsLower);
            bool hasDigit = newPassword.Any(char.IsDigit);
            bool hasSpecial = newPassword.Any(ch => !char.IsLetterOrDigit(ch));

            List<string> missing = new List<string>();

            if (!hasMinimum) missing.Add("Password is at least 8 characters");
            if (!hasUpper) missing.Add("Password has at least one uppercase letter");
            if (!hasLower) missing.Add("Password has at least one lowercase letter");
            if (!hasDigit) missing.Add("Password has at least one digit");
            if (!hasSpecial) missing.Add("Password has at least one special character");

            bool hasMissing = missing.Count == 0;

            if (!hasMissing)
            {
                lblError.Text = string.Join("Password did not met the Listed Requirements:", Environment.NewLine + string.Join(Environment.NewLine, missing));
                lblError.ForeColor = Color.Red;
                lblSame.Text = "";
                return;
            }

            lblError.Text = "Password meets all requirements.";
            lblError.ForeColor = Color.Green;

            if (newPassword != confirmPassword)
            {
                lblSame.Text = "New password and retyped password do not match.";
                lblSame.ForeColor = Color.Red;
            }
            else
            {
                lblSame.Text = "New password and retyped password match.";
                lblSame.ForeColor = Color.Green;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
