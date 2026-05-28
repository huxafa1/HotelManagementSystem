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
    public partial class AdminDashboard : Form
    {
        public Panel MainPanelRef
        {
            get { return MainPanel; }
        }
        public AdminDashboard()
        {
            InitializeComponent();

            this.WindowState =
      FormWindowState.Maximized;

            this.StartPosition =
                FormStartPosition.CenterScreen;

            AdminHomeControl home =
    new AdminHomeControl();

            home.Dock = DockStyle.Fill;

            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(home);
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomsControl rooms =
       new RoomsControl();

            rooms.SetAdminMode();

            rooms.Dock = DockStyle.Fill;

            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(rooms);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminHomeControl home =
    new AdminHomeControl();



            home.Dock = DockStyle.Fill;

            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(home);
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingsControl bookings =
       new BookingsControl();

            bookings.SetAdminMode();

            bookings.Dock = DockStyle.Fill;

            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(bookings);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            PaymentsControl payments =
       new PaymentsControl();

            payments.SetAdminMode();

            payments.Dock = DockStyle.Fill;

            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(payments);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersControl users =
       new UsersControl();

            users.Dock = DockStyle.Fill;

            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(users);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login =
        new LoginForm();

            login.Show();

            this.Close();
        }
    }
}
