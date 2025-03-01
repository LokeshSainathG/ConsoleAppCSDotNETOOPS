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
    public partial class Assignment1 : Form
    {
        public Assignment1()
        {
            InitializeComponent();
        }

        private void Assignment1_Load(object sender, EventArgs e)
        {
            BindListOfItems();
            Count1();
            Count2();
        }
        private void BindListOfItems()
        {
            lstItems.Items.Add("Monitor");
            lstItems.Items.Add("Keyboard");
            lstItems.Items.Add("CPU");
            lstItems.Items.Add("Mouse");
            lstItems.Items.Add("Printer");
            lstItems.Items.Add("Joystick");
            lstItems.Items.Add("Speakers");
            lstItems.Items.Add("Headset");
            lstItems.Items.Add("UPS");
        }
        private void Count1()
        {
            slstItemsCount.Text = "No of Items = " + slstItems.Items.Count;
        }
        private void Count2()
        {
            lstItemsCount.Text = "No of Items = " + lstItems.Items.Count;
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            if (lstItems.Items.Count != 0)
            {
                slstItems.Items.Add(lstItems.SelectedItem);
                //What we get here: lstItems.SelectedItem?
                //
                lstItems.Items.Remove(lstItems.SelectedItem);
                Count1();Count2();
            }
            else
                MessageBox.Show("List is empty");
        }
        private void ssbtn_Click(object sender, EventArgs e)
        {
            if (lstItems.Items.Count != 0)
            {
                //slstItems.Items.Add(lstItems.SelectedItems);//O/P: (Collection) not elements. Inside the Selected elements were there.
                
                //slstItems.Items.AddRange(lstItems.Items);

                foreach (var item in lstItems.SelectedItems)
                {
                    slstItems.Items.Add(item);
                }
                //var selectedItems = new List<string> lstItems.SelectedItems;
                //selectedItems.Select(sd => lstItems.Items.IndexOf(sd)).Where(i => i >= 0).ToList().ForEach(i => lstItems.SetSelected(i, true));

                //lstItems.Items.Remove(lstItems.SelectedItems);//Not removing
                for (int x = lstItems.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int var = lstItems.SelectedIndices[x];
                    lstItems.Items.RemoveAt(var);
                }
                Count1();Count2();
                //SelectedItem - SelectedItems//SelectedItem is object, SelectedItems is ObjectCollection
                //SelectedIndex - SelectedIndices
            }
            else
                MessageBox.Show("List is empty");
        }

        private void lbtn_Click(object sender, EventArgs e)
        {
            if (slstItems.Items.Count != 0)
            {
                lstItems.Items.Add(slstItems.SelectedItem);
                slstItems.Items.Remove(slstItems.SelectedItem);
                Count1(); Count2();
            }
            else
                MessageBox.Show("List is empty");
        }

        private void llbtn_Click(object sender, EventArgs e)
        {
            if (slstItems.Items.Count != 0)
            {
                /*
                foreach (var item in slstItems.SelectedItems)
                {
                    lstItems.Items.Add(item);
                }

                for (int x = slstItems.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int var = slstItems.SelectedIndices[x];
                    slstItems.Items.RemoveAt(var);
                }
                */
                //Addiing & Removing can be done as:
                for (int x = slstItems.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int var = slstItems.SelectedIndices[x];
                    lstItems.Items.Add(slstItems.Items[var]);//Adding
                    slstItems.Items.RemoveAt(var);//Removing
                }
                Count1(); Count2();
            }
            else
                MessageBox.Show("List is empty");
        }
    }
}
