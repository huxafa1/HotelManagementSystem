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
    public partial class SidebarControl : UserControl
    {
        public Panel MainPanel;
        Color defaultColor;
        Button activeButton = null;
        public SidebarControl()
        {
            InitializeComponent();
            defaultColor = btnHome.BackColor;
        }


        private void HighlightButton(Button clickedButton)
        {
            Button[] buttons =
            {
        btnHome,
        btnRooms,
        btnBookings,
        btnPayments,
        btnProfile
    };

            foreach (Button btn in buttons)
            {
                btn.BackColor = Color.MidnightBlue;
            }

            clickedButton.BackColor =
                Color.DodgerBlue;

            activeButton = clickedButton;
        }

        private void Button_MouseEnter(
    object sender,
    EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != activeButton)
            {
                btn.BackColor = Color.RoyalBlue;
            }
        }

        private void Button_MouseLeave(
            object sender,
            EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != activeButton)
            {
                btn.BackColor = Color.MidnightBlue;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HighlightButton(btnHome);

            MainPanel.Controls.Clear();

            HomeControl hc = new HomeControl();

            hc.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(hc);
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            HighlightButton(btnRooms);


            MainPanel.Controls.Clear();

            RoomsControl rc = new RoomsControl();

            rc.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(rc);
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            HighlightButton(btnBookings);

            MainPanel.Controls.Clear();

            BookingsControl bc = new BookingsControl();

            bc.LoadUserBookings();

            bc.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(bc);
        }

       

        private void btnPayments_Click(object sender, EventArgs e)
        {
            HighlightButton(btnPayments);

            MainPanel.Controls.Clear();

            PaymentsControl pc = new PaymentsControl();

            pc.LoadUserPayments();

            pc.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(pc);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            HighlightButton(btnProfile);
            
            MainPanel.Controls.Clear();

            ProfileControl pc = new ProfileControl();

            pc.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(pc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.Username = "";
            LoginForm lf = new LoginForm();

            lf.Show();

            this.FindForm().Hide();
        }
    }
}
