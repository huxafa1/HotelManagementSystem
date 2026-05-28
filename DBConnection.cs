using MySql.Data.MySqlClient;

namespace MiniWhatsApp
{
    class DBConnection
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString =
                "server=localhost;database=HotelDB;uid=root;pwd=mysql1122;";

            MySqlConnection conn =
                new MySqlConnection(connectionString);

            return conn;
        }
    }
}