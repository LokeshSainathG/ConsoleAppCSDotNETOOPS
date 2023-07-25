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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Let's Empty all Text boxes when Reset button clicked.
            txtFirst.Text = "";
            txtSecond.Text = "";
            txtResult.Text = "";
            lblError.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //It is imp to put code in try-catch blocks.
            try 
            {
                //int a = Convert.ToInt32(txtFirst.Text);
                //int b = Convert.ToInt32(txtSecond.Text);
                //int c = a + b;
                //txtResult.Text = Convert.ToString(c);
                //Text box format the data in the form of String
                txtResult.Text = (Convert.ToInt32(txtFirst.Text)+ Convert.ToInt32(txtSecond.Text)).ToString();

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                //If you are giving lenghty value/ Format mismatch like String i/p. The label will show the Error msg. 
                //We can define user-defined Exception if First no, Second no are empty & User clicking on Add.
                //Similarly add few more buttons for -,*,/
                //Add custom error msg's by using User-defined Exception.
            }
            //txtResult = txtFirst.Text + txtSecond;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (Convert.ToInt32(txtFirst.Text) - Convert.ToInt32(txtSecond.Text)).ToString();
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (Convert.ToInt32(txtFirst.Text) * Convert.ToInt32(txtSecond.Text)).ToString();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (Convert.ToInt32(txtFirst.Text) /Convert.ToInt32(txtSecond.Text)).ToString();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
