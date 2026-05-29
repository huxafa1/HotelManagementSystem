using HotelManagementSystem.Models;
using MySql.Data.MySqlClient;
using MiniWhatsApp;
using System;
using System.Collections.Generic;

namespace HotelManagementSystem.Services
{
    public class RoomService
    {
        public List<Room> GetRooms()
        {
            List<Room> rooms =
                new List<Room>();

            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query =
                    "SELECT * FROM Rooms";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                MySqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    Room room = new Room();

                    room.RoomNumber =
                        reader["RoomNumber"].ToString();

                    room.RoomType =
                        reader["RoomType"].ToString();

                    room.Price =
                        reader["Price"].ToString();

                    room.Status =
                        reader["Status"].ToString();

                    room.Guests =
                        Convert.ToInt32(
                            reader["Guests"]
                        );

                    rooms.Add(room);
                }
            }
            finally
            {
                conn.Close();
            }

            return rooms;
        }


    }
}