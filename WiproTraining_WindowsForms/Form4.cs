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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //Calculator Problem:
        double total1 = 0;
        double total2 = 0;

        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSeven.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFive.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnThree.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnTwo.Text;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnOne.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFour.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSix.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnZero.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;

            txtDisplay.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            plusButtonClicked = true;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            multiplyButtonClicked = true;
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            minusButtonClicked = true;
            plusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            divideButtonClicked = true;
            minusButtonClicked = false;
            plusButtonClicked = false;
            multiplyButtonClicked = false;
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if(plusButtonClicked == true)
                total2 = total1 + double.Parse(txtDisplay.Text);
            else if(minusButtonClicked == true)
                total2 = total1 - double.Parse(txtDisplay.Text);
            else if(multiplyButtonClicked == true)
                total2 = total1 * double.Parse(txtDisplay.Text);
            else if (divideButtonClicked == true)
                total2 = total1 / double.Parse(txtDisplay.Text);

            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnPoint.Text;
        }
    }
}
