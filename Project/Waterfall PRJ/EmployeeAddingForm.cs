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
        public EmployeeAddingForm(EmployeeManager e, ShiftManager s)
        {
            InitializeComponent();
            this.employees = e;
            this.shifts = s;
            GenderCB.SelectedIndex = 0;
            relationshipStatusCB.SelectedIndex = 0;
            RoleCB.SelectedIndex = 0;
            ContractCB.SelectedIndex = 0;
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (RoleCB.SelectedIndex == 0)
                {
                    this.employees.AddPerson(new Administrator(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text));
                }
                else if (RoleCB.SelectedIndex == 1)
                {
                    this.employees.AddPerson(new FloorManagerRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text));
                }
                else if (RoleCB.SelectedIndex == 2)
                {
                    if (ContractCB.SelectedIndex == 0)
                    {
                        this.employees.AddPerson(new EmployeeRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 40, "full"));
                    }
                    else if (ContractCB.SelectedIndex == 1)
                    {
                        this.employees.AddPerson(new EmployeeRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 30, "middle"));
                    }
                    else
                    {
                        this.employees.AddPerson(new EmployeeRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 20, "part"));
                    }
                }
                MessageBox.Show("User added!");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Missing reference : {ex.ToString()}");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userType = cbUserType.SelectedItem.ToString();

            if (username == string.Empty)
            {
                MessageBox.Show("Please input Username!");
            }
            else if (password == string.Empty)
            {
                MessageBox.Show("Please input Password!");
            }
            else
            {
                Login login = new Login(username, password, userType);

                bool addUser = login.AddUsers();

                if (addUser == true)
                {
                    MessageBox.Show("Success Add");
                }
                else
                {
                    MessageBox.Show("Fail to Add");
                }
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                cbUserType.SelectedIndex = 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cbUserType.SelectedIndex = 0;
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            string newUsr = tbxRmv.Text;
            string usrType = cbxUsers.SelectedItem.ToString();

            if (newUsr == string.Empty)
            {
                MessageBox.Show("Please input Username!");
            }
            else
            {
                Login login = new Login(newUsr, string.Empty, usrType);
                bool rmvUsers = login.RemoveUsers();
                if (rmvUsers == true)
                {
                    MessageBox.Show("The user has been removed!");
                }
                else
                {
                    MessageBox.Show("Nothing happened!");
                }
                tbxRmv.Text = string.Empty;
                cbxUsers.SelectedIndex = 0;
            }
        }
    }
}
