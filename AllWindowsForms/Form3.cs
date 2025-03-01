using System;
using System.Windows.Forms;

namespace AllWindowsForms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int sum = 0;
            try 
            {
                            if (chkMonitor.Checked == false && chkPrinter.Checked == false && chkSpeakers.Checked == false && chkHeadSet.Checked == false)
                                throw new ChkEmptyException();
                if (chkMonitor.Checked == true)//Checked is bool property
                    sum = sum + 7000;
                if (chkPrinter.Checked)
                    sum=sum +5000;
                if (chkSpeakers.Checked)
                    sum = sum + 4000;
                if (chkHeadSet.Checked) 
                    sum = sum + 3500;

                //Mode of Payment:
                            if (rabFull.Checked == false && rabInstallments.Checked == false)
                                throw new RabEmptyException();
                if (rabFull.Checked)
                    MessageBox.Show($"Your Bill Amount is {sum}." +
                        $"\nAfter discount (5%) your Final Bill is {sum - (sum*5)/ 100}.", "Final Bill");//Use $ for Multi-line text. "Final Bill is caption for msg box."
                //Show("MsgBoxtext", "Caption") OK Button is added by default.
                //MessageBox.Show() is a static method overloading concept. So, object is not required. Total 21 variants are there. 'MessageBox' is class, 'Show()' is a method.
                //In Notepad, when you click on Close on unsaved text --> you get a dialog with Save, Don't Save, Cancel. Like this we have many Buttons.
                //You can have buttons (Pre-defined). Also you can add symbols in Text like warning symbol or Error symbol in MsgBoxText. And you can code what if OK is clicked and code for Cancel button.
                else if (rabInstallments.Checked)
                    MessageBox.Show($"Your Bill Amount is {sum}.\nYou have to pay this in 5 installments." +
                        $"\nYour Installment Amount is{sum/5}.", "Final Bill");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    /// <summary>
    /// User-defined Exception:
    /// </summary>
    class ChkEmptyException : Exception
    {
        public override string Message
        {
            get
            {
                return "Please select Item(s)..";
            }
        }
    }
    class RabEmptyException : Exception
    {
        public override string Message
        {
            get
            {
                return "Please select Mode of Payment..";
            }
        }
    }

}
