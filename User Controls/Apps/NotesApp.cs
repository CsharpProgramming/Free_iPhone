using System;
using System.Linq;
using System.Windows.Forms;
using IphoneSimulator.Properties;

namespace IphoneSimulator.User_Controls.Apps
{
    public partial class NotesApp : UserControl
    {
        public NotesApp()
        {
            InitializeComponent();
        }

        private void TittleBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.NoteTittle = TittleBox.Text;
            Settings.Default.Save();

            Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            form1Instance.BlackoutScreenManager(true);
        }

        private void NoteBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.NoteText = NoteBox.Text;
            Settings.Default.Save();

            Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            form1Instance.BlackoutScreenManager(true);
        }

        private void NotesApp_Load(object sender, EventArgs e)
        {
            if (Settings.Default.NoteTittle != "")
            {
                TittleBox.Text = Settings.Default.NoteTittle;
            }

            if (Settings.Default.NoteText != "")
            {
                NoteBox.Text = Settings.Default.NoteText;
            }
        }
    }
}
