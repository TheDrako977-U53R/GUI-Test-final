namespace Manajemen_Data_Pendaftaran_Expo
{
    public partial class Form1 : Form
    {
        private Participant _participantForm;

        public Form1()
        {
            InitializeComponent();
            _participantForm = new Participant(); // Create a single instance
        }

        private void registration_Click(object sender, EventArgs e)
        {
            FormPendaftaran formPendaftaran = new FormPendaftaran(_participantForm);
            formPendaftaran.ShowDialog();
        }

        private void schedule_Click(object sender, EventArgs e)
        {
            string url = "https://https://www.youtube.com/@hololiveEnglish";

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

        private void PrivilegedAccess_Click_1(object sender, EventArgs e)
        {
            Staff_Login staffLogin = new Staff_Login();
            staffLogin.ShowDialog();
        }

        private void Merchandise_Click(object sender, EventArgs e)
        {
            string url = "https://shop.hololivepro.com";

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
    }
}
