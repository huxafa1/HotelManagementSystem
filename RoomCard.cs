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
    public partial class RoomCard : UserControl
    {
        public RoomCard()
        {
            InitializeComponent();
        }
        public string RoomNumber
        {
            get { return lblRoomNo.Text; }
            set { lblRoomNo.Text = value; }
        }

        public string RoomType
        {
            get { return lblType.Text; }
            set { lblType.Text = value; }
        }

        public string Price
        {
            get
            {
                return lblPrice.Text;
            }

            set
            {
                lblPrice.Text = value;
            }
        }

        public string Guests
        {
            get
            {
                return lblGuests.Text;
            }

            set
            {
                lblGuests.Text =
                    "Guests: " + value;
            }
        }

        public string Status
        {
            get { return lblStatus.Text; }

            set
            {
                lblStatus.Text = value;

                if (value == "Booked")
                {
                    btnBook.Enabled = false;

                    btnBook.Text = "Booked";

                    this.BackColor = Color.LightCoral;
                }
                else
                {
                    btnBook.Enabled = true;

                    btnBook.Text = "Book Now";

                    this.BackColor = Color.LightGreen;
                }
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookingForm bf =
                new BookingForm(RoomNumber, Price);

            bf.ShowDialog();
        }
    }
}
