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
    public partial class CancelReservationForm : Form
    {
        private List<Reservation> reservations;
        private List<Room> availableRooms;
        private Reservation selectedReservation;

        public Reservation SelectedReservation
        {
            get { return selectedReservation; }
        }

        public CancelReservationForm(List<Reservation> reservations, List<Room> rooms)
        {
            InitializeComponent();
            this.reservations = reservations.FindAll(r => r.Status == ReservationStatus.Confirmed || r.Status == ReservationStatus.CheckedIn);
            availableRooms = rooms;
            SetupForm();
        }

        private void SetupForm()
        {
            // Populate listbox with cancellable reservations
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
                txtRate.Text = selectedReservation.Rate.ToString();

                // Calculate cancellation fee (50% of rate)
                decimal cancellationFee = selectedReservation.Rate * 0.5m;
                lblCancellationFee.Text = $"Cancellation Fee: ${cancellationFee:F2}";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (selectedReservation == null)
            {
                MessageBox.Show("Please select a reservation to cancel.");
                return;
            }

            // Confirm cancellation
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this reservation?", "Confirm Cancellation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Update reservation status
                selectedReservation.Status = ReservationStatus.Cancelled;
                selectedReservation.Room.Status = "Available";

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}