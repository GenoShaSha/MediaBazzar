using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Input;
using System.Threading;

namespace Waterfall_PRJ
{
    public partial class ManagementForm : Form
    {
        EmployeeManager employees;
        ShiftManager shifts;
        Thread th;
        public ManagementForm()
        {
            InitializeComponent();
            employees = new EmployeeManager();
            shifts = new ShiftManager();
            GenderCB.SelectedIndex = 0;
            relationshipStatusCB.SelectedIndex = 0;
            RoleCB.SelectedIndex = 0;
            ContractCB.SelectedIndex = 0;
            ManagementTabControl.SelectedTab = EmployeeManagePage;
        }

        public ManagementForm(EmployeeManager employees, ShiftManager shifts)
        {
            InitializeComponent();
            this.employees = employees;
            this.shifts = shifts;
            GenderCB.SelectedIndex = 0;
            relationshipStatusCB.SelectedIndex = 0;
            RoleCB.SelectedIndex = 0;
            ContractCB.SelectedIndex = 0;
            ManagementTabControl.SelectedTab = EmployeeManagePage;
            UpdateEmployeeManagementListbox();
        }
        public void UpdateEmployeeManagementListbox()
        {
            employeesLB.Items.Clear();
            foreach (Person p in employees.GetPersons())
            {
                employeesLB.Items.Add(p);
            }
        }

        private void UpdateWorkshiftManagementListbox()
        {
            AvailableEmployeesLB.Items.Clear();
            foreach (Person p in employees.GetPersons())
            {
                if (p is EmployeeRole)
                {
                    AvailableEmployeesLB.Items.Add((EmployeeRole)p);
                }
            }
        }
        private void btnAddShift_Click(object sender, EventArgs e)
        {
            DateTime Clicked_Date = (DateTime)EmployeeCalendar.SelectedDate;
            Person p = (Person)AvailableEmployeesLB.SelectedItem;
            shifts.AddShiftTime(Clicked_Date);
            if(ShiftSelectorCB.SelectedIndex == 0)
            {
                shifts.AddShifts(Clicked_Date, "morning", (EmployeeRole)p);
            }
            else if(ShiftSelectorCB.SelectedIndex == 1)
            {
                shifts.AddShifts(Clicked_Date, "evening", (EmployeeRole)p);
            }
            else
            {
                shifts.AddShifts(Clicked_Date, "night", (EmployeeRole)p);
            }
            AvailableEmployeesLB.SelectedIndex = -1;
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewForm(object obj)
        {
            Application.Run(new EmployeeAddingForm(employees, shifts));
        }

        private void employeesLB_MouseClick_1(object sender, MouseEventArgs e)
        {
            Person p = (Person)employeesLB.SelectedItem;
            firstNameTB.Text = p.FirstName;
            lastNameTB.Text = p.LastName;
            GenderCB.SelectedItem = p.Gender;
            DOBPicker.Value = p.Birthdate;
            BSN_TB.Text = p.BSN_Num;
            relationshipStatusCB.SelectedItem = p.Relationship;
            emailTB.Text = p.Email;
            phoneNumberTB.Text = p.PhoneNumber;
            addressTB.Text = p.Address;
            postalCodeTB.Text = p.Postal;
            cityTB.Text = p.City;
            countryTB.Text = p.Country;
            if(p.GetType().ToString() == "Waterfall_PRJ.Administrator")
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
            //JRUT
            //Still need to make it so that the textboxes get filled if you click on an employee.
            //THAL
            //Added filled textboxes
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            Person p = (Person)employeesLB.SelectedItem;
            employeesLB.Items.Remove(p);
            employees.RemovePerson(p);
            UpdateEmployeeManagementListbox();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            Person p = (Person)employeesLB.SelectedItem;
            p.FirstName = firstNameTB.Text;
            p.LastName = lastNameTB.Text;
            p.Gender = GenderCB.SelectedItem.ToString();
            p.Birthdate = DOBPicker.Value;
            p.BSN_Num = BSN_TB.Text;
            p.Relationship = relationshipStatusCB.SelectedItem.ToString();
            p.Email = emailTB.Text;
            p.PhoneNumber = phoneNumberTB.Text;
            p.Address = addressTB.Text;
            p.Postal = postalCodeTB.Text;
            p.City = cityTB.Text;
            p.Country = countryTB.Text;
            MessageBox.Show($"User ID {p.EmployeeID} information updated!");
            UpdateEmployeeManagementListbox();
        }

        private void RoleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RoleCB.SelectedIndex == 0)
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

        private void ShiftManagementPage_Enter(object sender, EventArgs e)
        {
            UpdateWorkshiftManagementListbox();
        }

        private void AvailableEmployeesLB_MouseClick(object sender, MouseEventArgs e)
        {
            if(AvailableEmployeesLB.SelectedIndex > -1)
            {
                Person p = (Person)AvailableEmployeesLB.SelectedItem;
                workhrsLbl.Text = ((EmployeeRole)p).Workhours.ToString() + "hours";
            }
            
        }

        private void EmployeeCalendar_Click(object sender, EventArgs e)
        {
            MorningShiftLB.Items.Clear();
            EveningShiftLB.Items.Clear();
            NightShiftLB.Items.Clear();
            DateTime Clicked_Date = (DateTime)EmployeeCalendar.SelectedDate;
            List<EmployeeRole> morningshifts = shifts.ShiftGetter(Clicked_Date, "morning");
            List<EmployeeRole> eveningshifts = shifts.ShiftGetter(Clicked_Date, "evening");
            List<EmployeeRole> nightshifts = shifts.ShiftGetter(Clicked_Date, "night");
            if(morningshifts != null)
            {
                foreach (EmployeeRole emp in morningshifts)
                {
                    MorningShiftLB.Items.Add(emp);
                }
            }
            if (eveningshifts != null)
            {
                foreach (EmployeeRole emp in eveningshifts)
                {
                   EveningShiftLB.Items.Add(emp);
                }
            }
            if (nightshifts != null)
            {
                foreach (EmployeeRole emp in nightshifts)
                {
                   NightShiftLB.Items.Add(emp);
                }
            }
            if(morningshifts == null && eveningshifts == null && nightshifts == null)
            {
                MorningShiftLB.Items.Clear();
                EveningShiftLB.Items.Clear();
                NightShiftLB.Items.Clear();
            }

        }
    }
}
