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
    public partial class ExtendStayForm : Form
    {
        private List<Reservation> reservations;
        private List<Room> rooms;
        private Reservation selectedReservation;

        public Reservation SelectedReservation
        {
            get { return selectedReservation; }
        }

        public ExtendStayForm(List<Reservation> reservations, List<Room> rooms)
        {
            InitializeComponent();
            this.reservations = reservations.FindAll(r => r.Status == ReservationStatus.CheckedIn);
            this.rooms = rooms;
            SetupForm();
        }

        private void SetupForm()
        {
            // Populate listbox with extendable reservations
            lstReservations.Items.Clear();
            foreach (var reservation in reservations)
            {
                lstReservations.Items.Add($"{reservation.ReservationID} - {reservation.Guest?.FirstName} {reservation.Guest?.LastName} - Room {reservation.Room?.RoomNumber} - Check-out: {reservation.CheckOutDate:yyyy-MM-dd}");
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
                txtCurrentRoom.Text = selectedReservation.Room?.RoomNumber.ToString();
                txtCurrentNights.Text = (selectedReservation.CheckOutDate - selectedReservation.CheckInDate).Days.ToString();

                // Clear new dates
                dtpNewCheckOut.Value = selectedReservation.CheckOutDate.AddDays(1);
                lblNewRate.Text = "$0.00";
            }
        }

        private void dtpNewCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (selectedReservation != null)
            {
                // Calculate new rate based on extension
                int originalNights = (selectedReservation.CheckOutDate - selectedReservation.CheckInDate).Days;
                int newNights = (dtpNewCheckOut.Value - selectedReservation.CheckInDate).Days;

                if (newNights > originalNights)
                {
                    decimal extraNights = newNights - originalNights;
                    decimal newRate = selectedReservation.Rate * extraNights;
                    lblNewRate.Text = $"${newRate:F2}";
                }
            }
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            if (selectedReservation == null)
            {
                MessageBox.Show("Please select a reservation to extend.");
                return;
            }

            // Validate extension
            if (dtpNewCheckOut.Value <= selectedReservation.CheckOutDate)
            {
                MessageBox.Show("New check-out date must be after current check-out date.");
                return;
            }

            // Confirm extension
            DialogResult result = MessageBox.Show(
                $"Extend stay for {selectedReservation.Guest?.FirstName} {selectedReservation.Guest?.LastName} from {selectedReservation.CheckOutDate:yyyy-MM-dd} to {dtpNewCheckOut.Value:yyyy-MM-dd}?",
                "Confirm Stay Extension",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Update reservation dates
                selectedReservation.CheckOutDate = dtpNewCheckOut.Value;
                selectedReservation.Status = ReservationStatus.Extended;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}