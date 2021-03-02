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
    public partial class Form2 : Form
    {
        EmployeeManager employees;
        public Form2()
        {
            InitializeComponent();
            employees = new EmployeeManager();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employees.AddPerson(new Administrator(textBox1.Text, textBox2.Text, comboBox3.SelectedItem.ToString(), dateTimePicker1.Value, textBox4.Text, comboBox2.SelectedItem.ToString(), textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text));
            foreach(Person p in employees.GetPersons())
            {
                listBox1.Items.Add(p);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Person p = (Person)listBox1.SelectedItem;
            Form4 info_form = new Form4(p);
            info_form.Show();
        }
    }
}
