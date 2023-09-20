using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IphoneSimulator.User_Controls.Apps;

namespace IphoneSimulator.User_Controls
{
    public partial class AppOpened : UserControl
    {
        public AppOpened()
        {
            InitializeComponent();
        }

        public void OpenApp(int AppID)
        {
            if (AppID == 1)
            {
                ShowNotesApp();
            }

            if (AppID == 2)
            {
                ShowSafariApp();
            }

            if (AppID == 3)
            {
                ShowSettingsApp();
            }

            if (AppID == 4)
            {
                ShowAppStoreApp();
            }
        }

        private void ShowNotesApp()
        {
            NotesApp NA = new NotesApp();
            NA.Dock = DockStyle.Fill;
            PanelAppContainer.Controls.Clear();
            PanelAppContainer.Controls.Add(NA);
        }

        private void ShowSafariApp()
        {
            SafariApp SA = new SafariApp();
            SA.Dock = DockStyle.Fill;
            PanelAppContainer.Controls.Clear();
            PanelAppContainer.Controls.Add(SA);
        }

        private void ShowSettingsApp()
        {
            SettingsApp SSA = new SettingsApp();
            SSA.Dock = DockStyle.Fill;
            PanelAppContainer.Controls.Clear();
            PanelAppContainer.Controls.Add(SSA);
        }

        private void ShowAppStoreApp()
        {
            AppStoreApp ASA = new AppStoreApp();
            ASA.Dock = DockStyle.Fill;
            PanelAppContainer.Controls.Clear();
            PanelAppContainer.Controls.Add(ASA);
        }

        private void AppOpened_Load(object sender, EventArgs e)
        {
            label2.Parent = HomeScreenBG;
            label2.BackColor = Color.Transparent;

            pictureBox2.Parent = HomeScreenBG;
            pictureBox2.BackColor = Color.Transparent;

            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm");
        }

        private void AppOpened_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}
