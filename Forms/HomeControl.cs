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
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
            lblWelcome.Text =
    "Welcome, " + CurrentUser.Username + " 👋";
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            LoadTotalRooms();
            LoadAvailableRooms();
            LoadBookedRooms();
            
            LoadMyBookings();
            LoadRecentBookings();
        }
        private void LoadTotalRooms()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Rooms";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                int totalRooms = Convert.ToInt32(cmd.ExecuteScalar());

                lblTotalRooms.Text = totalRooms.ToString();
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
              MySqlConnection conn = DBConnection.GetConnection();

              try
               {
                conn.Open();

                string query =
        "SELECT COUNT(*) FROM Rooms WHERE Status='Available'";

        MySqlCommand cmd = new MySqlCommand(query, conn);

        int availableRooms =
            Convert.ToInt32(cmd.ExecuteScalar());

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


        private void LoadBookedRooms()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
                "SELECT COUNT(*) FROM Rooms WHERE Status='Booked'";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                int bookedRooms =
                    Convert.ToInt32(cmd.ExecuteScalar());

                lblBookedRooms.Text =
                    bookedRooms.ToString();
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



        

        private void LoadMyBookings()
        {
            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
"SELECT COUNT(*) FROM Bookings " +
"WHERE Username=@Username " +
"AND CheckOutDate >= CURDATE()";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@Username",
                    CurrentUser.Username
                );

                int bookingCount =
                    Convert.ToInt32(cmd.ExecuteScalar());

                lblMyBookings.Text =
                    bookingCount.ToString();
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
        private void LoadRecentBookings()
        {
            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
                "SELECT RoomNumber, CheckInDate, " +
                "CheckOutDate, Status " +
                "FROM Bookings " +
                "WHERE Username=@Username " +
                "ORDER BY Id DESC LIMIT 5";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@Username",
                    CurrentUser.Username
                );

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvRecentBookings.DataSource = dt;
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
            LoadTotalRooms();

            LoadAvailableRooms();

            LoadBookedRooms();

            LoadMyBookings();
            LoadRecentBookings();
        }



    }
    }

