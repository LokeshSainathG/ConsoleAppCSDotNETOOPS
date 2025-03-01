using System;
using System.IO;
using System.Windows.Forms;

namespace WiproTraining_WindowsForms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        /// <summary>
        /// PC Drives
        /// </summary>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var drives in Environment.GetLogicalDrives())
            {
                var driveInf = new DriveInfo(drives);
                if (driveInf.IsReady == true)
                {
                    comboBox1.Items.Add(driveInf.Name);
                }
            }
            comboBox1.Text = "Select a Drive";//We can directly add text to the ComboBox, we are adding items when Load Button clicked, so, that time only let's add Text for it.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                var m = comboBox1.SelectedItem;
                //MessageBox.Show("Selected Item: " + m + "\n" + "Selected Index: " + comboBox1.SelectedIndex);
                //var directoryInfo = new DirectoryInfo(m.ToString());
                directories.Items.Clear();
                var dirs = System.IO.Directory.GetDirectories(m.ToString());
                int i;
                for (i = 0; i < dirs.Length; i++)
                {
                    directories.Items.Add(dirs[i]);
                }
                var files = System.IO.Directory.GetFiles(m.ToString());
                for (i = 0; i < files.Length; i++)
                {
                    directories.Items.Add(files[i]);
                }
            }
        }
    }
}
