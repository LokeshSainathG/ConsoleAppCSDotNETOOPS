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
    public partial class Form1 : Form//Form1 is inheriting from another pre-defined base class called "FORM". Again it is inheriting from ContainerControl class 
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Windows Programming.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome All. Have a nice day");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Hover on  button");
        }
    }
}
