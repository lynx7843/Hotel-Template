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
    public partial class HotelManagement : Form
    {
        // Data structures for hotel management
        public class Room
        {
            public int RoomNumber { get; set; }
            public string RoomType { get; set; }
            public decimal Rate { get; set; }
            public int Capacity { get; set; }
            public bool IsAvailable { get; set; }
            public string Status { get; set; } // Available, Booked, Occupied, Maintenance
        }

        public class Guest
        {
            public string GuestID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PassportID { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public List<Reservation> StayHistory { get; set; }
            public Dictionary<string, string> Preferences { get; set; }
        }

        public class Reservation
        {
            public string ReservationID { get; set; }
            public Guest Guest { get; set; }
            public Room Room { get; set; }
            public DateTime CheckInDate { get; set; }
            public DateTime CheckOutDate { get; set; }
            public int NumberOfGuests { get; set; }
            public decimal Rate { get; set; }
            public ReservationStatus Status { get; set; }
            public DateTime BookingDate { get; set; }
        }

        public enum ReservationStatus
        {
            Confirmed,
            CheckedIn,
            CheckedOut,
            Cancelled,
            NoShow,
            Extended
        }

        // Data collections
        private List<Room> rooms = new List<Room>();
        private List<Guest> guests = new List<Guest>();
        private List<Reservation> reservations = new List<Reservation>();
        private Dictionary<DateTime, List<Room>> roomAvailability = new Dictionary<DateTime, List<Room>>();

        public HotelManagement()
        {
            InitializeComponent();
            InitializeHotelData();
            LoadDashboardStats();
        }

        private void InitializeHotelData()
        {
            // Initialize sample rooms
            rooms.Add(new Room { RoomNumber = 101, RoomType = "Standard", Rate = 100m, Capacity = 2, IsAvailable = true, Status = "Available" });
            rooms.Add(new Room { RoomNumber = 102, RoomType = "Standard", Rate = 100m, Capacity = 2, IsAvailable = true, Status = "Available" });
            rooms.Add(new Room { RoomNumber = 103, RoomType = "Deluxe", Rate = 150m, Capacity = 3, IsAvailable = true, Status = "Available" });
            rooms.Add(new Room { RoomNumber = 104, RoomType = "Suite", Rate = 250m, Capacity = 4, IsAvailable = true, Status = "Available" });
            rooms.Add(new Room { RoomNumber = 201, RoomType = "Executive", Rate = 200m, Capacity = 3, IsAvailable = true, Status = "Available" });
            
            // Initialize room availability calendar
            for (DateTime date = DateTime.Today; date <= DateTime.Today.AddDays(30); date = date.AddDays(1))
            {
                roomAvailability[date] = new List<Room>(rooms.FindAll(r => r.Status == "Available"));
            }
        }

        private void LoadDashboardStats()
        {
            lblTotalRooms.Text = rooms.Count.ToString();
            lblAvailableRooms.Text = rooms.Count(r => r.Status == "Available").ToString();
            lblOccupiedRooms.Text = rooms.Count(r => r.Status == "Occupied").ToString();
            lblReservationsToday.Text = reservations.Count(r => r.CheckInDate.Date == DateTime.Today && r.Status == ReservationStatus.CheckedIn).ToString();
        }

        // Front Desk and Reservations Methods
        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            ShowReservationForm();
        }

        private void btnWalkIn_Click(object sender, EventArgs e)
        {
            // Handle walk-in guest
            var guestForm = new GuestForm();
            if (guestForm.ShowDialog() == DialogResult.OK)
            {
                var guest = guestForm.Guest;
                var reservation = new Reservation
                {
                    ReservationID = GenerateReservationID(),
                    Guest = guest,
                    CheckInDate = DateTime.Today,
                    CheckOutDate = DateTime.Today.AddDays(1),
                    NumberOfGuests = 1,
                    Rate = 100m,
                    Status = ReservationStatus.CheckedIn,
                    BookingDate = DateTime.Today
                };

                // Assign a room
                var availableRoom = rooms.Find(r => r.Status == "Available");
                if (availableRoom != null)
                {
                    reservation.Room = availableRoom;
                    availableRoom.Status = "Occupied";
                    reservation.Status = ReservationStatus.CheckedIn;
                    reservations.Add(reservation);
                    guest.StayHistory.Add(reservation);
                    MessageBox.Show($"Walk-in guest checked in to Room {availableRoom.RoomNumber}");
                }
                else
                {
                    MessageBox.Show("No available rooms at the moment.");
                }
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            // Show check-in form
            ShowCheckInForm();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            // Show check-out form
            ShowCheckOutForm();
        }

        private void btnModifyReservation_Click(object sender, EventArgs e)
        {
            ShowModifyReservationForm();
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            ShowCancelReservationForm();
        }

        private void btnRoomMove_Click(object sender, EventArgs e)
        {
            ShowRoomMoveForm();
        }

        private void btnExtendStay_Click(object sender, EventArgs e)
        {
            ShowExtendStayForm();
        }

        // Calendar/Reservation Chart
        private void InitializeCalendar()
        {
            // Initialize the calendar control
            // This will show room availability for the next 30 days
        }

        private void UpdateCalendar()
        {
            // Update the calendar with current room availability
            // Show which rooms are available on which dates
        }

        private void ShowReservationForm()
        {
            var reservationForm = new ReservationForm(rooms, reservations);
            if (reservationForm.ShowDialog() == DialogResult.OK)
            {
                var reservation = reservationForm.Reservation;
                reservations.Add(reservation);
                reservation.Room.Status = "Booked";
                reservation.Guest.StayHistory.Add(reservation);
                LoadDashboardStats();
                UpdateCalendar();
            }
        }

        private void ShowCheckInForm()
        {
            var checkInForm = new CheckInForm(reservations, rooms);
            if (checkInForm.ShowDialog() == DialogResult.OK)
            {
                var reservation = checkInForm.SelectedReservation;
                reservation.Status = ReservationStatus.CheckedIn;
                reservation.Room.Status = "Occupied";
                LoadDashboardStats();
                UpdateCalendar();
            }
        }

        private void ShowCheckOutForm()
        {
            var checkOutForm = new CheckOutForm(reservations, rooms);
            if (checkOutForm.ShowDialog() == DialogResult.OK)
            {
                var reservation = checkOutForm.SelectedReservation;
                reservation.Status = ReservationStatus.CheckedOut;
                reservation.Room.Status = "Available";
                LoadDashboardStats();
                UpdateCalendar();
            }
        }

        private void ShowModifyReservationForm()
        {
            var modifyForm = new ModifyReservationForm(reservations, rooms);
            if (modifyForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh data
                LoadDashboardStats();
                UpdateCalendar();
            }
        }

        private void ShowCancelReservationForm()
        {
            var cancelForm = new CancelReservationForm(reservations);
            if (cancelForm.ShowDialog() == DialogResult.OK)
            {
                var reservation = cancelForm.SelectedReservation;
                reservation.Status = ReservationStatus.Cancelled;
                reservation.Room.Status = "Available";
                LoadDashboardStats();
                UpdateCalendar();
            }
        }

        private void ShowRoomMoveForm()
        {
            var moveForm = new RoomMoveForm(reservations, rooms);
            if (moveForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh data
                LoadDashboardStats();
                UpdateCalendar();
            }
        }

        private void ShowExtendStayForm()
        {
            var extendForm = new ExtendStayForm(reservations, rooms);
            if (extendForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh data
                LoadDashboardStats();
                UpdateCalendar();
            }
        }

        // No-show handling
        private void HandleNoShows()
        {
            var noShows = reservations.Where(r => r.CheckInDate.Date == DateTime.Today && r.Status == ReservationStatus.Confirmed).ToList();
            foreach (var reservation in noShows)
            {
                reservation.Status = ReservationStatus.NoShow;
                reservation.Room.Status = "Available";
                // Apply cancellation fee
                MessageBox.Show($"No-show detected for Reservation {reservation.ReservationID}. Cancellation fee of ${reservation.Rate * 0.5:F2} has been applied.");
            }
            LoadDashboardStats();
            UpdateCalendar();
        }

        private string GenerateReservationID()
        {
            return "RES" + DateTime.Now.Ticks.ToString().Substring(0, 8);
        }

        // Events
        private void HotelManagement_Load(object sender, EventArgs e)
        {
            // Initialize controls and calendar
            HandleNoShows(); // Check for no-shows
            InitializeCalendar();
            UpdateCalendar();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
        }
    }
}