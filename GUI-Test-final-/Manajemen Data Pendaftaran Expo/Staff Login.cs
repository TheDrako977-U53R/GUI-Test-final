using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manajemen_Data_Pendaftaran_Expo
{
    public partial class Staff_Login : Form
    {
        public static string Username { get; set; } = "Staff-San"; // Default username
        public static string Password { get; set; } = "covercorp"; // Default password

        public Staff_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Username && textBox2.Text == Password)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                // Open the Staff Menu form after successful login
                Staff_Menu staffMenu = new Staff_Menu();
                staffMenu.ShowDialog(); // Show the Staff Menu form as a dialog
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the login form without doing anything
            this.Close();
        }
    }
}
