namespace MiniWhatsApp
{
    partial class RoomsControl
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblRoomsTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.flowRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnDeleteRoom);
            this.panelHeader.Controls.Add(this.btnAddRoom);
            this.panelHeader.Controls.Add(this.cmbStatus);
            this.panelHeader.Controls.Add(this.cmbRoomType);
            this.panelHeader.Controls.Add(this.btnSearch);
            this.panelHeader.Controls.Add(this.txtSearch);
            this.panelHeader.Controls.Add(this.lblRoomsTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1112, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Available",
            "Booked"});
            this.cmbStatus.Location = new System.Drawing.Point(488, 19);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 28);
            this.cmbStatus.TabIndex = 4;
            this.cmbStatus.Text = "All";
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "All",
            "Standard",
            "Deluxe",
            "Suite"});
            this.cmbRoomType.Location = new System.Drawing.Point(644, 19);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(150, 28);
            this.cmbRoomType.TabIndex = 3;
            this.cmbRoomType.Text = "All";
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(980, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 45);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(817, 10);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(134, 43);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblRoomsTitle
            // 
            this.lblRoomsTitle.AutoSize = true;
            this.lblRoomsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomsTitle.Location = new System.Drawing.Point(3, 10);
            this.lblRoomsTitle.Name = "lblRoomsTitle";
            this.lblRoomsTitle.Size = new System.Drawing.Size(123, 45);
            this.lblRoomsTitle.TabIndex = 0;
            this.lblRoomsTitle.Text = "Rooms";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.Controls.Add(this.flowRooms);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 70);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1112, 526);
            this.panelContent.TabIndex = 1;
            // 
            // flowRooms
            // 
            this.flowRooms.AutoScroll = true;
            this.flowRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowRooms.Location = new System.Drawing.Point(0, 0);
            this.flowRooms.Name = "flowRooms";
            this.flowRooms.Padding = new System.Windows.Forms.Padding(20);
            this.flowRooms.Size = new System.Drawing.Size(1112, 526);
            this.flowRooms.TabIndex = 0;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(346, 10);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(96, 37);
            this.btnAddRoom.TabIndex = 5;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Visible = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(186, 10);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(136, 37);
            this.btnDeleteRoom.TabIndex = 6;
            this.btnDeleteRoom.Text = "Delete Room";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Visible = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // RoomsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Name = "RoomsControl";
            this.Size = new System.Drawing.Size(1112, 596);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblRoomsTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.FlowLayoutPanel flowRooms;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
    }
}
