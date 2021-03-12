using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterfall_PRJ
{
    public partial class ManagementForm : Form
    {
        EmployeeManager employees;
        public ManagementForm()
        {
            InitializeComponent();
            employees = new EmployeeManager();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                employees.AddPerson(new Administrator(textBox1.Text, textBox2.Text, comboBox3.SelectedItem.ToString(), dateTimePicker1.Value, textBox4.Text, comboBox2.SelectedItem.ToString(), textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text));
            }
            catch
            {
                MessageBox.Show("Missing information");
            }

            listBox1.Items.Clear();

            foreach (Person p in employees.GetPersons())
            {
                listBox1.Items.Add(p);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Person p = (Person)listBox1.SelectedItem;
            EmployeeInfoForm info_form = new EmployeeInfoForm(p);
            info_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = (Person)listBox1.SelectedItem;
            listBox1.Items.Remove(p);
            p = new Administrator(textBox1.Text, textBox2.Text, comboBox3.SelectedItem.ToString(), dateTimePicker1.Value, textBox4.Text, comboBox2.SelectedItem.ToString(), textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
            listBox1.Items.Add(p);
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            Person p = (Person)listBox1.SelectedItem;
            listBox1.Items.Remove(p);
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Person p = (Person)listBox1.SelectedItem;
            //JRUT
            //Still need to make it so that the textboxes get filled if you click on an employee.
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {

        }
    }
}
