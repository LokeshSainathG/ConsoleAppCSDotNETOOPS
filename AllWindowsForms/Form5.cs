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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            BindDropDown(); 
            Count();
            //When Form is loaing these 2 methods gets invoke. All items added into ComboBox (Dropdown), Count shows no.of items in ListBox not Dropdown.
        }
        private void BindDropDown()//To add some Items into ComboBox (Dropdown)
        {
            cmbItems.Items.Add("Monitor");
            cmbItems.Items.Add("Keyboard");
            cmbItems.Items.Add("CPU");
            cmbItems.Items.Add("Mouse");
            cmbItems.Items.Add("Printer");
            cmbItems.Items.Add("Joystick");
            cmbItems.Items.Add("Speakers");
            cmbItems.Items.Add("Headset");
            cmbItems.Items.Add("UPS");
        }
        private void Count()//We can use Count() when something is inserting into ListBox, deleting we invoke. This is the reason we are writing in a method.
        {
            lblCount.Text = "No of Items = "+lstItems.Items.Count;
            /*ComboBox, ListBox - Items Property - Items is a Collection type of Property. 
            Since Items is a collection type, some pre-defined methods available:
            Items.Add() - To add an item
            Items.Remove()- To remove an item
            Items.Count - To count items in the collection Items.
            Items.Clear() - To clear an Item
            */
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox selected item is going to add into ListBox items.
            lstItems.Items.Add(cmbItems.SelectedItem);
            //SelectedItem OR SelectedValue both are ok. It return what item we selected.
            //After adding into ListBox, we want that item to remove from ComboBox. 
            cmbItems.Items.Remove(cmbItems.SelectedItem);
            Count();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtItem.Text))//When textBox has some value then only we have to add.
            {
                lstItems.Items.Add(txtItem.Text);
                txtItem.Text = "";//OR
                txtItem.Clear();
                //After adding into ListBox, we have to clear the TextBox.
                Count(); //Increase no.of Items in ListBox.
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem != null)
            {
                //Before removing only we need to move back that selected item to ComboBox.
                cmbItems.Items.Add(lstItems.SelectedItem);
                //ListBox selected item should remove from it.
                lstItems.Items.Remove(lstItems.SelectedItem);
                //After removing from ListBox, if you try to move selectedItem to Combo, you will get Un-handled Exception, since we removed from ListBox. System.ArgumentNullException: Value cannot be null.
                Count();
            }
        }
    }
}
