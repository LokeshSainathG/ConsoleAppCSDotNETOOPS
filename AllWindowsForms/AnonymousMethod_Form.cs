using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllWindowsForms
{
    public partial class AnonymousMethod_Form : Form
    {
        public AnonymousMethod_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();//New Button 'b'
            b.Text = "Click Me";//Caption
            b.Size = new Size(100, 50);//3rd Overload (width, height)
            b.Location = new Point(200, 200);//X-co-ordinate, Y-co-ordinate of the Form
            this.Controls.Add(b); //this always represents current class.
            //Let's create Click event for the Dynamic button 'b'.
            //b.Click += new EventHandler(b_Click);
            //Re-Writing EventHandler with Anonymous method.

            //b.Click += delegate (object sender1, EventArgs e1)
            //b.Click += delegate //Parameters are optional, if you are not using them
            //{
            //    MessageBox.Show("Hello");
            //};

            //Re-writing above Anonymous method into Lambda Expression:
            //b.Click += (object sender1, EventArgs e1) =>
            b.Click += (sender1, e1) =>
            {
                MessageBox.Show("Hello");
            };
        }
        //private void b_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Hello");
        //}

        //Why we need to pass 2 parameters: (object sender, EventArgs e)
        //Every EventHandler method, take these 2 parameters.
        //Since we are not using these 2 parameters in the body, we can remove these. If in case, you are using these 2, we should pass the 2 params.
    }
}