using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotel_System
{
    public partial class Form1 : Form
    {
        private Process touchKeyboard;
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StartTouchKeyboard();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CloseTouchKeyboard();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // static credentials for now, until the database is connected
            if (username == "user" && password == "password")
            {
                CloseTouchKeyboard();
                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Invalid username or password.", "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            textBox1.Clear();
            textBox2.Clear();

            textBox1.Focus();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void StartTouchKeyboard()
        {
            try
            {
                if (touchKeyboard == null || touchKeyboard.HasExited)
                {
                    touchKeyboard = Process.Start(@"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not start keyboard: " + ex.Message);
            }
        }

        private void CloseTouchKeyboard()
        {
            if (touchKeyboard != null && !touchKeyboard.HasExited)
            {
                touchKeyboard.Kill();
                touchKeyboard = null;
            }
        }
    }
}

