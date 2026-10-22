using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_System
{
    partial class CancelReservationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblCancellationFee;
        private System.Windows.Forms.ListBox lstReservations;
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
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblCancellationFee = new System.Windows.Forms.Label();
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cancel Reservation";

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

            // lblCheckInDate
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCheckInDate.Location = new System.Drawing.Point(12, 195);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(91, 17);
            this.lblCheckInDate.TabIndex = 7;
            this.lblCheckInDate.Text = "Check-in Date:";

            // dtpCheckIn
            this.dtpCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpCheckIn.Location = new System.Drawing.Point(12, 215);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 25);
            this.dtpCheckIn.TabIndex = 8;
            this.dtpCheckIn.ReadOnly = true;

            // lblCheckOutDate
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCheckOutDate.Location = new System.Drawing.Point(12, 245);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(100, 17);
            this.lblCheckOutDate.TabIndex = 9;
            this.lblCheckOutDate.Text = "Check-out Date:";

            // dtpCheckOut
            this.dtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpCheckOut.Location = new System.Drawing.Point(12, 265);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 25);
            this.dtpCheckOut.TabIndex = 10;
            this.dtpCheckOut.ReadOnly = true;

            // lblRate
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRate.Location = new System.Drawing.Point(12, 295);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(43, 17);
            this.lblRate.TabIndex = 11;
            this.lblRate.Text = "Rate:";

            // txtRate
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRate.Location = new System.Drawing.Point(12, 315);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(200, 23);
            this.txtRate.TabIndex = 12;
            this.txtRate.ReadOnly = true;

            // lblCancellationFee
            this.lblCancellationFee.AutoSize = true;
            this.lblCancellationFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCancellationFee.ForeColor = System.Drawing.Color.Red;
            this.lblCancellationFee.Location = new System.Drawing.Point(12, 345);
            this.lblCancellationFee.Name = "lblCancellationFee";
            this.lblCancellationFee.Size = new System.Drawing.Size(154, 20);
            this.lblCancellationFee.TabIndex = 13;
            this.lblCancellationFee.Text = "Cancellation Fee: $0.00";

            // lstReservations
            this.lstReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.ItemHeight = 20;
            this.lstReservations.Location = new System.Drawing.Point(230, 45);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(400, 300);
            this.lstReservations.TabIndex = 14;
            this.lstReservations.SelectedIndexChanged += new System.EventHandler(this.lstReservations_SelectedIndexChanged);

            // btnCancel
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(470, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel Reservation";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 410);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCancellationFee);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtReservationID);
            this.Controls.Add(this.lblReservationID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstReservations);
            this.Name = "CancelReservationForm";
            this.Text = "Cancel Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}