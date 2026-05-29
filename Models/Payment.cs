using System;

namespace HotelManagementSystem.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string RoomNumber { get; set; }

        public string PaymentMethod { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}