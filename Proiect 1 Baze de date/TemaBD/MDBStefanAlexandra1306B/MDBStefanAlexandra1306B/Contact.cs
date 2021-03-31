using System;
using System.Windows.Forms;

namespace MDBStefanAlexandra1306B
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Contact_Load(object sender, EventArgs e)
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
