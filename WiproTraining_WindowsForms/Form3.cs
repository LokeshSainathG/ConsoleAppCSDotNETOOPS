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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();

            var num1 = random.Next(15);
            var num2 = random.Next(15);
            var num3 = random.Next(15);

            txtDisplay1.Text = num1.ToString();
            txtDisplay2.Text = num2.ToString();
            txtDisplay3.Text = num3.ToString();

            var total = num1 + num2 + num3;
            if (total > 21)
            {
                MessageBox.Show("You have won the game.", "Result");
                picDisplay.ImageLocation = @"C:\Users\HP\source\repos\ConsoleAppCSDotNETOOPS\WiproTraining_WindowsForms\YouWin.jpg";
                picDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("OOPS better luck next time.", "Result");
                picDisplay.ImageLocation = @"C:\Users\HP\source\repos\ConsoleAppCSDotNETOOPS\WiproTraining_WindowsForms\YouLose.jpg";
                picDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
    }
}
