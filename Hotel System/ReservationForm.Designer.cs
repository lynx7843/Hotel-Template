using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_System
{
    partial class ReservationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Label lblGuestInfo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnCreateGuest;
        private System.Windows.Forms.Label lblNumberOfGuests;
        private System.Windows.Forms.NumericUpDown txtNumberOfGuests;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.lblGuestInfo = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnCreateGuest = new System.Windows.Forms.Button();
            this.lblNumberOfGuests = new System.Windows.Forms.Label();
            this.txtNumberOfGuests = new System.Windows.Forms.NumericUpDown();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfGuests)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Reservation";

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

            // lblRoom
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRoom.Location = new System.Drawing.Point(12, 95);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(51, 17);
            this.lblRoom.TabIndex = 3;
            this.lblRoom.Text = "Room:";

            // cmbRoom
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbRoom.Location = new System.Drawing.Point(12, 115);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(200, 25);
            this.cmbRoom.TabIndex = 4;

            // btnCheckAvailability
            this.btnCheckAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCheckAvailability.Location = new System.Drawing.Point(225, 115);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(100, 25);
            this.btnCheckAvailability.TabIndex = 5;
            this.btnCheckAvailability.Text = "Check Availability";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);

            // lblGuestInfo
            this.lblGuestInfo.AutoSize = true;
            this.lblGuestInfo.Font = new System.Windows.Forms.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblGuestInfo.Location = new System.Drawing.Point(12, 145);
            this.lblGuestInfo.Name = "lblGuestInfo";
            this.lblGuestInfo.Size = new System.Drawing.Size(95, 17);
            this.lblGuestInfo.TabIndex = 6;
            this.lblGuestInfo.Text = "Guest Details:";

            // lblFirstName
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFirstName.Location = new System.Drawing.Point(12, 170);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 17);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name:";

            // txtFirstName
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(12, 190);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 23);
            this.txtFirstName.TabIndex = 8;

            // lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLastName.Location = new System.Drawing.Point(12, 220);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name:";

            // txtLastName
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLastName.Location = new System.Drawing.Point(12, 240);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 23);
            this.txtLastName.TabIndex = 10;

            // btnCreateGuest
            this.btnCreateGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCreateGuest.Location = new System.Drawing.Point(225, 230);
            this.btnCreateGuest.Name = "btnCreateGuest";
            this.btnCreateGuest.Size = new System.Drawing.Size(100, 25);
            this.btnCreateGuest.TabIndex = 11;
            this.btnCreateGuest.Text = "Create Guest";
            this.btnCreateGuest.UseVisualStyleBackColor = true;
            this.btnCreateGuest.Click += new System.EventHandler(this.btnCreateGuest_Click);

            // lblNumberOfGuests
            this.lblNumberOfGuests.AutoSize = true;
            this.lblNumberOfGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumberOfGuests.Location = new System.Drawing.Point(12, 270);
            this.lblNumberOfGuests.Name = "lblNumberOfGuests";
            this.lblNumberOfGuests.Size = new System.Drawing.Size(115, 17);
            this.lblNumberOfGuests.TabIndex = 12;
            this.lblNumberOfGuests.Text = "Number of Guests:";

            // txtNumberOfGuests
            this.txtNumberOfGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNumberOfGuests.Location = new System.Drawing.Point(12, 290);
            this.txtNumberOfGuests.Name = "txtNumberOfGuests";
            this.txtNumberOfGuests.Size = new System.Drawing.Size(200, 25);
            this.txtNumberOfGuests.TabIndex = 13;

            // lblCheckInDate
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCheckInDate.Location = new System.Drawing.Point(12, 320);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(91, 17);
            this.lblCheckInDate.TabIndex = 14;
            this.lblCheckInDate.Text = "Check-in Date:";

            // dtpCheckIn
            this.dtpCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpCheckIn.Location = new System.Drawing.Point(12, 340);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 25);
            this.dtpCheckIn.TabIndex = 15;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);

            // lblCheckOutDate
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCheckOutDate.Location = new System.Drawing.Point(12, 370);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(100, 17);
            this.lblCheckOutDate.TabIndex = 16;
            this.lblCheckOutDate.Text = "Check-out Date:";

            // dtpCheckOut
            this.dtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpCheckOut.Location = new System.Drawing.Point(12, 390);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 25);
            this.dtpCheckOut.TabIndex = 17;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);

            // lblRate
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRate.Location = new System.Drawing.Point(12, 420);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(43, 17);
            this.lblRate.TabIndex = 18;
            this.lblRate.Text = "Rate:";

            // txtRate
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRate.Location = new System.Drawing.Point(12, 440);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(200, 23);
            this.txtRate.TabIndex = 19;

            // btnSave
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(110, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(230, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfGuests)).EndInit();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 530);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.txtNumberOfGuests);
            this.Controls.Add(this.lblNumberOfGuests);
            this.Controls.Add(this.btnCreateGuest);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblGuestInfo);
            this.Controls.Add(this.btnCheckAvailability);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.txtReservationID);
            this.Controls.Add(this.lblReservationID);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReservationForm";
            this.Text = "New Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}