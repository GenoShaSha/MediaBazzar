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
        private EmployeeManagement employees;
        private ShiftManagement shifts;
        Thread th;
        dbEmployees dc;
        MedBazzar mb = new MedBazzar();
        public EmployeeAddingForm(EmployeeManagement e, ShiftManagement s)
        {
            InitializeComponent();
            this.employees = e;
            this.shifts = s;
            GenderCB.SelectedIndex = 0;
            relationshipStatusCB.SelectedIndex = 0;
            RoleCB.SelectedIndex = 0;
            ContractCB.SelectedIndex = 0;
            dc = new dbEmployees();
            List<Employee> employeeList = dc.ReadEmployees();
            foreach (var item in employeeList)
            {
                if (item != null)
                {
                    lbxEmployeeList.Items.Add(item);
                }
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                List<Employee> p = new List<Employee>();
                if(DOBPicker.Value >= DateTime.Now.AddYears(-18))
                {
                    throw new BirthDateException(DOBPicker.Value);
                }
                if (RoleCB.SelectedIndex == 0)
                {
                    this.mb.AddNewEmp(0, firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text);
                }
                else if (RoleCB.SelectedIndex == 1)
                {
                    this.mb.AddNewEmp(1, firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text);
                }
                else if (RoleCB.SelectedIndex == 2)
                {
                    if (ContractCB.SelectedIndex == 0)
                    {
                        this.mb.AddEmployeeRole(2,firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, "full");
                    }
                    else if (ContractCB.SelectedIndex == 1)
                    {
                        this.mb.AddEmployeeRole(2, firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, "middle");
                    }
                    else
                    {
                        this.mb.AddEmployeeRole(2, firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, "part");
                    }
                }
                else if (RoleCB.SelectedIndex == 3)
                {
                    this.mb.AddNewEmp(3, firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text);
                }
                else if (RoleCB.SelectedIndex == 4)
                {
                    if (ContractCB.SelectedIndex == 0)
                    {
                        this.mb.AddEmployeeRole(4, firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, "full");
                    }
                    else if (ContractCB.SelectedIndex == 1)
                    {
                        this.mb.AddEmployeeRole(4, firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, "middle");
                    }
                    else
                    {
                        this.mb.AddEmployeeRole(4, firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, "part");
                    }
                }
                DialogResult result = MessageBox.Show("User added!");
                if(result == DialogResult.OK)
                {
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
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Missing reference : {ex.Message}");
            }
            catch (BirthDateException ex)
            {
                MessageBox.Show(ex.Message);
            }

           
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
                dc = new dbEmployees();
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
