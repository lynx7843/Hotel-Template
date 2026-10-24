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
    public partial class PreferenceForm : Form
    {
        public string PreferenceKey { get; set; }
        public string PreferenceValue { get; set; }

        public PreferenceForm()
        {
            InitializeComponent();
            PreferenceKey = "";
            PreferenceValue = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                MessageBox.Show("Preference key is required.");
                return;
            }

            PreferenceKey = txtKey.Text.Trim();
            PreferenceValue = txtValue.Text.Trim();

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