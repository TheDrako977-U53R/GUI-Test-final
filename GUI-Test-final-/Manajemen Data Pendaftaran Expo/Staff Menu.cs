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
    public partial class Staff_Menu : Form
    {
        public Staff_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Prompt the user to input a 5-digit token
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the 5-digit token of the participant to delete:",
                "Delete Participant",
                "");

            // Validate the input
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Token input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(input, out int token) || input.Length != 5)
            {
                MessageBox.Show("Please enter a valid 5-digit numeric token.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm deletion
            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete the participant with Token {token}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                // Remove from in-memory list if present
                var participantToRemove = ParticipantRepository.ParticipantsList
                    .FirstOrDefault(p => p.Token == token);
                if (participantToRemove != null)
                {
                    ParticipantRepository.ParticipantsList.Remove(participantToRemove);
                }

                // Remove from PostgreSQL
                ParticipantRepository.DeleteParticipantFromPostgres(
                    token,
                    "Host=localhost;Port=5432;Username=postgres;Password=digitalk3y;Database=HoloParticipants"
                );

                MessageBox.Show($"Participant with Token {token} has been removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://hololivepro.com";

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open the website. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Fetch participants from PostgreSQL
            var participants = ParticipantRepository.GetParticipantsFromPostgres(
                "Host=localhost;Port=5432;Username=postgres;Password=digitalk3y;Database=HoloParticipants");

            // Check if the Participant form is already open
            var participantForm = Application.OpenForms.OfType<Participant>().FirstOrDefault();

            if (participantForm == null || participantForm.IsDisposed)
            {
                participantForm = new Participant();
            }

            // Load the participants into the form
            participantForm.LoadParticipants(participants);

            if (participantForm.Visible)
            {
                participantForm.BringToFront();
            }
            else
            {
                participantForm.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Prompt for a new username
            string newUsername = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the new username:",
                "Update Username",
                Staff_Login.Username);

            // Validate the username input
            if (string.IsNullOrWhiteSpace(newUsername))
            {
                MessageBox.Show("Username cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prompt for a new password
            string newPassword = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the new password:",
                "Update Password",
                Staff_Login.Password);

            // Validate the password input
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the username and password in Staff_Login
            Staff_Login.Username = newUsername;
            Staff_Login.Password = newPassword;

            // Confirm the update
            MessageBox.Show("Username and password have been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Define the Discord invitation link for the specific group
            string discordInviteUrl = "https://discord.gg/MsB8vsu7"; // Replace with your actual Discord invite link

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = discordInviteUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open the Discord invitation link. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
