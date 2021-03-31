using System;
using System.Windows.Forms;

namespace MDBStefanAlexandra1306B
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Data_Load(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RSCDatabase go = new RSCDatabase();
            go.ShowDialog();
            this.Close();
        }

        private void specialistsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSpecialists go = new DSpecialists();
            go.ShowDialog();
            this.Close();
        }

        private void pacientsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DPacients go = new DPacients();
            go.ShowDialog();
            this.Close();
        }

        private void assistantsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DAssistants go = new DAssistants();
            go.ShowDialog();
            this.Close();
        }

        private void medicationsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DMedications go = new DMedications();
            go.ShowDialog();
            this.Close();
        }
    }
}
