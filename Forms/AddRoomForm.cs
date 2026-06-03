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
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(
     object sender,
     EventArgs e)
        {
            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
"INSERT INTO Rooms " +
"(RoomNumber, RoomType, Price, Status, Guests) " +
"VALUES " +
"(@RoomNumber, @RoomType, @Price, @Status, @Guests)";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@RoomNumber",
                    txtRoomNumber.Text
                );

                cmd.Parameters.AddWithValue(
                    "@RoomType",
                    cmbRoomType.Text
                );

                cmd.Parameters.AddWithValue(
                    "@Price",
                    "$" + txtPrice.Text
                );

                cmd.Parameters.AddWithValue(
                    "@Status",
                    cmbStatus.Text
                );

                cmd.Parameters.AddWithValue(
    "@Guests",
    cmbGuests.Text
);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Room Added Successfully"
                );

                this.Close();
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
