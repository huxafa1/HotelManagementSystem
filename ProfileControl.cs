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

namespace MiniWhatsApp
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
            LoadProfile();
        }

        private void LoadProfile()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
                "SELECT * FROM Users WHERE Username=@Username";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@Username",
                    CurrentUser.Username
                );

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblName.Text =
                        "Name: " + reader["Username"].ToString();

                    lblEmail.Text =
                        "Email: " + reader["Email"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnEditProfile_Click(
    object sender,
    EventArgs e)
        {
            if (btnEditProfile.Text == "Edit Profile")
            {
                txtName.Enabled = true;

                txtEmail.Enabled = true;

                txtName.Text =
                    lblName.Text.Replace("Name: ", "");

                txtEmail.Text =
                    lblEmail.Text.Replace("Email: ", "");

                btnEditProfile.Text = "Save";
            }
            else
            {
                MySqlConnection conn =
                    DBConnection.GetConnection();

                try
                {
                    conn.Open();

                    string query =
                    "UPDATE Users " +
                    "SET Username=@Username, Email=@Email " +
                    "WHERE Username=@CurrentUsername";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@Username",
                        txtName.Text
                    );

                    cmd.Parameters.AddWithValue(
                        "@Email",
                        txtEmail.Text
                    );

                    cmd.Parameters.AddWithValue(
                        "@CurrentUsername",
                        CurrentUser.Username
                    );

                    cmd.ExecuteNonQuery();

                    CurrentUser.Username =
                        txtName.Text;

                    lblName.Text =
                        "Name: " + txtName.Text;

                    lblEmail.Text =
                        "Email: " + txtEmail.Text;

                    txtName.Enabled = false;

                    txtEmail.Enabled = false;

                    btnEditProfile.Text =
                        "Edit Profile";

                    MessageBox.Show(
                        "Profile Updated Successfully"
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
