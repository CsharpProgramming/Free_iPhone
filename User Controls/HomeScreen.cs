using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IphoneSimulator.User_Controls
{
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            pictureBox1.Parent = HomeScreenBG;
            pictureBox1.BackColor = Color.Transparent;

            pictureBox2.Parent = HomeScreenBG;
            pictureBox2.BackColor = Color.Transparent;

            label1.Parent = HomeScreenBG;
            label1.BackColor = Color.Transparent;

            label2.Parent = HomeScreenBG;
            label2.BackColor = Color.Transparent;

            label3.Parent = HomeScreenBG;
            label3.BackColor = Color.Transparent;

            label4.Parent = HomeScreenBG;
            label4.BackColor = Color.Transparent;

            label5.Parent = HomeScreenBG;
            label5.BackColor = Color.Transparent;

            pictureBox3.Parent = HomeScreenBG;
            pictureBox3.BackColor = Color.Transparent;

            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            form1Instance.ShowAppOpened(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            form1Instance.ShowAppOpened(2);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            form1Instance.ShowAppOpened(3);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            form1Instance.ShowAppOpened(4);
        }
    }
}
