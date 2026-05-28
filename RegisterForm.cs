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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            panelRegister.Left = (this.ClientSize.Width - panelRegister.Width) / 2;

            panelRegister.Top = (this.ClientSize.Height - panelRegister.Height) / 2;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();

            lf.Show();

            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
                "INSERT INTO Users (Username, Email, Password) " +
                "VALUES (@Username, @Email, @Password)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration Successful");

                LoginForm lf = new LoginForm();
                lf.Show();

                this.Hide();
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
