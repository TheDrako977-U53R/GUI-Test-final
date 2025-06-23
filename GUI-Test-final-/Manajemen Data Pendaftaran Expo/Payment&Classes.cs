using System;
using Npgsql;
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
    public partial class Payment_Classes : Form
    {
        private readonly Participants _participants;

        public Payment_Classes(Participants participants)
        {
            InitializeComponent();
            _participants = participants;
        }

        private void vipbutton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Are you sure you want the VIP Class?",
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                _participants.Class = "VIP CLASS";
                _participants.Registered = DateOnly.FromDateTime(DateTime.Now);
                _participants.Token = GenerateRandomToken();

                ParticipantRepository.ParticipantsList.Add(_participants);

                // Import to PostgreSQL
                var repo = new Repository();
                repo.SaveParticipantsToDatabase();

                this.Close();
            }
        }

        private void regularbutton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Are you sure you want the REGULAR Class?",
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                _participants.Class = "REGULAR CLASS";
                _participants.Registered = DateOnly.FromDateTime(DateTime.Now);
                _participants.Token = GenerateRandomToken();

                ParticipantRepository.ParticipantsList.Add(_participants);

                // Import to PostgreSQL
                var repo = new Repository();
                repo.SaveParticipantsToDatabase();

                this.Close();
            }
        }

        private int GenerateRandomToken()
        {
            var rnd = new Random();
            return rnd.Next(10000, 100000); // Generate a 5-digit token
        }
    }
}
