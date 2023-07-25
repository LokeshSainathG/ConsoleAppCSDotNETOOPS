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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int sum = 0;

            if (chkMonitor.Checked == true)//Checked is bool property
                sum = sum + 7000;
            if (chkPrinter.Checked)
                sum=sum +5000;
            if (chkSpeakers.Checked)
                sum = sum + 4000;
            if (chkHeadSet.Checked) 
                sum = sum + 3500;

            if (rabFull.Checked)
                MessageBox.Show($"Your Bill Amount is {sum}.\nAfter discount (5%) your Final Bill is {sum - (sum*5)/ 100}.", "Final Bill");//Show("MsgBoxtext", "Caption") OK is by default.
            //MessageBox.Show() is a static overloaded method. Total 21 variants.
            //You can have buttons (Pre-defined). Also can code what if OK is clicked and code for Cancel button.
            else if (rabInstallments.Checked)
                MessageBox.Show($"Your Bill Amount is {sum}.\nYou have to pay this in 5 installments.\nYour Installment Amount is{sum/5}.", "Final Bill");
        }
    }
}
