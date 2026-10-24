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
    public partial class RoomMoveForm : Form
    {
        private List<Reservation> reservations;
        private List<Room> allRooms;
        private List<Room> availableRooms;
        private Reservation selectedReservation;

        public Reservation SelectedReservation
        {
            get { return selectedReservation; }
        }

        public RoomMoveForm(List<Reservation> reservations, List<Room> rooms)
        {
            InitializeComponent();
            this.reservations = reservations.FindAll(r => r.Status == ReservationStatus.CheckedIn);
            allRooms = rooms;
            availableRooms = rooms.FindAll(r => r.Status == "Available");
            SetupForm();
        }

        private void SetupForm()
        {
            // Populate listbox with checked-in reservations
            lstReservations.Items.Clear();
            foreach (var reservation in reservations)
            {
                lstReservations.Items.Add($"{reservation.ReservationID} - {reservation.Guest?.FirstName} {reservation.Guest?.LastName} - Current Room {reservation.Room?.RoomNumber}");
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

                // Populate available rooms dropdown
                cmbNewRoom.Items.Clear();
                foreach (var room in availableRooms)
                {
                    cmbNewRoom.Items.Add(room);
                }
                cmbNewRoom.SelectedItem = null;
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (selectedReservation == null)
            {
                MessageBox.Show("Please select a reservation to move.");
                return;
            }

            if (cmbNewRoom.SelectedItem == null)
            {
                MessageBox.Show("Please select a new room.");
                return;
            }

            // Get the new room
            Room newRoom = cmbNewRoom.SelectedItem as Room;

            // Confirm move
            DialogResult result = MessageBox.Show(
                $"Move guest {selectedReservation.Guest?.FirstName} {selectedReservation.Guest?.LastName} from Room {selectedReservation.Room?.RoomNumber} to Room {newRoom.RoomNumber}?",
                "Confirm Room Move",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Free up old room
                if (selectedReservation.Room != null)
                {
                    selectedReservation.Room.Status = "Available";
                }

                // Assign new room
                selectedReservation.Room = newRoom;
                selectedReservation.Room.Status = "Occupied";

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