using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_System
{
    partial class RoomMoveForm
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
        private System.Windows.Forms.Label lblNewRoom;
        private System.Windows.Forms.ComboBox cmbNewRoom;
        private System.Windows.Forms.ListBox lstReservations;
        private System.Windows.Forms.Button btnMove;
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
            this.lblNewRoom = new System.Windows.Forms.Label();
            this.cmbNewRoom = new System.Windows.Forms.ComboBox();
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Room Move";

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

            // lblNewRoom
            this.lblNewRoom.AutoSize = true;
            this.lblNewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNewRoom.Location = new System.Drawing.Point(12, 245);
            this.lblNewRoom.Name = "lblNewRoom";
            this.lblNewRoom.Size = new System.Drawing.Size(87, 17);
            this.lblNewRoom.TabIndex = 9;
            this.lblNewRoom.Text = "New Room:";

            // cmbNewRoom
            this.cmbNewRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbNewRoom.Location = new System.Drawing.Point(12, 265);
            this.cmbNewRoom.Name = "cmbNewRoom";
            this.cmbNewRoom.Size = new System.Drawing.Size(200, 25);
            this.cmbNewRoom.TabIndex = 10;

            // lstReservations
            this.lstReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.ItemHeight = 20;
            this.lstReservations.Location = new System.Drawing.Point(230, 45);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(400, 300);
            this.lstReservations.TabIndex = 11;
            this.lstReservations.SelectedIndexChanged += new System.EventHandler(this.lstReservations_SelectedIndexChanged);

            // btnMove
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMove.Location = new System.Drawing.Point(230, 360);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(100, 35);
            this.btnMove.TabIndex = 12;
            this.btnMove.Text = "Move Room";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);

            // btnCancel
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(350, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 410);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lstReservations);
            this.Controls.Add(this.cmbNewRoom);
            this.Controls.Add(this.lblNewRoom);
            this.Controls.Add(this.txtCurrentRoom);
            this.Controls.Add(this.lblCurrentRoom);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtReservationID);
            this.Controls.Add(this.lblReservationID);
            this.Controls.Add(this.lblTitle);
            this.Name = "RoomMoveForm";
            this.Text = "Room Move";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}