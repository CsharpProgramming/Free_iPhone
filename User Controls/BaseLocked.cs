using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IphoneSimulator.User_Controls
{
    public partial class BaseLocked : UserControl
    {
        int ScreenTimeLock = 0;

        public BaseLocked()
        {
            InitializeComponent();
        }

        private void BaseLocked_Load(object sender, EventArgs e)
        {
            label1.Parent = HomeScreenBG;
            label1.BackColor = Color.Transparent;

            label2.Parent = HomeScreenBG;
            label2.BackColor = Color.Transparent;

            pictureBox2.Parent = HomeScreenBG;
            pictureBox2.BackColor = Color.Transparent;

            pictureBox3.Parent = HomeScreenBG;
            pictureBox3.BackColor = Color.Transparent;

            pictureBox4.Parent = HomeScreenBG;
            pictureBox4.BackColor = Color.Transparent;

            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            pictureBox4.Visible = true;

            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm");
            label2.Text = DateTime.Now.DayOfWeek + ", " + DateTime.Now.Day + " " + DateTime.Now.ToString("MMMM");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ScreenTimeLock == 10)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                pictureBox4.Visible = true;
                ScreenTimeLock = 0;
            }
            
            ScreenTimeLock += 1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timer2.Start();
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            form1Instance.ShowHomePage();
        }
    }
}
