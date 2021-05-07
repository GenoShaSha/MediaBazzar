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
    public partial class EmployeeInformation : Form
    {
        Employee p = null;
        public EmployeeInformation(Employee person)
        {
            InitializeComponent();
            this.p = person;
            InfoFill();
            
        }
        public void InfoFill()
        {
            nameLbl.Text = p.FirstName + " " + p.LastName;
            if (p.GetType().Name == "Administrator")
            {
                roleLbl.Text = "Administrator";
                ContractLbl.Visible = false;
            }
            else if (p.GetType().Name == "FloorManagerRole")
            {
                roleLbl.Text = "Floor Manager";
                ContractLbl.Visible = false;
            }
            else if (p.GetType().Name == "EmployeeRole")
            {
                roleLbl.Text = "Employee";
                ContractLbl.Visible = true;
                ContractLbl.Text = ((FloorStaff)p).Contract;
            }
            else
            {
                roleLbl.Text = p.GetType().Name;
                ContractLbl.Visible = true;
            }
            AddressLbl.Text = p.Address;
            EmailLbl.Text = p.Email;
            PhoneLbl.Text = p.PhoneNumber;
            GenderLbl.Text = p.Gender;
            DOBLbl.Text = p.Birthdate.ToShortDateString();
            BSNLbl.Text = p.BSN_Num;
            CountryLbl.Text = p.Country;
            CityLbl.Text = p.City;
            RelationshipLbl.Text = p.Relationship;
        }
    }
}
