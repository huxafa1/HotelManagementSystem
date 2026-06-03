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
    public partial class UsersControl : UserControl
    {
        public UsersControl()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
     "SELECT Username, Email " +
     "FROM Users " +
     "WHERE Role='User'";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn);

                DataTable dt =
                    new DataTable();

                adapter.Fill(dt);

                dgvUsers.DataSource = dt;
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
