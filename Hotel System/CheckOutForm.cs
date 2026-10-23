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
    public partial class CheckOutForm : Form
    {
        private List<Reservation> reservations;
        private List<Room> rooms;
        private Reservation selectedReservation;

        public Reservation SelectedReservation
        {
            get { return selectedReservation; }
        }

        public CheckOutForm(List<Reservation> reservations, List<Room> rooms)
        {
            InitializeComponent();
            this.reservations = reservations.FindAll(r => r.Status == ReservationStatus.CheckedIn);
            this.rooms = rooms;
            SetupForm();
        }

        private void SetupForm()
        {
            // Populate listbox with checked-in reservations
            lstReservations.Items.Clear();
            foreach (var reservation in reservations)
            {
                lstReservations.Items.Add($"{reservation.ReservationID} - {reservation.Guest?.FirstName} {reservation.Guest?.LastName} - Room {reservation.Room?.RoomNumber} - {reservation.CheckInDate:yyyy-MM-dd} to {reservation.CheckOutDate:yyyy-MM-dd}");
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (lstReservations.SelectedIndex >= 0)
            {
                // Get the selected reservation
                int index = lstReservations.SelectedIndex;
                selectedReservation = reservations[index];

                // Check if already checked out
                if (selectedReservation.Status == ReservationStatus.CheckedOut)
                {
                    MessageBox.Show("This reservation has already been checked out.");
                    return;
                }

                // Update reservation status
                selectedReservation.Status = ReservationStatus.CheckedOut;
                selectedReservation.Room.Status = "Available";

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a reservation to check out.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}