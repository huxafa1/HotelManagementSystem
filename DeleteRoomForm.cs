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
    public partial class DeleteRoomForm : Form
    {
        public DeleteRoomForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(
     object sender,
     EventArgs e)
        {
            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
                "DELETE FROM Rooms " +
                "WHERE RoomNumber=@RoomNumber";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@RoomNumber",
                    txtRoomNumber.Text
                );

                int rows =
                    cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show(
                        "Room Deleted Successfully"
                    );

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Room Not Found"
                    );
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


    }
}
