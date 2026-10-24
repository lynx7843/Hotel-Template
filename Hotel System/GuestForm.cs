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
    public partial class GuestForm : Form
    {
        private Guest guest;
        private bool isNewGuest;

        public Guest Guest
        {
            get { return guest; }
        }

        public GuestForm()
        {
            InitializeComponent();
            guest = new Guest();
            isNewGuest = true;
            SetupForm();
        }

        public GuestForm(Guest existingGuest)
        {
            InitializeComponent();
            guest = existingGuest;
            isNewGuest = false;
            SetupForm();
        }

        private void SetupForm()
        {
            txtFirstName.Text = guest.FirstName;
            txtLastName.Text = guest.LastName;
            txtGuestID.Text = guest.GuestID;
            txtPassportID.Text = guest.PassportID;
            txtPhone.Text = guest.Phone;
            txtEmail.Text = guest.Email;

            // Load preferences into listbox
            lstPreferences.Items.Clear();
            foreach (var pref in guest.Preferences)
            {
                lstPreferences.Items.Add($"{pref.Key}: {pref.Value}");
            }

            // Load stay history
            lstStayHistory.Items.Clear();
            foreach (var reservation in guest.StayHistory)
            {
                lstStayHistory.Items.Add($"{reservation.ReservationID} - {reservation.CheckInDate:yyyy-MM-dd} to {reservation.CheckOutDate:yyyy-MM-dd} - {reservation.Room.RoomNumber} ({reservation.Status})");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First name and last name are required.");
                return;
            }

            guest.FirstName = txtFirstName.Text.Trim();
            guest.LastName = txtLastName.Text.Trim();
            guest.GuestID = txtGuestID.Text.Trim();
            guest.PassportID = txtPassportID.Text.Trim();
            guest.Phone = txtPhone.Text.Trim();
            guest.Email = txtEmail.Text.Trim();

            // Update preferences
            guest.Preferences.Clear();
            foreach (string item in lstPreferences.Items)
            {
                if (item.Contains(":"))
                {
                    var parts = item.Split(new[] { ':' }, 2);
                    guest.Preferences[parts[0].Trim()] = parts[1].Trim();
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAddPreference_Click(object sender, EventArgs e)
        {
            var prefForm = new PreferenceForm();
            if (prefForm.ShowDialog() == DialogResult.OK)
            {
                lstPreferences.Items.Add($"{prefForm.PreferenceKey}: {prefForm.PreferenceValue}");
            }
        }

        private void btnEditPreference_Click(object sender, EventArgs e)
        {
            if (lstPreferences.SelectedIndex >= 0)
            {
                string selected = lstPreferences.SelectedItem.ToString();
                var prefForm = new PreferenceForm();
                var parts = selected.Split(new[] { ':' }, 2);
                prefForm.PreferenceKey = parts[0].Trim();
                prefForm.PreferenceValue = parts[1].Trim();

                if (prefForm.ShowDialog() == DialogResult.OK)
                {
                    int index = lstPreferences.SelectedIndex;
                    lstPreferences.Items[index] = $"{prefForm.PreferenceKey}: {prefForm.PreferenceValue}";
                }
            }
            else
            {
                MessageBox.Show("Please select a preference to edit.");
            }
        }

        private void btnRemovePreference_Click(object sender, EventArgs e)
        {
            if (lstPreferences.SelectedIndex >= 0)
            {
                lstPreferences.Items.RemoveAt(lstPreferences.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a preference to remove.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}