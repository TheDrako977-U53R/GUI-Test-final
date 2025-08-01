﻿using System;
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
    public partial class Participant : Form
    {
        public Participant()
        {
            InitializeComponent();
            dataGridView1.DataSource = ParticipantRepository.ParticipantsList;
            dataGridView1.AllowUserToAddRows = false;
        }

        public void LoadParticipants(List<Participants> participants)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = participants;
        }
    }
}
