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
    public partial class AdminHomeControl : UserControl
    {
        public AdminHomeControl()
        {
            InitializeComponent();
            LoadTotalUsers();
            LoadTotalRooms();
            LoadAvailableRooms();
            LoadTotalBookings();
            LoadTotalPayments();
        }

        private void LoadTotalUsers()
        {
            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
     "SELECT COUNT(*) FROM Users " +
     "WHERE Role='User'";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                int totalUsers =
                    Convert.ToInt32(
                        cmd.ExecuteScalar()
                    );

                lblTotalUsers.Text =
                    totalUsers.ToString();
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

        private void LoadTotalRooms()
        {
            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
                    "SELECT COUNT(*) FROM Rooms";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                int totalRooms =
                    Convert.ToInt32(
                        cmd.ExecuteScalar()
                    );

                lblTotalRooms.Text =
                    totalRooms.ToString();
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

        private void LoadTotalBookings()
        {
            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
"SELECT COUNT(*) FROM Bookings " +
"WHERE CheckOutDate >= CURDATE()";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                int totalBookings =
                    Convert.ToInt32(
                        cmd.ExecuteScalar()
                    );

                lblTotalBookings.Text =
                    totalBookings.ToString();
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

        private void LoadAvailableRooms()
        {
            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
                "SELECT COUNT(*) FROM Rooms " +
                "WHERE Status='Available'";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                int availableRooms =
                    Convert.ToInt32(
                        cmd.ExecuteScalar()
                    );

                lblAvailableRooms.Text =
                    availableRooms.ToString();
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

        private void LoadTotalPayments()
        {
            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
                    "SELECT COUNT(*) FROM Payments";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                int totalPayments =
                    Convert.ToInt32(
                        cmd.ExecuteScalar()
                    );

                lblTotalPayments.Text =
                    totalPayments.ToString();
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

        public void RefreshDashboard()
        {
            LoadTotalUsers();

            LoadTotalRooms();

            LoadTotalBookings();

            LoadAvailableRooms();

            LoadTotalPayments();
        }


    }
}
