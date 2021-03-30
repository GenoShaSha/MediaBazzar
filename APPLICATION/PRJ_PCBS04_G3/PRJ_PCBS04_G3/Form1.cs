using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PRJ_PCBS04_G3
{
    public partial class Form1 : Form
    {
        private EmployeeManager employees;
        public Form1(EmployeeManager em)
        {
            InitializeComponent();
            this.employees = em;
            GenderCB.SelectedIndex = 0;
            relationshipStatusCB.SelectedIndex = 0;
            RoleCB.SelectedIndex = 0;
            ContractCB.SelectedIndex = 0;
        }

        public void ValidBSN(string bsnNumb)
        {
            if (Regex.IsMatch(BSN_TB.Text, @"[0-9]{10}$"))
            {
                bsnNumb = BSN_TB.Text;
            }
            else
            {
                throw new BSNException(BSN_TB.Text);
            }
        }
        public void ValidPostalCode(string postalCode)
        {
            if(Regex.IsMatch(postalCodeTB.Text, @"[0-9]{4}[A-Z]{2}$"))
            {
                postalCode = postalCodeTB.Text;
            }
            else
            {
                throw new PostalCodeException(postalCodeTB.Text);
            }
        }
        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                ValidBSN(BSN_TB.Text);
                ValidPostalCode(postalCodeTB.Text);
                if (RoleCB.SelectedIndex == 0)
                {
                    this.employees.AddPerson(new AdministratorRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, calDOJ.Value));
                }
                else if (RoleCB.SelectedIndex == 1)
                {
                    this.employees.AddPerson(new FloorManagerRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, calDOJ.Value));
                }
                else if (RoleCB.SelectedIndex == 2)
                {
                    if (ContractCB.SelectedIndex == 0)
                    {
                        this.employees.AddPerson(new EmployeeRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 40, "full", calDOJ.Value));
                    }
                    else if (ContractCB.SelectedIndex == 1)
                    {
                        this.employees.AddPerson(new EmployeeRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 30, "middle", calDOJ.Value));
                    }
                    else
                    {
                        this.employees.AddPerson(new EmployeeRole(firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text, 20, "part", calDOJ.Value));
                    }
                }
                MessageBox.Show("User added!");
                lbxListEmployees.Items.Clear();
                lbxListEmployees.HorizontalScrollbar = true;
                foreach (Person p in employees.GetPersons())
                {
                    lbxListEmployees.Items.Add(p);
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Missing reference : {ex.ToString()}");
            }
            catch(Exception ex)
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
    }
}
