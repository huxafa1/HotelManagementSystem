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
    public partial class RoomsControl : UserControl
    {

        public bool IsAdmin = false;
        public RoomsControl()
        {
            InitializeComponent();

            LoadRooms();

            btnAddRoom.Visible = false;

            btnDeleteRoom.Visible = false;
        }

        public void SetAdminMode()
        {
            IsAdmin = true;

            btnAddRoom.Visible = true;

            btnDeleteRoom.Visible = true;
        }

        private void FilterRooms()
        {
            flowRooms.Controls.Clear();

            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
                    "SELECT * FROM Rooms WHERE 1=1";

                if (txtSearch.Text != "")
                {
                    query +=
                        " AND RoomNumber LIKE @Search";
                }

                if (cmbRoomType.Text != "All")
                {
                    query +=
                        " AND RoomType=@Type";
                }

                if (cmbStatus.Text != "All")
                {
                    query +=
                        " AND Status=@Status";
                }

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                if (txtSearch.Text != "")
                {
                    cmd.Parameters.AddWithValue(
                        "@Search",
                        "%" + txtSearch.Text + "%"
                    );
                }

                if (cmbRoomType.Text != "All")
                {
                    cmd.Parameters.AddWithValue(
                        "@Type",
                        cmbRoomType.Text
                    );
                }

                if (cmbStatus.Text != "All")
                {
                    cmd.Parameters.AddWithValue(
                        "@Status",
                        cmbStatus.Text
                    );
                }

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    RoomCard room = new RoomCard();

                    room.RoomNumber =
                        reader["RoomNumber"].ToString();

                    room.RoomType =
                        reader["RoomType"].ToString();

                    room.Price =
                        reader["Price"].ToString();

                    room.Guests =
                        reader["Guests"].ToString();

                    room.Status =
                        reader["Status"].ToString();

                    flowRooms.Controls.Add(room);
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

        private void UpdateExpiredBookings()
        {
            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
 "UPDATE Rooms " +
 "SET Status='Available' " +
 "WHERE RoomNumber IN " +
 "(" +
 "SELECT RoomNumber FROM Bookings " +
 "WHERE CheckOutDate < CURDATE()" +
 ")";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();
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

        private void LoadRooms()
        {
            UpdateExpiredBookings();

            flowRooms.Controls.Clear();
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query = "SELECT * FROM Rooms";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RoomCard room = new RoomCard();

                    room.RoomNumber = reader["RoomNumber"].ToString();

                    room.RoomType = reader["RoomType"].ToString();

                    room.Price = reader["Price"].ToString();

                    room.Guests =reader["Guests"].ToString();

                    room.Status = reader["Status"].ToString();

                    flowRooms.Controls.Add(room);
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterRooms();
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterRooms();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterRooms();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoomForm form =
       new AddRoomForm();

            form.ShowDialog();

            LoadRooms();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            DeleteRoomForm form =
       new DeleteRoomForm();

            form.ShowDialog();

            LoadRooms();
        }
    }
}
