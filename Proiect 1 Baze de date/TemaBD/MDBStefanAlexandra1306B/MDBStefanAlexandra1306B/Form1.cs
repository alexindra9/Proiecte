using System;
using System.Windows.Forms;

namespace MDBStefanAlexandra1306B
{
    public partial class RSCDatabase : Form
    {
        Timer t = new Timer();

        public RSCDatabase()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            CenterToScreen();
        }

        private void RSCDatabase_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.clock_Click);
            t.Start();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedule go = new Schedule();
            go.ShowDialog();
            this.Close();
        }

        private void dataButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data go = new Data();
            go.ShowDialog();
            this.Close();
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact go = new Contact();
            go.ShowDialog();
            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help go = new Help();
            go.ShowDialog();
            this.Close();
        }

        private void clock_Click(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
                time += "0" + hh;
            else
                time += hh;
            time += ":";

            if (mm < 10)
                time += "0" + mm;
            else
                time += mm;
            time += ":";

            if (ss < 10)
                time += "0" + ss;
            else
                time += ss;

            clock.Text = time;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
