namespace MiniWhatsApp
{
    partial class HomeControl
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
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelRecentBookings = new System.Windows.Forms.Panel();
            this.dgvRecentBookings = new System.Windows.Forms.DataGridView();
            this.lblRecentBookings = new System.Windows.Forms.Label();
            this.flowDashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTotalRooms = new System.Windows.Forms.Panel();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRoomsText = new System.Windows.Forms.Label();
            this.panelAvailableRooms = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAvailableRoomsText = new System.Windows.Forms.Label();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.panelBookedRooms = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBookedRoomsText = new System.Windows.Forms.Label();
            this.lblBookedRooms = new System.Windows.Forms.Label();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMyBookingsText = new System.Windows.Forms.Label();
            this.lblMyBookings = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelWelcome.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelRecentBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).BeginInit();
            this.flowDashboard.SuspendLayout();
            this.panelTotalRooms.SuspendLayout();
            this.panelAvailableRooms.SuspendLayout();
            this.panelBookedRooms.SuspendLayout();
            this.panelCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.White;
            this.panelWelcome.Controls.Add(this.lblDate);
            this.panelWelcome.Controls.Add(this.lblWelcome);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1435, 117);
            this.panelWelcome.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDate.Location = new System.Drawing.Point(1209, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(136, 30);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Today\'s Date";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(3, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(197, 54);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.Controls.Add(this.panelRecentBookings);
            this.panelContent.Controls.Add(this.flowDashboard);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 117);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1435, 687);
            this.panelContent.TabIndex = 2;
            // 
            // panelRecentBookings
            // 
            this.panelRecentBookings.BackColor = System.Drawing.Color.LightGray;
            this.panelRecentBookings.Controls.Add(this.dgvRecentBookings);
            this.panelRecentBookings.Controls.Add(this.lblRecentBookings);
            this.panelRecentBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecentBookings.Location = new System.Drawing.Point(0, 203);
            this.panelRecentBookings.Name = "panelRecentBookings";
            this.panelRecentBookings.Padding = new System.Windows.Forms.Padding(15);
            this.panelRecentBookings.Size = new System.Drawing.Size(1435, 320);
            this.panelRecentBookings.TabIndex = 1;
            // 
            // dgvRecentBookings
            // 
            this.dgvRecentBookings.AllowUserToResizeRows = false;
            this.dgvRecentBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentBookings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRecentBookings.Location = new System.Drawing.Point(15, 65);
            this.dgvRecentBookings.Name = "dgvRecentBookings";
            this.dgvRecentBookings.ReadOnly = true;
            this.dgvRecentBookings.RowHeadersWidth = 62;
            this.dgvRecentBookings.RowTemplate.Height = 28;
            this.dgvRecentBookings.Size = new System.Drawing.Size(1405, 240);
            this.dgvRecentBookings.TabIndex = 1;
            // 
            // lblRecentBookings
            // 
            this.lblRecentBookings.AutoSize = true;
            this.lblRecentBookings.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentBookings.Location = new System.Drawing.Point(35, 19);
            this.lblRecentBookings.Name = "lblRecentBookings";
            this.lblRecentBookings.Size = new System.Drawing.Size(327, 45);
            this.lblRecentBookings.TabIndex = 0;
            this.lblRecentBookings.Text = "My Recent Bookings";
            // 
            // flowDashboard
            // 
            this.flowDashboard.Controls.Add(this.panelTotalRooms);
            this.flowDashboard.Controls.Add(this.panelAvailableRooms);
            this.flowDashboard.Controls.Add(this.panelBookedRooms);
            this.flowDashboard.Controls.Add(this.panelCustomers);
            this.flowDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowDashboard.Location = new System.Drawing.Point(0, 0);
            this.flowDashboard.Name = "flowDashboard";
            this.flowDashboard.Padding = new System.Windows.Forms.Padding(20);
            this.flowDashboard.Size = new System.Drawing.Size(1435, 203);
            this.flowDashboard.TabIndex = 0;
            // 
            // panelTotalRooms
            // 
            this.panelTotalRooms.BackColor = System.Drawing.Color.White;
            this.panelTotalRooms.Controls.Add(this.panel1);
            this.panelTotalRooms.Controls.Add(this.lblTotalRooms);
            this.panelTotalRooms.Controls.Add(this.label1);
            this.panelTotalRooms.Controls.Add(this.lblTotalRoomsText);
            this.panelTotalRooms.Location = new System.Drawing.Point(35, 30);
            this.panelTotalRooms.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelTotalRooms.Name = "panelTotalRooms";
            this.panelTotalRooms.Size = new System.Drawing.Size(300, 143);
            this.panelTotalRooms.TabIndex = 0;
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRooms.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRooms.Location = new System.Drawing.Point(20, 55);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(0, 48);
            this.lblTotalRooms.TabIndex = 0;
            this.lblTotalRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(20, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "in hotel";
            // 
            // lblTotalRoomsText
            // 
            this.lblTotalRoomsText.AutoSize = true;
            this.lblTotalRoomsText.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRoomsText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRoomsText.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalRoomsText.Location = new System.Drawing.Point(20, 25);
            this.lblTotalRoomsText.Name = "lblTotalRoomsText";
            this.lblTotalRoomsText.Size = new System.Drawing.Size(129, 28);
            this.lblTotalRoomsText.TabIndex = 1;
            this.lblTotalRoomsText.Text = "Total Rooms";
            this.lblTotalRoomsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAvailableRooms
            // 
            this.panelAvailableRooms.BackColor = System.Drawing.Color.White;
            this.panelAvailableRooms.Controls.Add(this.panel2);
            this.panelAvailableRooms.Controls.Add(this.label2);
            this.panelAvailableRooms.Controls.Add(this.lblAvailableRoomsText);
            this.panelAvailableRooms.Controls.Add(this.lblAvailableRooms);
            this.panelAvailableRooms.Location = new System.Drawing.Point(365, 30);
            this.panelAvailableRooms.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelAvailableRooms.Name = "panelAvailableRooms";
            this.panelAvailableRooms.Size = new System.Drawing.Size(300, 143);
            this.panelAvailableRooms.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "rooms free";
            // 
            // lblAvailableRoomsText
            // 
            this.lblAvailableRoomsText.AutoSize = true;
            this.lblAvailableRoomsText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableRoomsText.ForeColor = System.Drawing.Color.Gray;
            this.lblAvailableRoomsText.Location = new System.Drawing.Point(20, 25);
            this.lblAvailableRoomsText.Name = "lblAvailableRoomsText";
            this.lblAvailableRoomsText.Size = new System.Drawing.Size(170, 28);
            this.lblAvailableRoomsText.TabIndex = 1;
            this.lblAvailableRoomsText.Text = "Available Rooms";
            this.lblAvailableRoomsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.AutoSize = true;
            this.lblAvailableRooms.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableRooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableRooms.ForeColor = System.Drawing.Color.Lime;
            this.lblAvailableRooms.Location = new System.Drawing.Point(20, 55);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(0, 48);
            this.lblAvailableRooms.TabIndex = 0;
            this.lblAvailableRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBookedRooms
            // 
            this.panelBookedRooms.BackColor = System.Drawing.Color.White;
            this.panelBookedRooms.Controls.Add(this.panel3);
            this.panelBookedRooms.Controls.Add(this.label3);
            this.panelBookedRooms.Controls.Add(this.lblBookedRoomsText);
            this.panelBookedRooms.Controls.Add(this.lblBookedRooms);
            this.panelBookedRooms.Location = new System.Drawing.Point(695, 30);
            this.panelBookedRooms.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelBookedRooms.Name = "panelBookedRooms";
            this.panelBookedRooms.Size = new System.Drawing.Size(300, 143);
            this.panelBookedRooms.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "by users";
            // 
            // lblBookedRoomsText
            // 
            this.lblBookedRoomsText.AutoSize = true;
            this.lblBookedRoomsText.BackColor = System.Drawing.Color.Transparent;
            this.lblBookedRoomsText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookedRoomsText.ForeColor = System.Drawing.Color.Gray;
            this.lblBookedRoomsText.Location = new System.Drawing.Point(20, 25);
            this.lblBookedRoomsText.Name = "lblBookedRoomsText";
            this.lblBookedRoomsText.Size = new System.Drawing.Size(153, 28);
            this.lblBookedRoomsText.TabIndex = 1;
            this.lblBookedRoomsText.Text = "Booked Rooms";
            this.lblBookedRoomsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookedRooms
            // 
            this.lblBookedRooms.AutoSize = true;
            this.lblBookedRooms.BackColor = System.Drawing.Color.Transparent;
            this.lblBookedRooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookedRooms.ForeColor = System.Drawing.Color.Red;
            this.lblBookedRooms.Location = new System.Drawing.Point(20, 55);
            this.lblBookedRooms.Name = "lblBookedRooms";
            this.lblBookedRooms.Size = new System.Drawing.Size(0, 48);
            this.lblBookedRooms.TabIndex = 0;
            this.lblBookedRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCustomers
            // 
            this.panelCustomers.BackColor = System.Drawing.Color.White;
            this.panelCustomers.Controls.Add(this.panel4);
            this.panelCustomers.Controls.Add(this.label4);
            this.panelCustomers.Controls.Add(this.lblMyBookingsText);
            this.panelCustomers.Controls.Add(this.lblMyBookings);
            this.panelCustomers.Location = new System.Drawing.Point(1025, 30);
            this.panelCustomers.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelCustomers.Name = "panelCustomers";
            this.panelCustomers.Size = new System.Drawing.Size(300, 143);
            this.panelCustomers.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "at time";
            // 
            // lblMyBookingsText
            // 
            this.lblMyBookingsText.AutoSize = true;
            this.lblMyBookingsText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyBookingsText.ForeColor = System.Drawing.Color.Gray;
            this.lblMyBookingsText.Location = new System.Drawing.Point(20, 25);
            this.lblMyBookingsText.Name = "lblMyBookingsText";
            this.lblMyBookingsText.Size = new System.Drawing.Size(135, 28);
            this.lblMyBookingsText.TabIndex = 1;
            this.lblMyBookingsText.Text = "My Bookings";
            this.lblMyBookingsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyBookings
            // 
            this.lblMyBookings.AutoSize = true;
            this.lblMyBookings.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyBookings.ForeColor = System.Drawing.Color.Blue;
            this.lblMyBookings.Location = new System.Drawing.Point(20, 55);
            this.lblMyBookings.Name = "lblMyBookings";
            this.lblMyBookings.Size = new System.Drawing.Size(0, 48);
            this.lblMyBookings.TabIndex = 0;
            this.lblMyBookings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 10);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chartreuse;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 10);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 10);
            this.panel4.TabIndex = 4;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelWelcome);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1435, 804);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelRecentBookings.ResumeLayout(false);
            this.panelRecentBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).EndInit();
            this.flowDashboard.ResumeLayout(false);
            this.panelTotalRooms.ResumeLayout(false);
            this.panelTotalRooms.PerformLayout();
            this.panelAvailableRooms.ResumeLayout(false);
            this.panelAvailableRooms.PerformLayout();
            this.panelBookedRooms.ResumeLayout(false);
            this.panelBookedRooms.PerformLayout();
            this.panelCustomers.ResumeLayout(false);
            this.panelCustomers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.FlowLayoutPanel flowDashboard;
        private System.Windows.Forms.Panel panelTotalRooms;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label lblTotalRoomsText;
        private System.Windows.Forms.Panel panelAvailableRooms;
        private System.Windows.Forms.Label lblAvailableRoomsText;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.Panel panelBookedRooms;
        private System.Windows.Forms.Label lblBookedRoomsText;
        private System.Windows.Forms.Label lblBookedRooms;
        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.Label lblMyBookingsText;
        private System.Windows.Forms.Label lblMyBookings;
        private System.Windows.Forms.Panel panelRecentBookings;
        private System.Windows.Forms.Label lblRecentBookings;
        private System.Windows.Forms.DataGridView dgvRecentBookings;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
