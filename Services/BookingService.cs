using HotelManagementSystem.Models;
using MiniWhatsApp;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace HotelManagementSystem.Services
{
    public class BookingService
    {
        public DataTable GetBookings(
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
                    "SELECT Username, Bookings.RoomNumber, " +
                    "Rooms.Guests, CheckInDate, CheckOutDate, " +
                    "TotalNights, TotalAmount, Bookings.Status " +
                    "FROM Bookings " +
                    "INNER JOIN Rooms " +
                    "ON Bookings.RoomNumber = Rooms.RoomNumber";
                }
                else
                {
                    query =
                    "SELECT Bookings.RoomNumber, Rooms.Guests, " +
                    "CheckInDate, CheckOutDate, TotalNights, " +
                    "TotalAmount, Bookings.Status " +
                    "FROM Bookings " +
                    "INNER JOIN Rooms " +
                    "ON Bookings.RoomNumber = Rooms.RoomNumber " +
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