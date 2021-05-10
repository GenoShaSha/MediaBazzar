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
        EmployeeManagement em;
        ShiftManagement shifts;
        Thread th;
        private DateTime date;
        private DateTime returnedDate;
        private List<Button> daybuttons;
        private ShiftType type = ShiftType.Morning;
         DbEmployees dc;
        MedBazzar mb;

        public ManagementForm()
        {
            InitializeComponent();
            em = new EmployeeManagement();
            shifts = new ShiftManagement();
            GenderCB.SelectedIndex = 0;
            relationshipStatusCB.SelectedIndex = 0;
            RoleCB.SelectedIndex = 0;
            ContractCB.SelectedIndex = 0;
            ManagementTabControl.SelectedTab = EmployeeManagePage;
            updateBTN.Visible = false;
            date = DateTime.Now;
            daybuttons = new List<Button>() { sundayBtn, mondayBtn, tuesdayBtn,wednesdayBtn,thursdayBtn,fridayBtn,saturdayBtn};
            UpdateEmployeeManagementListbox();
            dc = new DbEmployees();
            mb = new MedBazzar();
        }

        public ManagementForm(EmployeeManagement employees, ShiftManagement shifts)
        {
            InitializeComponent();
            this.em = employees;
            this.shifts = shifts;
            GenderCB.SelectedIndex = 0;
            relationshipStatusCB.SelectedIndex = 0;
            RoleCB.SelectedIndex = 0;
            ContractCB.SelectedIndex = 0;
            ManagementTabControl.SelectedTab = EmployeeManagePage;
            updateBTN.Visible = false;
            UpdateEmployeeManagementListbox();
            date = DateTime.Now;
            daybuttons = new List<Button>() { mondayBtn, tuesdayBtn, wednesdayBtn, thursdayBtn, fridayBtn, saturdayBtn, sundayBtn };
            dc = new DbEmployees();
            mb = new MedBazzar();
        }
        public void UpdateEmployeeManagementListbox()
        {
            employeesLB.Items.Clear();
            List<Employee> employeeList = em.GetPersons();
            foreach (var item in employeeList)
            {
                if (item != null)
                {
                    employeesLB.Items.Add(item);
                }
            }
        }

        private void UpdateWorkshiftManagementListbox()
        {
            AvailableEmployeesLB.Items.Clear();
            List<Employee> employeeList = em.GetPersons();
            foreach (Employee p in employeeList)
            {
                if (p is FloorStaff)
                {
                    AvailableEmployeesLB.Items.Add((FloorStaff)p);
                }
            }
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
            Application.Run(new EmployeeAddingForm(em, shifts));
        }

        private void employeesLB_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                Employee p = (Employee)employeesLB.SelectedItem;
                firstNameTB.Text = p.FirstName;
                lastNameTB.Text = p.LastName;
                GenderCB.SelectedItem = p.Gender;
                DOBPicker.Value = p.Birthdate;
                BSN_TB.Text = p.BSN_Num;
                relationshipStatusCB.SelectedItem = p.Relationship;
                emailTB.Text = p.Email;
                tbxPswd.Text = p.Password;
                phoneNumberTB.Text = p.PhoneNumber;
                addressTB.Text = p.Address;
                postalCodeTB.Text = p.Postal;
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

        private void updateBTN_Click(object sender, EventArgs e)
        {
            Employee p = (Employee)employeesLB.SelectedItem;
            try
            {
                if (p.Birthdate > DateTime.Now.AddYears(-18))
                {
                    throw new BirthDateException();
                }
                mb.UpdatePerson(p, firstNameTB.Text, lastNameTB.Text, GenderCB.SelectedItem.ToString(), DOBPicker.Value, BSN_TB.Text, relationshipStatusCB.SelectedItem.ToString(), emailTB.Text, tbxPswd.Text
                    , phoneNumberTB.Text, addressTB.Text, postalCodeTB.Text, cityTB.Text, countryTB.Text);
                MessageBox.Show($"User ID information updated!");
                UpdateEmployeeManagementListbox();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Failed update an employee.");
            }
            catch (BirthDateException)
            {

            }
        }
        private void ShiftManagementPage_Enter(object sender, EventArgs e)
        {
            UpdateWorkshiftManagementListbox();
            UpdateShiftButtonValues();
            MorningRB.Checked = true;
        }
        private void AvailableEmployeesLB_MouseClick(object sender, MouseEventArgs e)
        {
            if(AvailableEmployeesLB.SelectedIndex > -1)
            {
                Employee p = (Employee)AvailableEmployeesLB.SelectedItem;

                workhrsLbl.Text = ((FloorStaff)p).Workhours.ToString() + "hours";
                if (((FloorStaff)p).Workhours < 0)
                {
                    workhrsLbl.ForeColor = Color.Red;
                }
                else
                {
                    workhrsLbl.ForeColor = Color.Black;
                }

            }
        }
        private void EmployeeManagePage_Click(object sender, EventArgs e)
        {
            employeesLB.SelectedIndex = -1;
            firstNameTB.Text = "";
            lastNameTB.Text = "";
            GenderCB.SelectedIndex = 0;
            DOBPicker.Value = date;
            BSN_TB.Text = "";
            relationshipStatusCB.SelectedIndex = 0;
            emailTB.Text = "";
            phoneNumberTB.Text = "";
            addressTB.Text = "";
            postalCodeTB.Text = "";
            cityTB.Text = "";
            countryTB.Text = "";
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }
        private void employeesLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Employee p = (Employee)employeesLB.SelectedItem;
                EmployeeInformation info = new EmployeeInformation(p);
                info.ShowDialog();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Please select an employee.");
            }
        }
        private void employeesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBTN.Visible = true;
        }
        public void UpdateShiftButtonValues()
        {
            int currentday = (int)date.DayOfWeek;
            if(currentday > 0)
            {
                for (int i = currentday; i>= 0; i--)
                {
                    daybuttons[i].Text = date.AddDays(i - currentday).ToShortDateString();
                }
                for (int j = currentday + 1; j < 7 ; j++)
                {
                    daybuttons[j].Text = date.AddDays(j - currentday).ToShortDateString();
                }
            }
            else
            {
                for(int i =0; i<7; i++)
                {
                    daybuttons[i].Text = date.AddDays(i).ToShortDateString();
                }
            }
        }
        private void ReturnShiftEmployeesLB(DateTime returndate)
        {
            MorningShiftLB.Items.Clear();
            AfternoonShiftLB.Items.Clear();
            NightShiftLB.Items.Clear();
           if (shifts.ShiftList.Count > 0)
            {
                List<FloorStaff> morningEmps = shifts.ReturnAssignedEmployees(returndate, ShiftType.Morning);
                List<FloorStaff> afternooonEmps = shifts.ReturnAssignedEmployees(returndate, ShiftType.Afternoon);
                List<FloorStaff> nightEmps = shifts.ReturnAssignedEmployees(returndate, ShiftType.Night);
                if (morningEmps != null)
                {
                    foreach (FloorStaff e in morningEmps)
                    {
                        MorningShiftLB.Items.Add(e.Name);
                    }
                }
                if (afternooonEmps != null)
                {
                    foreach (FloorStaff e in afternooonEmps)
                    {
                        AfternoonShiftLB.Items.Add(e.Name);
                    }
                }
                if (nightEmps != null)
                {
                    foreach (FloorStaff e in nightEmps)
                    {
                        NightShiftLB.Items.Add(e.Name);
                    }
                }
            }
        }
        private void sundayBtn_Click(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(sundayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            ReturnShiftEmployeesLB(returnedDate);
            UpdateWorkshiftManagementListbox();
        }
        private void btnAddShift_Click(object sender, EventArgs e)
        {
            try
            {
                FloorStaff emp = (FloorStaff)AvailableEmployeesLB.SelectedItem;
                if(shifts.AddEmployeeToShift(returnedDate,type,emp) == false)
                {
                    shifts.AddShiftTime(returnedDate, type);
                    shifts.AddEmployeeToShift(returnedDate, type, emp);
                }
                else
                {
                    shifts.AddEmployeeToShift(returnedDate, type, emp);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select an employee and date.");
            }
            finally 
            {
                MessageBox.Show("Shift Added!");
                ReturnShiftEmployeesLB(returnedDate);
            }
        }
        private void MorningRB_CheckedChanged(object sender, EventArgs e)
        {
            if(MorningRB.Checked)
            {
                type = ShiftType.Morning;
            }
        }
        private void AfternoonRB_CheckedChanged(object sender, EventArgs e)
        {
            if (AfternoonRB.Checked)
            {
                type = ShiftType.Afternoon;
            }
        }
        private void NightRB_CheckedChanged(object sender, EventArgs e)
        {
            if (NightRB.Checked)
            {
                type = ShiftType.Night;
            }
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            DateTime returnedDate;
            for (int i = 0; i < 7; i++)
            {
                returnedDate = Convert.ToDateTime(daybuttons[i].Text);
                returnedDate = returnedDate.AddDays(7);
                daybuttons[i].Text = returnedDate.ToShortDateString();
            }
        }
        private void mondayBtn_Click(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(mondayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            ReturnShiftEmployeesLB(returnedDate);
            UpdateWorkshiftManagementListbox();
        }
        private void tuesdayBtn_Click(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(tuesdayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            ReturnShiftEmployeesLB(returnedDate);
            UpdateWorkshiftManagementListbox();
        }
        private void wednesdayBtn_Click(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(wednesdayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            ReturnShiftEmployeesLB(returnedDate);
            UpdateWorkshiftManagementListbox();
        }
        private void thursdayBtn_Click(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(thursdayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            ReturnShiftEmployeesLB(returnedDate);
            UpdateWorkshiftManagementListbox();
        }
        private void fridayBtn_Click(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(fridayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            ReturnShiftEmployeesLB(returnedDate);
            UpdateWorkshiftManagementListbox();
        }
        private void saturdayBtn_Click(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(saturdayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            ReturnShiftEmployeesLB(returnedDate);
            UpdateWorkshiftManagementListbox();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            DateTime returnedDate;
            for (int i = 0; i < 7; i++)
            {
                returnedDate = Convert.ToDateTime(daybuttons[i].Text);
                returnedDate = returnedDate.AddDays(-7);
                daybuttons[i].Text = returnedDate.ToShortDateString();
            }
        }
    }
}
