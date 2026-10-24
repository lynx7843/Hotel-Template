using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_System
{
    partial class GuestForm
    {
        // Form controls
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label lblPassportID;
        private System.Windows.Forms.TextBox txtPassportID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grpPreferences;
        private System.Windows.Forms.ListBox lstPreferences;
        private System.Windows.Forms.Button btnAddPreference;
        private System.Windows.Forms.Button btnEditPreference;
        private System.Windows.Forms.Button btnRemovePreference;
        private System.Windows.Forms.GroupBox grpStayHistory;
        private System.Windows.Forms.ListBox lstStayHistory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.lblPassportID = new System.Windows.Forms.Label();
            this.txtPassportID = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpPreferences = new System.Windows.Forms.GroupBox();
            this.lstPreferences = new System.Windows.Forms.ListBox();
            this.btnAddPreference = new System.Windows.Forms.Button();
            this.btnEditPreference = new System.Windows.Forms.Button();
            this.btnRemovePreference = new System.Windows.Forms.Button();
            this.grpStayHistory = new System.Windows.Forms.GroupBox();
            this.lstStayHistory = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpPreferences.SuspendLayout();
            this.grpStayHistory.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Guest Profile Management";

            // lblFirstName
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFirstName.Location = new System.Drawing.Point(12, 45);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 17);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";

            // txtFirstName
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(12, 65);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 23);
            this.txtFirstName.TabIndex = 2;

            // lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLastName.Location = new System.Drawing.Point(12, 95);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";

            // txtLastName
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLastName.Location = new System.Drawing.Point(12, 115);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 23);
            this.txtLastName.TabIndex = 4;

            // lblGuestID
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGuestID.Location = new System.Drawing.Point(12, 145);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(68, 17);
            this.lblGuestID.TabIndex = 5;
            this.lblGuestID.Text = "Guest ID:";

            // txtGuestID
            this.txtGuestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGuestID.Location = new System.Drawing.Point(12, 165);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(200, 23);
            this.txtGuestID.TabIndex = 6;

            // lblPassportID
            this.lblPassportID.AutoSize = true;
            this.lblPassportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPassportID.Location = new System.Drawing.Point(12, 195);
            this.lblPassportID.Name = "lblPassportID";
            this.lblPassportID.Size = new System.Drawing.Size(96, 17);
            this.lblPassportID.TabIndex = 7;
            this.lblPassportID.Text = "Passport ID:";

            // txtPassportID
            this.txtPassportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassportID.Location = new System.Drawing.Windows.Forms.Point(12, 215);
            this.txtPassportID.Name = "txtPassportID";
            this.txtPassportID.Size = new System.Drawing.Size(200, 23);
            this.txtPassportID.TabIndex = 8;

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhone.Location = new System.Drawing.Point(12, 245);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 17);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone:";

            // txtPhone
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhone.Location = new System.Drawing.Point(12, 265);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 23);
            this.txtPhone.TabIndex = 10;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmail.Location = new System.Drawing.Point(12, 295);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 17);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmail.Location = new System.Drawing.Point(12, 315);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            this.txtEmail.TabIndex = 12;

            // grpPreferences
            this.grpPreferences.Controls.Add(this.lstPreferences);
            this.grpPreferences.Controls.Add(this.btnAddPreference);
            this.grpPreferences.Controls.Add(this.btnEditPreference);
            this.grpPreferences.Controls.Add(this.btnRemovePreference);
            this.grpPreferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpPreferences.Location = new System.Drawing.Point(225, 45);
            this.grpPreferences.Name = "grpPreferences";
            this.grpPreferences.Size = new System.Drawing.Size(200, 160);
            this.grpPreferences.TabIndex = 13;
            this.grpPreferences.TabStop = false;
            this.grpPreferences.Text = "Guest Preferences";

            // lstPreferences
            this.lstPreferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lstPreferences.FormattingEnabled = true;
            this.lstPreferences.ItemHeight = 15;
            this.lstPreferences.Location = new System.Drawing.Point(6, 45);
            this.lstPreferences.Name = "lstPreferences";
            this.lstPreferences.Size = new System.Drawing.Size(188, 105);
            this.lstPreferences.TabIndex = 0;

            // btnAddPreference
            this.btnAddPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddPreference.Location = new System.Drawing.Point(6, 156);
            this.btnAddPreference.Name = "btnAddPreference";
            this.btnAddPreference.Size = new System.Drawing.Size(60, 25);
            this.btnAddPreference.TabIndex = 1;
            this.btnAddPreference.Text = "Add";
            this.btnAddPreference.UseVisualStyleBackColor = true;
            this.btnAddPreference.Click += new System.EventHandler(this.btnAddPreference_Click);

            // btnEditPreference
            this.btnEditPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnEditPreference.Location = new System.Drawing.Point(72, 156);
            this.btnEditPreference.Name = "btnEditPreference";
            this.btnEditPreference.Size = new System.Drawing.Size(60, 25);
            this.btnEditPreference.TabIndex = 2;
            this.btnEditPreference.Text = "Edit";
            this.btnEditPreference.UseVisualStyleBackColor = true;
            this.btnEditPreference.Click += new System.EventHandler(this.btnEditPreference_Click);

            // btnRemovePreference
            this.btnRemovePreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnRemovePreference.Location = new System.Drawing.Point(138, 156);
            this.btnRemovePreference.Name = "btnRemovePreference";
            this.btnRemovePreference.Size = new System.Drawing.Size(60, 25);
            this.btnRemovePreference.TabIndex = 3;
            this.btnRemovePreference.Text = "Remove";
            this.btnRemovePreference.UseVisualStyleBackColor = true;
            this.btnRemovePreference.Click += new System.EventHandler(this.btnRemovePreference_Click);

            // grpStayHistory
            this.grpStayHistory.Controls.Add(this.lstStayHistory);
            this.grpStayHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpStayHistory.Location = new System.Drawing.Point(225, 220);
            this.grpStayHistory.Name = "grpStayHistory";
            this.grpStayHistory.Size = new System.Drawing.Size(400, 200);
            this.grpStayHistory.TabIndex = 14;
            this.grpStayHistory.TabStop = false;
            this.grpStayHistory.Text = "Stay History";

            // lstStayHistory
            this.lstStayHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lstStayHistory.FormattingEnabled = true;
            this.lstStayHistory.ItemHeight = 15;
            this.lstStayHistory.Location = new System.Drawing.Point(6, 25);
            this.lstStayHistory.Name = "lstStayHistory";
            this.lstStayHistory.Size = new System.Drawing.Size(388, 165);
            this.lstStayHistory.TabIndex = 0;

            // btnSave
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(450, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);\n            this.btnCancel.Location = new System.Drawing.Point(560, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.grpPreferences.ResumeLayout(false);
            this.grpStayHistory.ResumeLayout(false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 490);
            this.Controls.Add(this.grpStayHistory);
            this.Controls.Add(this.grpPreferences);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPassportID);
            this.Controls.Add(this.lblPassportID);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "GuestForm";
            this.Text = "Guest Profile Management";
            this.grpPreferences.ResumeLayout(false);
            this.grpStayHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}