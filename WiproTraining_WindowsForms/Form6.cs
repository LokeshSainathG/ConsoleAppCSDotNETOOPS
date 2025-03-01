using System;
using System.Windows.Forms;

namespace WiproTraining_WindowsForms
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load Drive Files:
        /// </summary>
        private string driveName = ""; 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox.Items.Clear();
                var dirs = System.IO.Directory.GetDirectories(driveName);
                int i;
                for (i = 0; i < dirs.Length; i++)
                {
                    listBox.Items.Add(dirs[i]);
                }
                var files = System.IO.Directory.GetFiles(driveName);
                for (i = 0; i < files.Length; i++)
                {
                    listBox.Items.Add(files[i]);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            driveName = txtDisplay.Text;
        }
    }
}
