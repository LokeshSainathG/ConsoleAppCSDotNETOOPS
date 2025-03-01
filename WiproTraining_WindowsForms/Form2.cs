using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiproTraining_WindowsForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var number = int.Parse(txtDisplay.Text);
            if (number % 2 == 0)
                MessageBox.Show($"Even: {number}", "Odd or  Even");
            else
                MessageBox.Show($"Odd: {number}", "Odd or Even");
        }
    }
}
