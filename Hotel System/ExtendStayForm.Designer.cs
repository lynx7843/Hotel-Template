using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_System
{
    partial class ExtendStayForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblCurrentRoom;
        private System.Windows.Forms.TextBox txtCurrentRoom;
        private System.Windows.Forms.Label lblCurrentNights;
        private System.Windows.Forms.TextBox txtCurrentNights;
        private System.Windows.Forms.Label lblNewCheckOut;
        private System.Windows.Forms.DateTimePicker dtpNewCheckOut;
        private System.Windows.Forms.Label lblNewRate;
        private System.Windows.Forms.ListBox lstReservations;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblCurrentRoom = new System.Windows.Forms.Label();
            this.txtCurrentRoom = new System.Windows.Forms.TextBox();
            this.lblCurrentNights = new System.Windows.Forms.Label();
            this.txtCurrentNights = new System.Windows.Forms.TextBox();
            this.lblNewCheckOut = new System.Windows.Forms.Label();
            this.dtpNewCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblNewRate = new System.Windows.Forms.Label();
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.btnExtend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Extend Stay";

            // lblReservationID
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReservationID.Location = new System.Drawing.Point(12, 45);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(108, 17);
            this.lblReservationID.TabIndex = 1;
            this.lblReservationID.Text = "Reservation ID:";

            // txtReservationID
            this.txtReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtReservationID.Location = new System.Drawing.Point(12, 65);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(200, 23);
            this.txtReservationID.TabIndex = 2;
            this.txtReservationID.ReadOnly = true;

            // lblFirstName
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFirstName.Location = new System.Drawing.Point(12, 95);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 17);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";

            // txtFirstName
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(12, 115);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 23);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.ReadOnly = true;

            // lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLastName.Location = new System.Drawing.Point(12, 145);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";

            // txtLastName
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLastName.Location = new System.Drawing.Point(12, 165);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 23);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.ReadOnly = true;

            // lblCurrentRoom
            this.lblCurrentRoom.AutoSize = true;
            this.lblCurrentRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCurrentRoom.Location = new System.Drawing.Point(12, 195);
            this.lblCurrentRoom.Name = "lblCurrentRoom";
            this.lblCurrentRoom.Size = new System.Drawing.Size(106, 17);
            this.lblCurrentRoom.TabIndex = 7;
            this.lblCurrentRoom.Text = "Current Room:";

            // txtCurrentRoom
            this.txtCurrentRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCurrentRoom.Location = new System.Drawing.Point(12, 215);
            this.txtCurrentRoom.Name = "txtCurrentRoom";
            this.txtCurrentRoom.Size = new System.Drawing.Size(200, 23);
            this.txtCurrentRoom.TabIndex = 8;
            this.txtCurrentRoom.ReadOnly = true;

            // lblCurrentNights
            this.lblCurrentNights.AutoSize = true;
            this.lblCurrentNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCurrentNights.Location = new System.Drawing.Point(12, 245);
            this.lblCurrentNights.Name = "lblCurrentNights";
            this.lblCurrentNights.Size = new System.Drawing.Size(114, 17);
            this.lblCurrentNights.TabIndex = 9;
            this.lblCurrentNights.Text = "Current Nights:";

            // txtCurrentNights
            this.txtCurrentNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCurrentNights.Location = new System.Drawing.Point(12, 265);
            this.txtCurrentNights.Name = "txtCurrentNights";
            this.txtCurrentNights.Size = new System.Drawing.Size(200, 23);
            this.txtCurrentNights.TabIndex = 10;
            this.txtCurrentNights.ReadOnly = true;

            // lblNewCheckOut
            this.lblNewCheckOut.AutoSize = true;
            this.lblNewCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNewCheckOut.Location = new System.Drawing.Point(12, 295);
            this.lblNewCheckOut.Name = "lblNewCheckOut";
            this.lblNewCheckOut.Size = new System.Drawing.Size(143, 17);
            this.lblNewCheckOut.TabIndex = 11;
            this.lblNewCheckOut.Text = "New Check-out Date:";

            // dtpNewCheckOut
            this.dtpNewCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpNewCheckOut.Location = new System.Drawing.Point(12, 315);
            this.dtpNewCheckOut.Name = "dtpNewCheckOut";
            this.dtpNewCheckOut.Size = new System.Drawing.Size(200, 25);
            this.dtpNewCheckOut.TabIndex = 12;
            this.dtpNewCheckOut.ValueChanged += new System.EventHandler(this.dtpNewCheckOut_ValueChanged);

            // lblNewRate
            this.lblNewRate.AutoSize = true;
            this.lblNewRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNewRate.ForeColor = System.Drawing.Color.Green;
            this.lblNewRate.Location = new System.Drawing.Point(12, 345);
            this.lblNewRate.Name = "lblNewRate";
            this.lblNewRate.Size = new System.Drawing.Size(100, 20);
            this.lblNewRate.TabIndex = 13;
            this.lblNewRate.Text = "New Rate: $0.00";

            // lstReservations
            this.lstReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.ItemHeight = 20;
            this.lstReservations.Location = new System.Drawing.Point(230, 45);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(400, 300);
            this.lstReservations.TabIndex = 14;
            this.lstReservations.SelectedIndexChanged += new System.EventHandler(this.lstReservations_SelectedIndexChanged);

            // btnExtend
            this.btnExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExtend.Location = new System.Drawing.Point(230, 360);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(100, 35);
            this.btnExtend.TabIndex = 15;
            this.btnExtend.Text = "Extend Stay";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);

            // btnCancel
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(350, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 410);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExtend);
            this.Controls.Add(this.lblNewRate);
            this.Controls.Add(this.dtpNewCheckOut);
            this.Controls.Add(this.lblNewCheckOut);
            this.Controls.Add(this.txtCurrentNights);
            this.Controls.Add(this.lblCurrentNights);
            this.Controls.Add(this.txtCurrentRoom);
            this.Controls.Add(this.lblCurrentRoom);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtReservationID);
            this.Controls.Add(this.lblReservationID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstReservations);
            this.Name = "ExtendStayForm";
            this.Text = "Extend Stay";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}