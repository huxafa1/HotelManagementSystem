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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            sidebarControl1.MainPanel = MainPanel;
            HomeControl home =
       new HomeControl();

            home.Dock = DockStyle.Fill;

            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(home);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
