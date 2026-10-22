using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_System
{
    partial class HotelManagement
    {
        // These fields need to be declared to match the designer
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.TableLayoutPanel leftPanel;
        private System.Windows.Forms.TableLayoutPanel dashboardPanel;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.Label lblOccupiedRooms;
        private System.Windows.Forms.Label lblReservationsToday;
        private System.Windows.Forms.Panel calendarPanel;
        private System.Windows.Forms.Label lblCalendarTitle;
        private System.Windows.Forms.FlowLayoutPanel calendarFlow;
        private System.Windows.Forms.TableLayoutPanel rightPanel;
        private System.Windows.Forms.TableLayoutPanel actionButtonsPanel;
        private System.Windows.Forms.Button btnNewReservation;
        private System.Windows.Forms.Button btnWalkIn;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnModifyReservation;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Button btnRoomMove;
        private System.Windows.Forms.Button btnExtendStay;
        private System.Windows.Forms.Panel guestPanel;
        private System.Windows.Forms.Label lblGuestInfoTitle;
        private System.Windows.Forms.ListBox lstGuests;
        private System.Windows.Forms.Panel reservationsPanel;
        private System.Windows.Forms.Label lblReservationsTitle;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel bottomPanel;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dashboardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.lblOccupiedRooms = new System.Windows.Forms.Label();
            this.lblReservationsToday = new System.Windows.Forms.Label();
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.lblCalendarTitle = new System.Windows.Forms.Label();
            this.calendarFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.rightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.actionButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewReservation = new System.Windows.Forms.Button();
            this.btnWalkIn = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnModifyReservation = new System.Windows.Forms.Button();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.btnRoomMove = new System.Windows.Forms.Button();
            this.btnExtendStay = new System.Windows.Forms.Button();
            this.guestPanel = new System.Windows.Forms.Panel();
            this.lblGuestInfoTitle = new System.Windows.Forms.Label();
            this.lstGuests = new System.Windows.Forms.ListBox();
            this.reservationsPanel = new System.Windows.Forms.Panel();
            this.lblReservationsTitle = new System.Windows.Forms.Label();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bottomPanel = new System.Windows.Forms.Panel();

            // mainTableLayout
            this.mainTableLayout.ColumnCount = 3;
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.headerPanel, 0, 0);
            this.mainTableLayout.Controls.Add(this.leftPanel, 0, 1);
            this.mainTableLayout.Controls.Add(this.calendarPanel, 1, 1);
            this.mainTableLayout.Controls.Add(this.rightPanel, 2, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Margin = new System.Windows.Forms.Padding(0);

            // headerPanel
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblDateTime);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Padding = new System.Windows.Forms.Padding(20);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Hotel Management System";

            // lblDateTime
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(1000, 20);
            this.lblDateTime.Text = "Label";

            // leftPanel
            this.leftPanel.ColumnCount = 1;
            this.leftPanel.RowCount = 2;
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.leftPanel.Controls.Add(this.dashboardPanel, 0, 0);
            this.leftPanel.Controls.Add(this.guestPanel, 0, 1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Padding = new System.Windows.Forms.Padding(10);

            // dashboardPanel
            this.dashboardPanel.ColumnCount = 2;
            this.dashboardPanel.RowCount = 2;
            this.dashboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dashboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dashboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dashboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dashboardPanel.Controls.Add(this.lblTotalRooms, 0, 0);
            this.dashboardPanel.Controls.Add(this.lblAvailableRooms, 1, 0);
            this.dashboardPanel.Controls.Add(this.lblOccupiedRooms, 0, 1);
            this.dashboardPanel.Controls.Add(this.lblReservationsToday, 1, 1);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Padding = new System.Windows.Forms.Padding(10);

            // lblTotalRooms
            this.lblTotalRooms.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblTotalRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalRooms.ForeColor = System.Drawing.Color.White;
            this.lblTotalRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalRooms.Padding = new System.Windows.Forms.Padding(10);
            this.lblTotalRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalRooms.Text = "0";

            // lblAvailableRooms
            this.lblAvailableRooms.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.lblAvailableRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblAvailableRooms.ForeColor = System.Drawing.Color.White;
            this.lblAvailableRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailableRooms.Padding = new System.Windows.Forms.Padding(10);
            this.lblAvailableRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAvailableRooms.Text = "0";

            // lblOccupiedRooms
            this.lblOccupiedRooms.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblOccupiedRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblOccupiedRooms.ForeColor = System.Drawing.Color.White;
            this.lblOccupiedRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOccupiedRooms.Padding = new System.Windows.Forms.Padding(10);
            this.lblOccupiedRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOccupiedRooms.Text = "0";

            // lblReservationsToday
            this.lblReservationsToday.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.lblReservationsToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblReservationsToday.ForeColor = System.Drawing.Color.White;
            this.lblReservationsToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReservationsToday.Padding = new System.Windows.Forms.Padding(10);
            this.lblReservationsToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReservationsToday.Text = "0";

            // guestPanel
            this.guestPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guestPanel.Controls.Add(this.lblGuestInfoTitle);
            this.guestPanel.Controls.Add(this.lstGuests);
            this.guestPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guestPanel.Padding = new System.Windows.Forms.Padding(10);

            // lblGuestInfoTitle
            this.lblGuestInfoTitle.AutoSize = true;
            this.lblGuestInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblGuestInfoTitle.Location = new System.Drawing.Point(10, 10);
            this.lblGuestInfoTitle.Text = "Recent Guests";

            // lstGuests
            this.lstGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstGuests.FormattingEnabled = true;
            this.lstGuests.ItemHeight = 20;
            this.lstGuests.Location = new System.Drawing.Point(10, 40);
            this.lstGuests.Name = "lstGuests";

            // calendarPanel
            this.calendarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calendarPanel.Controls.Add(this.lblCalendarTitle);
            this.calendarPanel.Controls.Add(this.calendarFlow);
            this.calendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarPanel.Padding = new System.Windows.Forms.Padding(10);

            // lblCalendarTitle
            this.lblCalendarTitle.AutoSize = true;
            this.lblCalendarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCalendarTitle.Location = new System.Drawing.Point(10, 10);
            this.lblCalendarTitle.Text = "Room Availability Calendar (Next 30 Days)";

            // calendarFlow
            this.calendarFlow.AutoScroll = true;
            this.calendarFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

            // rightPanel
            this.rightPanel.ColumnCount = 1;
            this.rightPanel.RowCount = 2;
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.rightPanel.Controls.Add(this.actionButtonsPanel, 0, 0);
            this.rightPanel.Controls.Add(this.reservationsPanel, 0, 1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Padding = new System.Windows.Forms.Padding(10);

            // actionButtonsPanel
            this.actionButtonsPanel.ColumnCount = 2;
            this.actionButtonsPanel.RowCount = 4;
            this.actionButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.actionButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            for (int i = 0; i < 4; i++)
            {
                this.actionButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeSizeType.Absolute, 60F));
            }
            this.actionButtonsPanel.Controls.Add(this.btnNewReservation, 0, 0);
            this.actionButtonsPanel.Controls.Add(this.btnWalkIn, 0, 1);
            this.actionButtonsPanel.Controls.Add(this.btnCheckIn, 0, 2);
            this.actionButtonsPanel.Controls.Add(this.btnCheckOut, 1, 0);
            this.actionButtonsPanel.Controls.Add(this.btnModifyReservation, 1, 1);
            this.actionButtonsPanel.Controls.Add(this.btnCancelReservation, 1, 2);
            this.actionButtonsPanel.Controls.Add(this.btnRoomMove, 0, 3);
            this.actionButtonsPanel.Controls.Add(this.btnExtendStay, 1, 3);
            this.actionButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionButtonsPanel.Padding = new System.Windows.Forms.Padding(10);

            // btnNewReservation
            this.btnNewReservation.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnNewReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewReservation.ForeColor = System.Drawing.Color.White;
            this.btnNewReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewReservation.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewReservation.Text = "New Reservation";
            this.btnNewReservation.UseVisualStyleBackColor = false;
            this.btnNewReservation.Click += new System.EventHandler(this.btnNewReservation_Click);

            // btnWalkIn
            this.btnWalkIn.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnWalkIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnWalkIn.ForeColor = System.Drawing.Color.White;
            this.btnWalkIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWalkIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnWalkIn.Text = "Walk-in Guest";
            this.btnWalkIn.UseVisualStyleBackColor = false;
            this.btnWalkIn.Click += new System.EventHandler(this.btnWalkIn_Click);

            // btnCheckIn
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnCheckIn.Text = "Check-in";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);

            // btnCheckOut
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(5);
            this.btnCheckOut.Text = "Check-out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);

            // btnModifyReservation
            this.btnModifyReservation.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnModifyReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifyReservation.ForeColor = System.Drawing.Color.White;
            this.btnModifyReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModifyReservation.Margin = new System.Windows.Forms.Padding(5);
            this.btnModifyReservation.Text = "Modify Reservation";
            this.btnModifyReservation.UseVisualStyleBackColor = false;
            this.btnModifyReservation.Click += new System.EventHandler(this.btnModifyReservation_Click);

            // btnCancelReservation
            this.btnCancelReservation.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnCancelReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelReservation.ForeColor = System.Drawing.Color.White;
            this.btnCancelReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelReservation.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = false;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);

            // btnRoomMove
            this.btnRoomMove.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.btnRoomMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRoomMove.ForeColor = System.Drawing.Color.White;
            this.btnRoomMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRoomMove.Margin = new System.Windows.Forms.Padding(5);
            this.btnRoomMove.Text = "Room Move";
            this.btnRoomMove.UseVisualStyleBackColor = false;
            this.btnRoomMove.Click += new System.EventHandler(this.btnRoomMove_Click);

            // btnExtendStay
            this.btnExtendStay.BackColor = System.Drawing.Color.FromArgb(26, 188, 156);
            this.btnExtendStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExtendStay.ForeColor = System.Drawing.Color.White;
            this.btnExtendStay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExtendStay.Margin = new System.Windows.Forms.Padding(5);
            this.btnExtendStay.Text = "Extend Stay";
            this.btnExtendStay.UseVisualStyleBackColor = false;
            this.btnExtendStay.Click += new System.EventHandler(this.btnExtendStay_Click);

            // guestPanel
            this.guestPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guestPanel.Controls.Add(this.lblGuestInfoTitle);
            this.guestPanel.Controls.Add(this.lstGuests);
            this.guestPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guestPanel.Padding = new System.Windows.Forms.Padding(10);

            // lblGuestInfoTitle
            this.lblGuestInfoTitle.AutoSize = true;
            this.lblGuestInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblGuestInfoTitle.Location = new System.Drawing.Point(10, 10);
            this.lblGuestInfoTitle.Text = "Recent Guests";

            // lstGuests
            this.lstGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstGuests.FormattingEnabled = true;
            this.lstGuests.ItemHeight = 20;
            this.lstGuests.Location = new System.Drawing.Point(10, 40);
            this.lstGuests.Name = "lstGuests";

            // reservationsPanel
            this.reservationsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reservationsPanel.Controls.Add(this.lblReservationsTitle);
            this.reservationsPanel.Controls.Add(this.dgvReservations);
            this.reservationsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationsPanel.Padding = new System.Windows.Forms.Padding(10);

            // lblReservationsTitle
            this.lblReservationsTitle.AutoSize = true;
            this.lblReservationsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblReservationsTitle.Location = new System.Drawing.Point(10, 10);
            this.lblReservationsTitle.Text = "Recent Reservations";

            // dgvReservations
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservations.Location = new System.Drawing.Point(10, 40);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridStyle.FullRowSelect;

            // bottomPanel
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Height = 30;
            this.mainTableLayout.SetRow(this.bottomPanel, 1);
            this.mainTableLayout.SetColumnSpan(this.bottomPanel, 3);

            this.Controls.Add(this.mainTableLayout);
        }
    }
}