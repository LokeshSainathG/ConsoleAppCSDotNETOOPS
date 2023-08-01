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
        delegate void SetTextCallbackDelegate(string text);
        public DispatcherDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(SetText));//If you are making Threads, in Thread constructor we need to pass "ThreadStart" delegate.
            t.Start();
        }
        private void SetText()
        {
            //textBox1.Text = "This is set via Button";
            this.SetTextCallback("This is set via Button in a Thread safe way.");
        }
        //We created a Thread and calling method which set Text onto TextBox through the Event.
        private void SetTextCallback(string text)
        {
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallbackDelegate t = new SetTextCallbackDelegate(SetTextCallback);
                this.Invoke(t, new object[] { text });//2nd overload
            }
            else
                this.textBox1.Text = text;//If Invoke not required, set text to textBox1 directly.
        }//We have a imp propert for delegates "InvokeRequired", this will check whether you need to invoke this method with UI Thread.
    }
}
