using System;
using System.Collections;
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
    public partial class Form7 : Form
    {
        List<int> uniqueNumbers = new List<int>();
        List<string> dept = new List<string>() {"human resource", "finance", "marketing", "sales", "research"};

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validation For ID
            if (txtNumber.Text == "")
            {
                MessageBox.Show("Enter your ID", "Id Field");
            }
            else
            {
                var id = int.Parse(txtNumber.Text);
                if (uniqueNumbers.Count == 0)
                    uniqueNumbers.Add(id);
                else
                {
                    if (uniqueNumbers.Count > 0)
                    {
                        foreach (var uniqueNumber in uniqueNumbers)
                        {
                            if (uniqueNumber == id)
                            {
                                MessageBox.Show("ID Taken", "ID Field");
                            }
                        }
                    }
                    else
                    {
                        uniqueNumbers.Add(id);
                    }
                }
            }
            txtNumber.Clear();

            // Validation for Name
            if ((string.IsNullOrEmpty(txtName.Text)) || (string.IsNullOrWhiteSpace(txtName.Text)))
            {
                MessageBox.Show("Enter your Name", "Name Field");
            }
            txtName.Clear();

            // Validation for Date of Joining
            if ((string.IsNullOrEmpty(txtDOB.Text)) || (string.IsNullOrWhiteSpace(txtDOB.Text)))
            {
                MessageBox.Show("Enter your Date of Joining", "DOB Field");
            }
            else
            {
                var userDate = DateTime.Parse(txtDOB.Text);
                var todayDate = DateTime.Today;

                if (userDate >= todayDate)
                {
                    MessageBox.Show("Enter the correct Date of joining", "DOB Field");
                }
            }
            txtDOB.Clear();

            // Validation for Department
            if ((string.IsNullOrEmpty(txtDepartment.Text)) || (string.IsNullOrWhiteSpace(txtDepartment.Text)))
            {
                MessageBox.Show("Enter your Department", "Department Field");
            }
            else
            {
                var Status = false;
                var userDept = txtDepartment.Text.ToLower();
                foreach (var d in dept)
                {
                    if (userDept != d)
                    {
                        Status = true;
                    }
                }

                if (Status)
                {
                    MessageBox.Show("Enter the correct Department", "Department Field");
                }
            }
            txtDepartment.Clear();

            // Validation for Salary
            if ((string.IsNullOrEmpty(txtSalary.Text)) || (string.IsNullOrWhiteSpace(txtSalary.Text)))
            {
                MessageBox.Show("Enter your Salary", "Salary Field");
            }
            else
            {
                var userSalary = long.Parse(txtSalary.Text);
                if (!((userSalary >= 100000) && (userSalary <= 50000000)))
                {
                    MessageBox.Show("Enter your correct salary", "Salary Field");
                }
            }
            txtSalary.Clear();
        }
    }
}