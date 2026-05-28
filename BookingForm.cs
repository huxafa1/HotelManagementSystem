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
    public partial class BookingForm : Form
    {
        string roomNumber;
        string roomPrice;
        public BookingForm(string number, string price)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            roomNumber = number;

            dtCheckIn.MinDate =
    DateTime.Today;

            dtCheckIn.Value =
                DateTime.Today;

            dtCheckOut.MinDate =
                dtCheckIn.Value.AddDays(1);

            dtCheckOut.Value =
                dtCheckIn.Value.AddDays(1);

            roomPrice = price;

            lblRoomNumber.Text =
                "Room: " + roomNumber;

            lblPrice.Text =
                "Price Per Night: " + roomPrice;
            CalculateTotal();
        }

        private void dtCheckIn_ValueChanged(
    object sender,
    EventArgs e)
        {
            dtCheckOut.MinDate =
                dtCheckIn.Value.AddDays(1);

            if (dtCheckOut.Value <= dtCheckIn.Value)
            {
                dtCheckOut.Value =
                    dtCheckIn.Value.AddDays(1);
            }

            CalculateTotal();
        }

        private void dtCheckOut_ValueChanged(
    object sender,
    EventArgs e)
        {
            if (dtCheckOut.Value <= dtCheckIn.Value)
            {
                dtCheckOut.Value =
                    dtCheckIn.Value.AddDays(1);
            }

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            if (string.IsNullOrEmpty(roomPrice))
            {
                return;
            }

            double price =
                Convert.ToDouble(
                    roomPrice.Replace("$", "")
                );

            int nights =
                (dtCheckOut.Value.Date -
                 dtCheckIn.Value.Date).Days;

            if (nights < 1)
            {
                nights = 1;
            }

            double total =
                nights * price;

            lblNights.Text =
                "Nights: " + nights.ToString();

            lblTotal.Text =
                "Total: $" + total.ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtCardNumber.Text == "")
            {
                MessageBox.Show("Enter Card Number");

                return;
            }

            MySqlConnection conn =
                DBConnection.GetConnection();

            try
            {
                conn.Open();

                string checkQuery =
"SELECT COUNT(*) FROM Bookings " +
"WHERE RoomNumber=@RoomNumber " +
"AND NOT (" +
"CheckOutDate <= @CheckIn " +
"OR CheckInDate >= @CheckOut)";

                MySqlCommand checkCmd =
                    new MySqlCommand(checkQuery, conn);

                checkCmd.Parameters.AddWithValue(
                    "@RoomNumber",
                    roomNumber
                );

                checkCmd.Parameters.AddWithValue(
                    "@CheckIn",
                    dtCheckIn.Value.Date
                );

                checkCmd.Parameters.AddWithValue(
                    "@CheckOut",
                    dtCheckOut.Value.Date
                );

                int existingBookings =
                    Convert.ToInt32(
                        checkCmd.ExecuteScalar()
                    );

                if (existingBookings > 0)
                {
                    MessageBox.Show(
                        "Room already booked for selected dates"
                    );

                    return;
                }

                string totalAmount =
                    lblTotal.Text.Replace("Total: ", "");

                string paymentQuery =
 "INSERT INTO Payments " +
 "(Username, RoomNumber, PaymentMethod, Amount, PaymentDate) " +
 "VALUES " +
 "(@Username, @RoomNumber, @PaymentMethod, @Amount, @PaymentDate)";

                MySqlCommand paymentCmd =
                    new MySqlCommand(paymentQuery, conn);

                paymentCmd.Parameters.AddWithValue(
                    "@Username",
                    CurrentUser.Username
                );

                paymentCmd.Parameters.AddWithValue(
                    "@RoomNumber",
                    roomNumber
                );

                paymentCmd.Parameters.AddWithValue(
    "@PaymentMethod",
    cmbPaymentMethod.Text
);

                paymentCmd.Parameters.AddWithValue(
                    "@Amount",
                    totalAmount
                );

                paymentCmd.Parameters.AddWithValue(
                   "@PaymentDate",
                   DateTime.Now.Date
               );



                paymentCmd.ExecuteNonQuery();

                string bookingQuery =
"INSERT INTO Bookings " +
"(Username, RoomNumber, CheckInDate, CheckOutDate, Status, TotalNights, TotalAmount) " +
"VALUES (@Username, @RoomNumber, @CheckIn, @CheckOut, @Status, @TotalNights, @TotalAmount)";

                MySqlCommand bookingCmd =
                    new MySqlCommand(bookingQuery, conn);

                bookingCmd.Parameters.AddWithValue(
                    "@Username",
                    CurrentUser.Username
                );

                bookingCmd.Parameters.AddWithValue(
                    "@RoomNumber",
                    roomNumber
                );

                bookingCmd.Parameters.AddWithValue(
    "@CheckIn",
    dtCheckIn.Value.Date
);

                bookingCmd.Parameters.AddWithValue(
    "@CheckOut",
    dtCheckOut.Value.Date
);

                bookingCmd.Parameters.AddWithValue(
                    "@Status",
                    "Confirmed"
                );
                int nights =
    (dtCheckOut.Value - dtCheckIn.Value).Days;

                if (nights <= 0)
                {
                    nights = 1;
                }

                bookingCmd.Parameters.AddWithValue(
                    "@TotalNights",
                    nights
                );

                bookingCmd.Parameters.AddWithValue(
     "@TotalAmount",
     totalAmount
 );

                bookingCmd.ExecuteNonQuery();

                string updateRoomQuery =
                "UPDATE Rooms SET Status='Booked' " +
                "WHERE RoomNumber=@RoomNumber";

                MySqlCommand updateCmd =
                    new MySqlCommand(updateRoomQuery, conn);

                updateCmd.Parameters.AddWithValue(
                    "@RoomNumber",
                    roomNumber
                );

                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Payment Successful & Room Booked");

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is Dashboard)
                    {
                        Dashboard d = (Dashboard)frm;

                        RoomsControl rc =
                            new RoomsControl();

                        rc.Dock = DockStyle.Fill;

                        d.MainPanel.Controls.Clear();

                        d.MainPanel.Controls.Add(rc);

                        break;
                    }
                }

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
