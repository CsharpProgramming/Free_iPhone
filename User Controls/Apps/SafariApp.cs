using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IphoneSimulator.User_Controls.Apps
{
    public partial class SafariApp : UserControl
    {
        public SafariApp()
        {
            InitializeComponent();
        }

        private void TittleBox_DoubleClick(object sender, EventArgs e)
        {
            Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            form1Instance.BlackoutScreenManager(true);

            string inputText = TittleBox.Text;

            if (Uri.IsWellFormedUriString(inputText, UriKind.Absolute))
            {
                webBrowser1.Navigate(inputText);
            }

            else
            {
                webBrowser1.Navigate("https://www.google.com/search?q=" + Uri.EscapeDataString(inputText));
            }
        }
    }
}
