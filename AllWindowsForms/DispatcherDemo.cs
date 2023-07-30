using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllWindowsForms
{
    public partial class DispatcherDemo : Form
    {
        public DispatcherDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(ButtonText));//If you are making Threads, in Thread constructor we need to pass "ThreadStart" delegate.
            t.Start();
        }
        private void ButtonText()
        {
            textBox1.Text = "This is set via Button";
        }
        //We created a Thread and calling method which set Text onto TextBox through the Event.
    }
}
