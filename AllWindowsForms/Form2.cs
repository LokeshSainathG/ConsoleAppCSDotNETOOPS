using System;
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
                if (txtFirst.Text == String.Empty || txtSecond.Text == "")
                    throw new InputEmptyException();

                //int a = Convert.ToInt32(txtFirst.Text);
                //int b = Convert.ToInt32(txtSecond.Text);
                //int c = a + b;
                //txtResult.Text = Convert.ToString(c);
                //Text box format the data in the form of String

                //Above can be simplified as: We saved Memory also.
                txtResult.Text = (Convert.ToInt32(txtFirst.Text)+ Convert.ToInt32(txtSecond.Text)).ToString();

                //So, always make a habit to reduce the no.of lines of code. Though you have written in lengthy manner after writing the logic, reduce it wherever req. Try to use less no of var's.
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
                if (txtFirst.Text == String.Empty || txtSecond.Text == String.Empty)
                    throw new InputEmptyException();
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
                if (txtFirst.Text == String.Empty || txtSecond.Text == String.Empty)
                    throw new InputEmptyException();
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
                if (txtFirst.Text == String.Empty || txtSecond.Text == String.Empty)
                    throw new InputEmptyException();
                txtResult.Text = (Convert.ToInt32(txtFirst.Text) /Convert.ToInt32(txtSecond.Text)).ToString();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {

        }
    }
    /// <summary>
    /// User-defined Exception:
    /// </summary>
    class InputEmptyException : Exception
    {
        public override string Message
        {
            get
            {
                return "Please enter First no, Second no";
            }
        }
    }
}