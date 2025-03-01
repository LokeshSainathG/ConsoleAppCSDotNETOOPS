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
    public partial class Assignment2 : Form
    {
        public Assignment2()
        {
            InitializeComponent();
        }

        private void Assignment2_Load(object sender, EventArgs e)
        {
            BindDropDown1();
            BindDropDown2();
            BindDropDown3();
            BindDropDown4();
        }
        /// <summary>
        /// Binding Items data into the DropDowns:
        /// </summary>
        private void BindDropDown1()
        {
            cmbFont.Items.Add("Algerian");
            cmbFont.Items.Add("Arial");
            cmbFont.Items.Add("Calibri");
            cmbFont.Items.Add("Consolas");
            cmbFont.Items.Add("HP Simplified");
            cmbFont.Items.Add("MS Outlook");
        }
        private void BindDropDown2()
        {
            cmbFontSize.Items.Add("10");
            cmbFontSize.Items.Add("11");
            cmbFontSize.Items.Add("12");
            cmbFontSize.Items.Add("13");
            cmbFontSize.Items.Add("14");
            cmbFontSize.Items.Add("15");
            cmbFontSize.Items.Add("16");
        }
        private void BindDropDown3()
        {
            cmbFontColor.Items.Add("Black");
            cmbFontColor.Items.Add("SlateBlue");
            cmbFontColor.Items.Add("Brown");
            cmbFontColor.Items.Add("Chocolate");
            cmbFontColor.Items.Add("Cyan");
            cmbFontColor.Items.Add("Gold");
            cmbFontColor.Items.Add("Gray");
            cmbFontColor.Items.Add("Lavender");
            cmbFontColor.Items.Add("SlateBlue");
            cmbFontColor.Items.Add("Violet");
        }
        private void BindDropDown4()
        {
            cmbBackColor.Items.Add("Black");
            cmbBackColor.Items.Add("SlateBlue");
            cmbBackColor.Items.Add("Brown");
            cmbBackColor.Items.Add("Chocolate");
            cmbBackColor.Items.Add("Cyan");
            cmbBackColor.Items.Add("Gold");
            cmbBackColor.Items.Add("Gray");
            cmbBackColor.Items.Add("Lavender");
            cmbBackColor.Items.Add("SlateBlue");
            cmbBackColor.Items.Add("Violet");
        }

        /// <summary>
        /// DropDown Events when an Item is selected:
        /// </summary>
        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox1.Font.Name = "Arial";
            //textBox1.Font = new Font((string)cmbFont.SelectedItem, 12.0f);//Hardcoding size
            //We have to add Font size also.
            textBox1.Font = new Font((string)cmbFont.SelectedItem, textBox1.Font.Size);//No need of Hardcoding size, whatever there same as is.
        }

        private void cmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, (float)Convert.ToDouble(cmbFontSize.SelectedItem));
        }

        private void cmbFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox1.ForeColor = Color.Black;//Straight Forward.

            string color = (string)cmbFontColor.SelectedItem;
            //textBox1.ForeColor = Color.
        }

        private void cmbBackColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox1.BackColor = Color.
        }

        /// <summary>
        /// RadioButton Events:
        /// </summary>
        private void rabBold_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            //Bold opposite is Regular: To convert back use:
            //textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
        }

        private void rabItalic_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
        }

        private void rabUnderline_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
        }
    }
}
