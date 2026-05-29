using System;

namespace HotelManagementSystem.Models
{
    public class Booking
    {
        public string Username { get; set; }

        public string RoomNumber { get; set; }

        public int Guests { get; set; }

        public string Status { get; set; }

        public decimal TotalAmount { get; set; }

        public int TotalNights { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }
    }
}