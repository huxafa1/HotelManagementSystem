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
    
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void lgnbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
                "SELECT * FROM Users " +
                "WHERE Username=@Username AND Password=@Password";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    CurrentUser.Username = txtUsername.Text;
                    CurrentUser.Role =
       reader["Role"].ToString();
                    if (CurrentUser.Role == "Admin")
                    {
                        AdminDashboard admin =
                            new AdminDashboard();

                        admin.Show();
                    }
                    else
                    {
                        Dashboard d =
                            new Dashboard();

                        d.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;

            panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();

            rf.Show();

            this.Hide();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
