using System;
using System.Windows.Forms;

namespace MDBStefanAlexandra1306B
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RSCDatabase go = new RSCDatabase();
            go.ShowDialog();
            this.Close();
        }

        private void generalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SGeneral go = new SGeneral();
            go.ShowDialog();
            this.Close();
        }

        private void consultationsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SConsultations go = new SConsultations();
            go.ShowDialog();
            this.Close();
        }

        private void surgeriesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SSurgeries go = new SSurgeries();
            go.ShowDialog();
            this.Close();
        }

        private void admissionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SAdmissions go = new SAdmissions();
            go.ShowDialog();
            this.Close();
        }
    }
}
