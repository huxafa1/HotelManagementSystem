namespace MiniWhatsApp
{
    partial class PaymentsControl
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
            this.lblPaymentsTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnDeletePayment);
            this.panelHeader.Controls.Add(this.lblPaymentsTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1011, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblPaymentsTitle
            // 
            this.lblPaymentsTitle.AutoSize = true;
            this.lblPaymentsTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentsTitle.Location = new System.Drawing.Point(3, 13);
            this.lblPaymentsTitle.Name = "lblPaymentsTitle";
            this.lblPaymentsTitle.Size = new System.Drawing.Size(208, 54);
            this.lblPaymentsTitle.TabIndex = 0;
            this.lblPaymentsTitle.Text = "Payments";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.Controls.Add(this.dgvPayments);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 70);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1011, 450);
            this.panelContent.TabIndex = 1;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.Location = new System.Drawing.Point(0, 0);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 62;
            this.dgvPayments.RowTemplate.Height = 28;
            this.dgvPayments.Size = new System.Drawing.Size(1011, 450);
            this.dgvPayments.TabIndex = 0;
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Location = new System.Drawing.Point(646, 13);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(157, 40);
            this.btnDeletePayment.TabIndex = 1;
            this.btnDeletePayment.Text = "Delete Payment";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            this.btnDeletePayment.Visible = false;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // PaymentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Name = "PaymentsControl";
            this.Size = new System.Drawing.Size(1011, 520);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblPaymentsTitle;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnDeletePayment;
    }
}
