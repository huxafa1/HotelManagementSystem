namespace MiniWhatsApp
{
    partial class AdminHomeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblUsersText = new System.Windows.Forms.Label();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.lblRoomsText = new System.Windows.Forms.Label();
            this.panelBookings = new System.Windows.Forms.Panel();
            this.lblTotalBookings = new System.Windows.Forms.Label();
            this.lblBookingsText = new System.Windows.Forms.Label();
            this.panelPayments = new System.Windows.Forms.Panel();
            this.lblTotalPayments = new System.Windows.Forms.Label();
            this.lblPaymentsText = new System.Windows.Forms.Label();
            this.panelAvailableRooms = new System.Windows.Forms.Panel();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.lblAvailableRoomsText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.panelRooms.SuspendLayout();
            this.panelBookings.SuspendLayout();
            this.panelPayments.SuspendLayout();
            this.panelAvailableRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1569, 117);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.panelUsers);
            this.flowLayoutPanel1.Controls.Add(this.panelRooms);
            this.flowLayoutPanel1.Controls.Add(this.panelBookings);
            this.flowLayoutPanel1.Controls.Add(this.panelPayments);
            this.flowLayoutPanel1.Controls.Add(this.panelAvailableRooms);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1569, 203);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.White;
            this.panelUsers.Controls.Add(this.panel2);
            this.panelUsers.Controls.Add(this.lblTotalUsers);
            this.panelUsers.Controls.Add(this.lblUsersText);
            this.panelUsers.Location = new System.Drawing.Point(35, 30);
            this.panelUsers.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(274, 143);
            this.panelUsers.TabIndex = 0;
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.Location = new System.Drawing.Point(20, 55);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(0, 48);
            this.lblTotalUsers.TabIndex = 1;
            // 
            // lblUsersText
            // 
            this.lblUsersText.AutoSize = true;
            this.lblUsersText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersText.ForeColor = System.Drawing.Color.Gray;
            this.lblUsersText.Location = new System.Drawing.Point(20, 25);
            this.lblUsersText.Name = "lblUsersText";
            this.lblUsersText.Size = new System.Drawing.Size(116, 28);
            this.lblUsersText.TabIndex = 0;
            this.lblUsersText.Text = "Total Users";
            // 
            // panelRooms
            // 
            this.panelRooms.BackColor = System.Drawing.Color.White;
            this.panelRooms.Controls.Add(this.flowLayoutPanel2);
            this.panelRooms.Controls.Add(this.lblTotalRooms);
            this.panelRooms.Controls.Add(this.lblRoomsText);
            this.panelRooms.Location = new System.Drawing.Point(339, 30);
            this.panelRooms.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(274, 143);
            this.panelRooms.TabIndex = 1;
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRooms.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalRooms.Location = new System.Drawing.Point(20, 55);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(0, 48);
            this.lblTotalRooms.TabIndex = 1;
            // 
            // lblRoomsText
            // 
            this.lblRoomsText.AutoSize = true;
            this.lblRoomsText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomsText.ForeColor = System.Drawing.Color.Gray;
            this.lblRoomsText.Location = new System.Drawing.Point(20, 25);
            this.lblRoomsText.Name = "lblRoomsText";
            this.lblRoomsText.Size = new System.Drawing.Size(129, 28);
            this.lblRoomsText.TabIndex = 0;
            this.lblRoomsText.Text = "Total Rooms";
            // 
            // panelBookings
            // 
            this.panelBookings.BackColor = System.Drawing.Color.White;
            this.panelBookings.Controls.Add(this.panel3);
            this.panelBookings.Controls.Add(this.lblTotalBookings);
            this.panelBookings.Controls.Add(this.lblBookingsText);
            this.panelBookings.Location = new System.Drawing.Point(643, 30);
            this.panelBookings.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelBookings.Name = "panelBookings";
            this.panelBookings.Size = new System.Drawing.Size(274, 143);
            this.panelBookings.TabIndex = 2;
            // 
            // lblTotalBookings
            // 
            this.lblTotalBookings.AutoSize = true;
            this.lblTotalBookings.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBookings.ForeColor = System.Drawing.Color.Cyan;
            this.lblTotalBookings.Location = new System.Drawing.Point(20, 55);
            this.lblTotalBookings.Name = "lblTotalBookings";
            this.lblTotalBookings.Size = new System.Drawing.Size(0, 48);
            this.lblTotalBookings.TabIndex = 1;
            // 
            // lblBookingsText
            // 
            this.lblBookingsText.AutoSize = true;
            this.lblBookingsText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingsText.ForeColor = System.Drawing.Color.Gray;
            this.lblBookingsText.Location = new System.Drawing.Point(20, 25);
            this.lblBookingsText.Name = "lblBookingsText";
            this.lblBookingsText.Size = new System.Drawing.Size(152, 28);
            this.lblBookingsText.TabIndex = 0;
            this.lblBookingsText.Text = "Total Bookings";
            // 
            // panelPayments
            // 
            this.panelPayments.BackColor = System.Drawing.Color.White;
            this.panelPayments.Controls.Add(this.panel4);
            this.panelPayments.Controls.Add(this.lblTotalPayments);
            this.panelPayments.Controls.Add(this.lblPaymentsText);
            this.panelPayments.Location = new System.Drawing.Point(947, 30);
            this.panelPayments.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelPayments.Name = "panelPayments";
            this.panelPayments.Size = new System.Drawing.Size(274, 143);
            this.panelPayments.TabIndex = 3;
            // 
            // lblTotalPayments
            // 
            this.lblTotalPayments.AutoSize = true;
            this.lblTotalPayments.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayments.ForeColor = System.Drawing.Color.Yellow;
            this.lblTotalPayments.Location = new System.Drawing.Point(20, 55);
            this.lblTotalPayments.Name = "lblTotalPayments";
            this.lblTotalPayments.Size = new System.Drawing.Size(0, 48);
            this.lblTotalPayments.TabIndex = 1;
            // 
            // lblPaymentsText
            // 
            this.lblPaymentsText.AutoSize = true;
            this.lblPaymentsText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentsText.ForeColor = System.Drawing.Color.Gray;
            this.lblPaymentsText.Location = new System.Drawing.Point(20, 25);
            this.lblPaymentsText.Name = "lblPaymentsText";
            this.lblPaymentsText.Size = new System.Drawing.Size(157, 28);
            this.lblPaymentsText.TabIndex = 0;
            this.lblPaymentsText.Text = "Total Payments";
            // 
            // panelAvailableRooms
            // 
            this.panelAvailableRooms.BackColor = System.Drawing.Color.White;
            this.panelAvailableRooms.Controls.Add(this.panel5);
            this.panelAvailableRooms.Controls.Add(this.lblAvailableRooms);
            this.panelAvailableRooms.Controls.Add(this.lblAvailableRoomsText);
            this.panelAvailableRooms.Location = new System.Drawing.Point(1251, 30);
            this.panelAvailableRooms.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelAvailableRooms.Name = "panelAvailableRooms";
            this.panelAvailableRooms.Size = new System.Drawing.Size(274, 143);
            this.panelAvailableRooms.TabIndex = 4;
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.AutoSize = true;
            this.lblAvailableRooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableRooms.ForeColor = System.Drawing.Color.Lime;
            this.lblAvailableRooms.Location = new System.Drawing.Point(20, 55);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(0, 48);
            this.lblAvailableRooms.TabIndex = 1;
            // 
            // lblAvailableRoomsText
            // 
            this.lblAvailableRoomsText.AutoSize = true;
            this.lblAvailableRoomsText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableRoomsText.ForeColor = System.Drawing.Color.Gray;
            this.lblAvailableRoomsText.Location = new System.Drawing.Point(20, 25);
            this.lblAvailableRoomsText.Name = "lblAvailableRoomsText";
            this.lblAvailableRoomsText.Size = new System.Drawing.Size(170, 28);
            this.lblAvailableRoomsText.TabIndex = 0;
            this.lblAvailableRoomsText.Text = "Available Rooms";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 10);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(274, 10);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 10);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Lime;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(274, 10);
            this.panel5.TabIndex = 3;
            // 
            // AdminHomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminHomeControl";
            this.Size = new System.Drawing.Size(1569, 620);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
            this.panelBookings.ResumeLayout(false);
            this.panelBookings.PerformLayout();
            this.panelPayments.ResumeLayout(false);
            this.panelPayments.PerformLayout();
            this.panelAvailableRooms.ResumeLayout(false);
            this.panelAvailableRooms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Label lblUsersText;
        private System.Windows.Forms.Panel panelRooms;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label lblRoomsText;
        private System.Windows.Forms.Panel panelBookings;
        private System.Windows.Forms.Label lblTotalBookings;
        private System.Windows.Forms.Label lblBookingsText;
        private System.Windows.Forms.Panel panelPayments;
        private System.Windows.Forms.Label lblTotalPayments;
        private System.Windows.Forms.Label lblPaymentsText;
        private System.Windows.Forms.Panel panelAvailableRooms;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.Label lblAvailableRoomsText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}
