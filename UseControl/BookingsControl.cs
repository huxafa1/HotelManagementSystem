using HotelManagementSystem.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniWhatsApp
{
    public partial class BookingsControl : UserControl
    {
        public bool IsAdmin = false;

        public BookingsControl()
        {
            InitializeComponent();
            
        }

        public void SetAdminMode()
        {
            IsAdmin = true;

            LoadBookings();
        }

        public void LoadUserBookings()
        {
            IsAdmin = false;

            LoadBookings();
        }

        private void LoadBookings()
        {
            try
            {
                BookingService service =
                    new BookingService();

                DataTable dt =
                    service.GetBookings(
                        IsAdmin,
                        CurrentUser.Username
                    );

                dgvBookings.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count > 0)
            {
                string roomNumber =
                    dgvBookings.SelectedRows[0]
                    .Cells["RoomNumber"]
                    .Value.ToString();
                DateTime checkInDate =
    Convert.ToDateTime(
        dgvBookings.SelectedRows[0]
        .Cells["CheckInDate"]
        .Value
    );

                if (!IsAdmin)
                {
                    if (DateTime.Today >= checkInDate)
                    {
                        MessageBox.Show(
                            "You can only cancel future bookings"
                        );

                        return;
                    }
                }

                MySqlConnection conn =
                    DBConnection.GetConnection();

                try
                {
                    conn.Open();

                    string deleteQuery;

                    if (IsAdmin)
                    {
                        deleteQuery =
                            "DELETE FROM Bookings " +
                            "WHERE RoomNumber=@RoomNumber";
                    }
                    else
                    {
                        deleteQuery =
                            "DELETE FROM Bookings " +
                            "WHERE RoomNumber=@RoomNumber " +
                            "AND Username=@Username";
                    }

                    MySqlCommand deleteCmd =
                        new MySqlCommand(deleteQuery, conn);

                    deleteCmd.Parameters.AddWithValue(
                        "@RoomNumber",
                        roomNumber
                    );

                    deleteCmd.Parameters.AddWithValue(
                        "@Username",
                        CurrentUser.Username
                    );

                    deleteCmd.ExecuteNonQuery();

                    string updateQuery =
                        "UPDATE Rooms SET Status='Available' " +
                        "WHERE RoomNumber=@RoomNumber";

                    MySqlCommand updateCmd =
                        new MySqlCommand(updateQuery, conn);

                    updateCmd.Parameters.AddWithValue(
                        "@RoomNumber",
                        roomNumber
                    );

                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Booking Cancelled");

                    foreach (Form frm in Application.OpenForms)
                    {
                        if (frm is Dashboard)
                        {
                            Dashboard d = (Dashboard)frm;

                            foreach (Control control in d.MainPanel.Controls)
                            {
                                if (control is HomeControl)
                                {
                                    HomeControl home =
                                        (HomeControl)control;

                                    home.RefreshDashboard();
                                }
                            }
                        }
                    }

                    foreach (Form frm in Application.OpenForms)
                    {
                        if (frm is AdminDashboard)
                        {
                            AdminDashboard admin =
                                (AdminDashboard)frm;

                            foreach (Control control in admin.MainPanelRef.Controls)
                            {
                                if (control is AdminHomeControl)
                                {
                                    AdminHomeControl home =
                                        (AdminHomeControl)control;

                                    home.RefreshDashboard();
                                }
                            }
                        }
                    }

                    LoadBookings();
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
}
