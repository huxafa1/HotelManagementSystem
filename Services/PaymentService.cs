using System.Data;
using MySql.Data.MySqlClient;
using MiniWhatsApp;

namespace HotelManagementSystem.Services
{
    public class PaymentService
    {


        public DataTable GetPayments(
    bool isAdmin,
    string username)
        {
            MySqlConnection conn =
                DBConnection.GetConnection();

            DataTable dt =
                new DataTable();

            try
            {
                conn.Open();

                string query;

                if (isAdmin)
                {
                    query =
                    "SELECT Id, Username, RoomNumber, " +
                    "PaymentMethod, Amount, PaymentDate " +
                    "FROM Payments";
                }
                else
                {
                    query =
                    "SELECT RoomNumber, PaymentMethod, " +
                    "Amount, PaymentDate " +
                    "FROM Payments " +
                    "WHERE Username=@Username";
                }

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn);

                if (!isAdmin)
                {
                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@Username",
                        username
                    );
                }

                adapter.Fill(dt);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }


    }
}