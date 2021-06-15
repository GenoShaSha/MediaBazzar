using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazzar
{
    public partial class UpdateEmployeeForm : Form
    {
        private Wrappers wrp;

        public UpdateEmployeeForm()
        {
            InitializeComponent();
            wrp = new Wrappers();
            UpdateEmployeeManagementListbox();
        }

        public void UpdateEmployeeManagementListbox()
        {
            employeesLB.Items.Clear();
            List<Object> employeeList = wrp.EM.GetListObj();
            foreach (var item in employeeList)
            {
                if (item != null)
                {
                    employeesLB.Items.Add(item);
                }
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            Employee p = (Employee)employeesLB.SelectedItem;
            try
            {
                if (p.DateOfBirth > DateTime.Now.AddYears(-18))
                {
                    throw new BirthOfDateException();
                }
                wrp.EM.UpdateEmployee(p, firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text
                    , phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text);
                MessageBox.Show($"User ID information updated!");
                UpdateEmployeeManagementListbox();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Failed update an employee.");
            }
            catch (BirthOfDateException)
            {

            }
        }
        private void employeesLB_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Employee p = (Employee)employeesLB.SelectedItem;
                firstNameTB.Text = p.FirstName;
                lastNameTB.Text = p.LastName;
                GenderCB.SelectedItem = p.Gender;
                DOBPicker.Value = p.DateOfBirth;
                BSN_TB.Text = p.BSN;
                relationshipStatusCB.SelectedItem = p.Relationship;
                emailTB.Text = p.Email;
                tbxPswd.Text = p.Password;
                phoneNumberTB.Text = p.PhoneNumber;
                addressTB.Text = p.Address;
                postalCodeTB.Text = p.PostalCode;
                cityTB.Text = p.City;
                countryTB.Text = p.Country;
                if (p.GetType().ToString() == "Waterfall_PRJ.Administrator")
                {
                    RoleCB.SelectedIndex = 0;
                }
                else if (p.GetType().ToString() == "Waterfall_PRJ.FloorManagerRole")
                {
                    RoleCB.SelectedIndex = 1;
                }
                else if (p.GetType().ToString() == "Waterfall_PRJ.EmployeeRole")
                {
                    RoleCB.SelectedIndex = 2;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a user.");
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            AddRemoveEmployeeForm af = new AddRemoveEmployeeForm();
            this.Hide();
            af.Show();
        }
    }
}
