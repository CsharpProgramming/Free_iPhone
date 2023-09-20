using System;
using System.Windows.Forms;
using IphoneSimulator.User_Controls;

namespace IphoneSimulator
{
    public partial class Form1 : Form
    {
        int ScreenTimeLock = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowBaseLocked();

            timer1.Start();
        }

        public void ShowBaseLocked()
        {
            BaseLocked BS = new BaseLocked();
            BS.Dock = DockStyle.Fill;
            pictureBox1.Controls.Clear();
            pictureBox1.Controls.Add(BS);
        }

        public void ShowHomePage()
        {
            HomeScreen HS = new HomeScreen();
            HS.Dock = DockStyle.Fill;
            pictureBox1.Controls.Clear();
            pictureBox1.Controls.Add(HS);
        }

        public void ShowAppOpened(int AppID)
        {
            AppOpened AO = new AppOpened();
            AO.Dock = DockStyle.Fill;
            pictureBox1.Controls.Clear();
            pictureBox1.Controls.Add(AO);
            AO.OpenApp(AppID);
        }

        public void BlackoutScreenManager(bool ResetTimer)
        {
            if (ResetTimer)
            {
                ScreenTimeLock = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ScreenTimeLock == 20)
            {
                ShowBaseLocked();
                ScreenTimeLock = 0;
            }

            ScreenTimeLock += 1;
        }
    }
}
