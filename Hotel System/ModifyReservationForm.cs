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
    public partial class ModifyReservationForm : Form
    {
        private List<Reservation> reservations;
        private List<Room> availableRooms;
        private Reservation selectedReservation;

        public Reservation SelectedReservation
        {
            get { return selectedReservation; }
        }

        public ModifyReservationForm(List<Reservation> reservations, List<Room> rooms)
        {
            InitializeComponent();
            this.reservations = reservations.FindAll(r => r.Status == ReservationStatus.Confirmed || r.Status == ReservationStatus.CheckedIn);
            availableRooms = rooms.FindAll(r => r.Status == "Available");
            SetupForm();
        }

        private void SetupForm()
        {
            // Populate listbox with modifiable reservations
            lstReservations.Items.Clear();
            foreach (var reservation in reservations)
            {
                lstReservations.Items.Add($"{reservation.ReservationID} - {reservation.Guest?.FirstName} {reservation.Guest?.LastName} - Room {reservation.Room?.RoomNumber} - {reservation.CheckInDate:yyyy-MM-dd} to {reservation.CheckOutDate:yyyy-MM-dd} - {reservation.Status}");
            }
        }

        private void lstReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstReservations.SelectedIndex >= 0)
            {
                // Get the selected reservation
                int index = lstReservations.SelectedIndex;
                selectedReservation = reservations[index];

                // Display reservation details
                txtReservationID.Text = selectedReservation.ReservationID;
                txtFirstName.Text = selectedReservation.Guest?.FirstName;
                txtLastName.Text = selectedReservation.Guest?.LastName;
                dtpCheckIn.Value = selectedReservation.CheckInDate;
                dtpCheckOut.Value = selectedReservation.CheckOutDate;
                txtNumberOfGuests.Value = selectedReservation.NumberOfGuests;
                txtRate.Text = selectedReservation.Rate.ToString();

                // Enable room dropdown
                cmbRoom.Enabled = true;
                cmbRoom.Items.Clear();
                foreach (var room in availableRooms)
                {
                    cmbRoom.Items.Add(room);
                }
                cmbRoom.SelectedItem = selectedReservation.Room;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedReservation == null)
            {
                MessageBox.Show("Please select a reservation to modify.");
                return;
            }

            // Update reservation details
            selectedReservation.CheckInDate = dtpCheckIn.Value;
            selectedReservation.CheckOutDate = dtpCheckOut.Value;
            selectedReservation.NumberOfGuests = (int)txtNumberOfGuests.Value;
            selectedReservation.Rate = !string.IsNullOrEmpty(txtRate.Text) ? decimal.Parse(txtRate.Text) : 0;

            // Update room if changed
            if (cmbRoom.SelectedItem != null && cmbRoom.SelectedItem != selectedReservation.Room)
            {
                // Free up old room
                if (selectedReservation.Room != null)
                {
                    selectedReservation.Room.Status = "Available";
                }

                // Assign new room
                selectedReservation.Room = cmbRoom.SelectedItem as Room;
                selectedReservation.Room.Status = "Booked";
            }

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