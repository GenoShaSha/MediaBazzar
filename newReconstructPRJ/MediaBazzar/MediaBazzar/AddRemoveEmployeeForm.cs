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
    public partial class AddRemoveEmployeeForm : Form
    {
        private Wrappers wrp;
        public AddRemoveEmployeeForm()
        {
            InitializeComponent();
            wrp = new Wrappers();
            UpdateEmployeeManagementListbox();
            RoleCB.SelectedIndex = 0;
            ContractCB.SelectedIndex = 0;
            GenderCB.SelectedIndex = 0;
            relationshipStatusCB.SelectedIndex = 0;
        }
        public void UpdateEmployeeManagementListbox()
        {
            lbxEmployeeList.Items.Clear();
            List<Object> employeeList = wrp.EM.GetListObj();
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
                if (DOBPicker.Value >= DateTime.Now.AddYears(-18))
                {
                    throw new BirthOfDateException(DOBPicker.Value);
                }
                if (RoleCB.SelectedIndex == 0)
                {
                    wrp.EM.AddObj(new Administrator(firstNameTB.Text, lastNameTB.Text, DOBPicker.Value, BSN_TB.Text, GenderCB.SelectedItem.ToString(), relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text));
                }
                else if (RoleCB.SelectedIndex == 1)
                {
                    wrp.EM.AddObj(new FloorManager(firstNameTB.Text, lastNameTB.Text, DOBPicker.Value, BSN_TB.Text, GenderCB.SelectedItem.ToString(), relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text));
                }
                else if (RoleCB.SelectedIndex == 2)
                {
                    if (ContractCB.SelectedIndex == 0)
                    {
                        wrp.EM.AddObj(new FloorStaff(firstNameTB.Text, lastNameTB.Text, DOBPicker.Value, BSN_TB.Text, GenderCB.SelectedItem.ToString(), relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 40, "full"));
                    }
                    else if (ContractCB.SelectedIndex == 1)
                    {
                        wrp.EM.AddObj(new FloorStaff(firstNameTB.Text, lastNameTB.Text, DOBPicker.Value, BSN_TB.Text, GenderCB.SelectedItem.ToString(), relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 30, "middle"));
                    }
                    else
                    {
                        wrp.EM.AddObj(new FloorStaff(firstNameTB.Text, lastNameTB.Text, DOBPicker.Value, BSN_TB.Text, GenderCB.SelectedItem.ToString(), relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 20, "part"));
                    }
                }
                else if (RoleCB.SelectedIndex == 3)
                {
                    wrp.EM.AddObj(new WarehouseManager(firstNameTB.Text, lastNameTB.Text, DOBPicker.Value, BSN_TB.Text, GenderCB.SelectedItem.ToString(), relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text));
                }
                else if (RoleCB.SelectedIndex == 4)
                {
                    if (ContractCB.SelectedIndex == 0)
                    {
                        wrp.EM.AddObj(new WarehouseStaff(firstNameTB.Text, lastNameTB.Text, DOBPicker.Value, BSN_TB.Text, GenderCB.SelectedItem.ToString(), relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 40, "full"));
                    }
                    else if (ContractCB.SelectedIndex == 1)
                    {
                        wrp.EM.AddObj(new WarehouseStaff(firstNameTB.Text, lastNameTB.Text, DOBPicker.Value, BSN_TB.Text, GenderCB.SelectedItem.ToString(), relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 30, "middle"));
                    }
                    else
                    {
                        wrp.EM.AddObj(new WarehouseStaff(firstNameTB.Text, lastNameTB.Text, DOBPicker.Value, BSN_TB.Text, GenderCB.SelectedItem.ToString(), relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 20, "part"));
                    }
                }
                DialogResult result = MessageBox.Show("User added!");
                if (result == DialogResult.OK)
                {
                    firstNameTB.Text = string.Empty;
                    lastNameTB.Text = string.Empty;
                    BSN_TB.Text = string.Empty;
                    emailTB.Text = string.Empty;
                    tbxPswd.Text = string.Empty;
                    phoneNumberTB.Text = string.Empty;
                    addressTB.Text = string.Empty;
                    postalCodeTB.Text = string.Empty;
                    cityTB.Text = string.Empty;
                    countryTB.Text = string.Empty;
                }
                UpdateEmployeeManagementListbox();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Missing reference : {ex.Message}");
            }
            catch (BirthOfDateException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            UpdateEmployeeForm uf = new UpdateEmployeeForm();
            this.Hide();
            uf.Show();
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            wrp.EM.FiredEmployee(Convert.ToInt32(tbxRmv.Text));
            UpdateEmployeeManagementListbox();
            MessageBox.Show("Employee has been retire or fired!");
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
            else if (RoleCB.SelectedIndex == 3)
            {
                ContractCB.Enabled = false;
            }
            else
            {
                ContractCB.Enabled = true;
            }
        }
    }
}
