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
    public partial class FormPendaftaran : Form
    {
        private Participant _participantForm;

        public FormPendaftaran()
        {
            InitializeComponent();
            _participantForm = new Participant(); // Initialize _participantForm
        }

        public FormPendaftaran(Participant participantForm)
        {
            InitializeComponent();
            _participantForm = participantForm;
        }
    }
}
