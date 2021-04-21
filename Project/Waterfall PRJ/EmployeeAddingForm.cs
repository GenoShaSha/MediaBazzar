using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Waterfall_PRJ
{
    public partial class EmployeeAddingForm : Form
    {
        private EmployeeManager employees;
        private ShiftManager shifts;
        Thread th;
        dbControler dc;
        public EmployeeAddingForm(EmployeeManager e, ShiftManager s)
        {
            InitializeComponent();
            this.employees = e;
            this.shifts = s;
            GenderCB.SelectedIndex = 0;
            relationshipStatusCB.SelectedIndex = 0;
            RoleCB.SelectedIndex = 0;
            ContractCB.SelectedIndex = 0;
            dc = new dbControler();

        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if(DOBPicker.Value >= DateTime.Now.AddYears(-18))
                {
                    throw new BirthDateException(DOBPicker.Value);
                }
                if (RoleCB.SelectedIndex == 0)
                {
                    this.employees.AddPerson(new Administrator(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text,tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text));
                    dc.AddEmployees(new Administrator(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text,tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text));
                }
                else if (RoleCB.SelectedIndex == 1)
                {
                    this.employees.AddPerson(new FloorManagerRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text,tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text));
                    dc.AddEmployees(new FloorManagerRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text,tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text));
                }
                else if (RoleCB.SelectedIndex == 2)
                {
                    if (ContractCB.SelectedIndex == 0)
                    {
                        this.employees.AddPerson(new EmployeeRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text,tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 40, "full"));
                        dc.AddEmployees(new EmployeeRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text,tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 40, "full"));
                    }
                    else if (ContractCB.SelectedIndex == 1)
                    {
                        this.employees.AddPerson(new EmployeeRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text,tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 30, "middle"));
                        dc.AddEmployees(new EmployeeRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text,tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 30, "middle"));

                    }
                    else
                    {
                        this.employees.AddPerson(new EmployeeRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text,tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 20, "part"));
                        dc.AddEmployees(new EmployeeRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text,tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 20, "part"));
                    }
                }
                MessageBox.Show("User added!");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Missing reference : {ex.Message}");
            }
            catch (BirthDateException ex)
            {
                MessageBox.Show(ex.Message);
            }

            firstNameTB.Text = string.Empty;
            lastNameTB.Text = string.Empty;
            BSN_TB.Text = string.Empty;
            emailTB.Text = string.Empty;
            phoneNumberTB.Text = string.Empty;
            addressTB.Text = string.Empty;
            postalCodeTB.Text = string.Empty;
            cityTB.Text = string.Empty;
            countryTB.Text = string.Empty;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewForm(object obj)
        {
            Application.Run(new ManagementForm(employees, shifts));
        }

        private void RoleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoleCB.SelectedIndex == 0)
            {
                ContractCB.Enabled = false;
            }
            else if (RoleCB.SelectedIndex == 1)
            {
                ContractCB.Enabled = false;
            }
            else
            {
                ContractCB.Enabled = true;
            }
        }
        private void btnRmv_Click(object sender, EventArgs e)
        {
            try
            {
                int newUsr = Convert.ToInt32(tbxRmv.Text);
                dc = new dbControler();
                if (dc.RemoveEmployees(newUsr))
                {
                    MessageBox.Show("User has been removed!");
                }
            }
            catch
            {

            }
        }
    }
}
