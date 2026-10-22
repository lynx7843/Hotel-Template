using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class ReservationForm : Form
    {
        private List<Room> availableRooms;
        private List<Reservation> existingReservations;
        private Reservation reservation;
        private bool isEditing;

        public Reservation Reservation
        {
            get { return reservation; }
        }

        public ReservationForm(List<Room> rooms, List<Reservation> reservations)
        {
            InitializeComponent();
            availableRooms = rooms.FindAll(r => r.Status == "Available");
            existingReservations = reservations;
            reservation = new Reservation();
            isEditing = false;
            SetupForm();
        }

        public ReservationForm(List<Room> rooms, List<Reservation> reservations, Reservation reservationToEdit)
        {
            InitializeComponent();
            availableRooms = rooms.FindAll(r => r.Status == "Available");
            existingReservations = reservations;
            reservation = reservationToEdit;
            isEditing = true;
            SetupForm();
        }

        private void SetupForm()
        {
            // Populate room dropdown
            cmbRoom.Items.Clear();
            foreach (var room in availableRooms)
            {
                cmbRoom.Items.Add(room);
            }

            // Set selected room if editing
            if (!isEditing)
            {
                txtReservationID.Text = reservation.ReservationID;
                txtFirstName.Text = reservation.Guest?.FirstName;
                txtLastName.Text = reservation.Guest?.LastName;
                txtNumberOfGuests.Value = reservation.NumberOfGuests;
                dtpCheckIn.Value = reservation.CheckInDate;
                dtpCheckOut.Value = reservation.CheckOutDate;
            }
            else
            {
                txtReservationID.Text = reservation.ReservationID;
                cmbRoom.SelectedItem = reservation.Room;
                txtFirstName.Text = reservation.Guest?.FirstName;
                txtLastName.Text = reservation.Guest?.LastName;
                txtNumberOfGuests.Value = reservation.NumberOfGuests;
                dtpCheckIn.Value = reservation.CheckInDate;
                dtpCheckOut.Value = reservation.CheckOutDate;
                txtRate.Text = reservation.Rate.ToString();
            }
        }

        private void btnCreateGuest_Click(object sender, EventArgs e)
        {
            var guestForm = new GuestForm();
            if (guestForm.ShowDialog() == DialogResult.OK)
            {
                // Add the guest to the guests list
                // Note: In a real application, you'd have a master guest list
                // For now, we'll just use the guest from the form
            }
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            CheckRoomAvailability();n        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            CheckRoomAvailability();
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            CheckRoomAvailability();
        }

        private void CheckRoomAvailability()
        {
            // Check if selected room is available for the dates
            // In a real implementation, you'd check the reservation list
            // For now, we'll show a message
            MessageBox.Show("Room availability check would be implemented here.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbRoom.SelectedItem == null)
            {
                MessageBox.Show("Please select a room.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First name and last name are required.");
                return;
            }

            reservation.Room = cmbRoom.SelectedItem as Room;
            reservation.NumberOfGuests = (int)txtNumberOfGuests.Value;
            reservation.CheckInDate = dtpCheckIn.Value;
            reservation.CheckOutDate = dtpCheckOut.Value;
            reservation.Rate = !string.IsNullOrEmpty(txtRate.Text) ? decimal.Parse(txtRate.Text) : 0;

            // If guest doesn't exist, create a new guest
            if (reservation.Guest == null)
            {
                reservation.Guest = new Guest
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    GuestID = "G" + DateTime.Now.Ticks.ToString().Substring(0, 8),
                    Phone = "Not provided",
                    Email = "Not provided",
                    StayHistory = new List<Reservation>(),
                    Preferences = new Dictionary<string, string>()
                };
            }
            else
            {
                reservation.Guest.FirstName = txtFirstName.Text.Trim();
                reservation.Guest.LastName = txtLastName.Text.Trim();n            }

            reservation.Status = ReservationStatus.Confirmed;
            reservation.BookingDate = DateTime.Now;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}