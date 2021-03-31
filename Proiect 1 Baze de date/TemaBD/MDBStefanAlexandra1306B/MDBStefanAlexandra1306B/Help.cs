using System;
using System.Windows.Forms;

namespace MDBStefanAlexandra1306B
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RSCDatabase go = new RSCDatabase();
            go.ShowDialog();
            this.Close();
        }

        private void text_Click(object sender, EventArgs e)
        {

        }
    }
}
