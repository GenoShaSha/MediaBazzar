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
    public partial class SchedulingForm : Form
    {
        private DateTime date;
        private DateTime returnedDate;
        private List<Button> daybuttons;
        private Button[,] buttons;
        private ShiftType type = ShiftType.Morning;
        private DbEmployee de;
        private DbShift ds;
        private ShiftManagement shifts;
        private EmployeeManagement em;
        private List<Object> employeelist;
        public SchedulingForm()
        {
            InitializeComponent();
            daybuttons = new List<Button>() { sundayBtn, mondayBtn, tuesdayBtn, wednesdayBtn, thursdayBtn, fridayBtn, saturdayBtn };
            buttons = new Button[3, 7] { { MondayMorningBtn, TuesdayMorningBtn, WednesdayMorningBtn, ThursdayMorningBtn, FridayMorningBtn, SaturdayMorningBtn, SundayMorningBtn }, { MondayAfternoonBtn, TuesdayAfternoonBtn, WednesdayAfternoonBtn, ThursdayAfternoonBtn, FridayAfternoonBtn, SaturdayAfternoonBtn, SundayAfternoonBtn }, { MondayEveningBtn, TuesdayEveningBtn, WednesdayEveningBtn, ThursdayEveningBtn, FridayEveningBtn, SaturdayEveningBtn, SundayEveningBtn } };
            date = DateTime.Now;
            shifts = new ShiftManagement();
            em = new EmployeeManagement();
            de = new DbEmployee();
            ds = new DbShift();
            UpdateWorkshiftManagementListbox();
            MorningRB.Checked = true;
            UpdateShiftButtonValues();
            employeelist = em.GetListObj();
        }
        public void UpdateShiftButtonValues()
        {
            int currentday = (int)date.DayOfWeek;
            if (currentday > 0)
            {
                for (int i = currentday; i >= 0; i--)
                {
                    daybuttons[i].Text = date.AddDays(i - currentday).ToShortDateString();
                }
                for (int j = currentday + 1; j < 7; j++)
                {
                    daybuttons[j].Text = date.AddDays(j - currentday).ToShortDateString();
                }
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    daybuttons[i].Text = date.AddDays(i).ToShortDateString();
                }
            }
        }

        private void btnProdRequest_Click(object sender, EventArgs e)
        {
            ProductRequestFloorForm prf = new ProductRequestFloorForm();
            prf.Show();
            this.Hide();
            
        }
        private void MorningRB_CheckedChanged(object sender, EventArgs e)
        {
            if (MorningRB.Checked)
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
        private void UpdateWorkshiftManagementListbox()
        {
            AvailableEmployeesLB.Items.Clear();
            List<Object> employeeList = em.GetListObj();
            foreach (Employee p in employeeList)
            {
                if (p is FloorStaff)
                {
                    AvailableEmployeesLB.Items.Add((FloorStaff)p);
                }
            }
        }
        private void UpdateWorkshiftsListbox()
        {
            List<Shift> shiftss = new List<Shift>();

            MorningShiftLB.Items.Clear();
            AfternoonShiftLB.Items.Clear();
            NightShiftLB.Items.Clear();
            shifts.ReadAssignedShifts();
            foreach (Shift s in shiftss)
            {
                if (returnedDate == s.ShiftDate)
                {
                    if (s.Type == ShiftType.Morning)
                    {
                        foreach (FloorStaff e in s.ReturnEmployeesFromShift())
                        {
                            MorningShiftLB.Items.Add(e);
                        }
                    }
                }
            }
        }
        private void ReturnShiftEmployeesLB(DateTime returndate)
        {
            //MorningShiftLB.Items.Clear();
            //AfternoonShiftLB.Items.Clear();
            //NightShiftLB.Items.Clear();
            if (shifts.ShiftList.Count > 0)
            {
                List<FloorStaff> morningEmps = shifts.ReturnAssignedEmployees(returndate, ShiftType.Morning);
                List<FloorStaff> afternooonEmps = shifts.ReturnAssignedEmployees(returndate, ShiftType.Afternoon);
                List<FloorStaff> nightEmps = shifts.ReturnAssignedEmployees(returndate, ShiftType.Night);
                if (morningEmps != null)
                {
                    foreach (FloorStaff e in morningEmps)
                    {
                        MorningShiftLB.Items.Add(e.FirstName + " " + e.LastName);
                    }
                }
                if (afternooonEmps != null)
                {
                    foreach (FloorStaff e in afternooonEmps)
                    {
                        AfternoonShiftLB.Items.Add(e.FirstName + " " + e.LastName);
                    }
                }
                if (nightEmps != null)
                {
                    foreach (FloorStaff e in nightEmps)
                    {
                        NightShiftLB.Items.Add(e.FirstName + " " + e.LastName);
                    }
                }
            }
        }
        private void sundayBtn_Click(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(sundayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            UpdateWorkshiftsListbox();
            ReturnShiftEmployeesLB(returnedDate);

            UpdateWorkshiftManagementListbox();
        }

        private void saturdayBtn_Click_1(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(saturdayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            UpdateWorkshiftsListbox();
            ReturnShiftEmployeesLB(returnedDate);

            UpdateWorkshiftManagementListbox();
        }

        private void fridayBtn_Click_1(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(fridayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            UpdateWorkshiftsListbox();
            ReturnShiftEmployeesLB(returnedDate);

            UpdateWorkshiftManagementListbox();
        }

        private void thursdayBtn_Click_1(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(thursdayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            UpdateWorkshiftsListbox();
            ReturnShiftEmployeesLB(returnedDate);

            UpdateWorkshiftManagementListbox();
        }

        private void wednesdayBtn_Click_1(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(wednesdayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            UpdateWorkshiftsListbox();
            ReturnShiftEmployeesLB(returnedDate);

            UpdateWorkshiftManagementListbox();
        }

        private void tuesdayBtn_Click_1(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(tuesdayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            UpdateWorkshiftsListbox();
            ReturnShiftEmployeesLB(returnedDate);

            UpdateWorkshiftManagementListbox();
        }

        private void mondayBtn_Click_1(object sender, EventArgs e)
        {
            returnedDate = Convert.ToDateTime(mondayBtn.Text);
            dateLbl.Text = returnedDate.ToShortDateString();
            UpdateWorkshiftsListbox();
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

        private void MorningRB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (MorningRB.Checked)
            {
                type = ShiftType.Morning;
            }
        }

        private void AfternoonRB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (AfternoonRB.Checked)
            {
                type = ShiftType.Afternoon;
            }
        }

        private void NightRB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (NightRB.Checked)
            {
                type = ShiftType.Night;
            }
        }

        private void AutoBtn_Click(object sender, EventArgs e)
        {
            bool preferred;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    listBox2.Items.Clear();
                    AvailableEmployeesOverviewLB.Items.Clear();
                    List<Object> emplist = new List<Object>();
                    foreach (Employee employee in employeelist)
                    {
                        if (employee is Staff)
                        {
                            employee.Preference = ds.ReturnPreference(employee.Id);
                            if (string.IsNullOrEmpty(employee.Preference) != true)
                            {
                                preferred = shifts.CheckIfPreferred(shifts.ReturnPreference(employee.Preference), i, j);
                                if (preferred == true && ((Staff)employee).WorkHours > 0)
                                {
                                    emplist.Add(employee);
                                    listBox2.Items.Add(employee + " " + ((Staff)employee).WorkHours);
                                }
                            }
                        }

                    }
                    List<Object> SortedList = emplist.OrderByDescending(o => ((Staff)o).WorkHours).ThenBy(o => ((Staff)o).FirstName).ToList();
                    foreach (Employee employ in SortedList)
                    {
                        AvailableEmployeesOverviewLB.Items.Add(employ + " " + ((Staff)employ).WorkHours);
                    }
                    if (SortedList.Count != 0)
                    {
                        buttons[i, j].Text = ((Staff)SortedList[0]).FirstName;
                        ((Staff)SortedList[0]).WorkHours -= 6;
                        if (i == 0)
                        {
                            type = ShiftType.Morning;
                            if (j == 0)
                            {
                                returnedDate = Convert.ToDateTime(mondayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 1)
                            {
                                returnedDate = Convert.ToDateTime(tuesdayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 2)
                            {
                                returnedDate = Convert.ToDateTime(wednesdayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 3)
                            {
                                returnedDate = Convert.ToDateTime(thursdayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 4)
                            {
                                returnedDate = Convert.ToDateTime(fridayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 5)
                            {
                                returnedDate = Convert.ToDateTime(saturdayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 6)
                            {
                                returnedDate = Convert.ToDateTime(sundayBtn.Text);
                                returnedDate.AddDays(7);
                            }


                        }
                        else if (i == 1)
                        {
                            type = ShiftType.Afternoon;
                            if (j == 0)
                            {
                                returnedDate = Convert.ToDateTime(mondayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 1)
                            {
                                returnedDate = Convert.ToDateTime(tuesdayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 2)
                            {
                                returnedDate = Convert.ToDateTime(wednesdayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 3)
                            {
                                returnedDate = Convert.ToDateTime(thursdayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 4)
                            {
                                returnedDate = Convert.ToDateTime(fridayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 5)
                            {
                                returnedDate = Convert.ToDateTime(saturdayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 6)
                            {
                                returnedDate = Convert.ToDateTime(sundayBtn.Text);
                                returnedDate.AddDays(7);
                            }

                        }
                        else if (i == 2)
                        {
                            type = ShiftType.Night;
                            if (j == 0)
                            {
                                returnedDate = Convert.ToDateTime(mondayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 1)
                            {
                                returnedDate = Convert.ToDateTime(tuesdayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 2)
                            {
                                returnedDate = Convert.ToDateTime(wednesdayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 3)
                            {
                                returnedDate = Convert.ToDateTime(thursdayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 4)
                            {
                                returnedDate = Convert.ToDateTime(fridayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 5)
                            {
                                returnedDate = Convert.ToDateTime(saturdayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                            else if (j == 6)
                            {
                                returnedDate = Convert.ToDateTime(sundayBtn.Text);
                                returnedDate.AddDays(7);
                            }
                        }
                        shifts.ReadShifts();
                        Employee emp = (Employee)AvailableEmployeesLB.SelectedItem;
                        if (ds.ReturnShift(new Shift(returnedDate, type)) == false)
                        {
                            ds.AddShift(new Shift(returnedDate, type));
                        }
                        shifts.ReadShifts();
                        foreach (Shift s in shifts.ShiftList)
                        {
                            if (s.Type == type && s.ShiftDate == returnedDate)
                            {
                                ds.AddAssignments(((Staff)SortedList[0]).Id, s.ID);
                            }
                        }
                        ReturnShiftEmployeesLB(returnedDate);
                    }

                    //MessageBox.Show(i.ToString() + " " + j.ToString());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    listBox2.Items.Clear();
                    AvailableEmployeesOverviewLB.Items.Clear();
                    if (string.IsNullOrEmpty(buttons[i, j].Text) == true)
                    {
                        List<Object> RemainderList = new List<Object>();
                        foreach (Employee remainderemp in employeelist)
                        {
                            if (remainderemp is Staff)
                            {
                                if (((Staff)remainderemp).WorkHours > 0)
                                {
                                    RemainderList.Add(remainderemp);
                                    listBox2.Items.Add(remainderemp + " " + ((Staff)remainderemp).WorkHours);
                                }
                            }

                        }
                        List<Object> SortedRemainder = RemainderList.OrderByDescending(o => ((Staff)o).WorkHours).ThenBy(o => ((Staff)o).FirstName).ToList();
                        foreach (Employee employ in SortedRemainder)
                        {
                            AvailableEmployeesOverviewLB.Items.Add(employ + " " + ((Staff)employ).WorkHours);
                        }
                        if (SortedRemainder.Count != 0)
                        {
                            buttons[i, j].Text = ((Staff)SortedRemainder[0]).FirstName;
                            ((Staff)SortedRemainder[0]).WorkHours -= 6;
                            if (i == 0)
                            {
                                type = ShiftType.Morning;
                                if (j == 0)
                                {
                                    returnedDate = Convert.ToDateTime(mondayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 1)
                                {
                                    returnedDate = Convert.ToDateTime(tuesdayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 2)
                                {
                                    returnedDate = Convert.ToDateTime(wednesdayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 3)
                                {
                                    returnedDate = Convert.ToDateTime(thursdayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 4)
                                {
                                    returnedDate = Convert.ToDateTime(fridayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 5)
                                {
                                    returnedDate = Convert.ToDateTime(saturdayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 6)
                                {
                                    returnedDate = Convert.ToDateTime(sundayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                            }
                            else if (i == 1)
                            {
                                type = ShiftType.Afternoon;
                                if (j == 0)
                                {
                                    returnedDate = Convert.ToDateTime(mondayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 1)
                                {
                                    returnedDate = Convert.ToDateTime(tuesdayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 2)
                                {
                                    returnedDate = Convert.ToDateTime(wednesdayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 3)
                                {
                                    returnedDate = Convert.ToDateTime(thursdayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 4)
                                {
                                    returnedDate = Convert.ToDateTime(fridayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 5)
                                {
                                    returnedDate = Convert.ToDateTime(saturdayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 6)
                                {
                                    returnedDate = Convert.ToDateTime(sundayBtn.Text);
                                    returnedDate.AddDays(7);
                                }

                            }
                            else if (i == 2)
                            {
                                type = ShiftType.Night;
                                if (j == 0)
                                {
                                    returnedDate = Convert.ToDateTime(mondayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 1)
                                {
                                    returnedDate = Convert.ToDateTime(tuesdayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 2)
                                {
                                    returnedDate = Convert.ToDateTime(wednesdayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 3)
                                {
                                    returnedDate = Convert.ToDateTime(thursdayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 4)
                                {
                                    returnedDate = Convert.ToDateTime(fridayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 5)
                                {
                                    returnedDate = Convert.ToDateTime(saturdayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                                else if (j == 6)
                                {
                                    returnedDate = Convert.ToDateTime(sundayBtn.Text);
                                    returnedDate.AddDays(7);
                                }
                            }
                            shifts.ReadShifts();
                            Employee emp = (Employee)AvailableEmployeesLB.SelectedItem;
                            if (ds.ReturnShift(new Shift(returnedDate, type)) == false)
                            {
                                ds.AddShift(new Shift(returnedDate, type));
                            }
                            shifts.ReadShifts();
                            foreach (Shift s in shifts.ShiftList)
                            {
                                if (s.Type == type && s.ShiftDate == returnedDate)
                                {
                                    ds.AddAssignments(((Staff)SortedRemainder[0]).Id, s.ID);
                                }
                            }
                            ReturnShiftEmployeesLB(returnedDate);
                        }
                        //MessageBox.Show(i.ToString() + " " + j.ToString());
                    }
                }
            }
            MessageBox.Show("Automatic scheduling complete!");
            schedulingTab.SelectedTab = tabPage1;
        }

        private void AvailableEmployeesLB_Click(object sender, EventArgs e)
        {
            if (AvailableEmployeesLB.SelectedIndex > -1)
            {
                Employee p = (Employee)AvailableEmployeesLB.SelectedItem;

                workhrsLbl.Text = ((Staff)p).WorkHours.ToString() + "hours";
                if (((Staff)p).WorkHours < 0)
                {
                    workhrsLbl.ForeColor = Color.Red;
                }
                else
                {
                    workhrsLbl.ForeColor = Color.Black;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            shifts.ReadShifts();
            Employee emp = (Employee)AvailableEmployeesLB.SelectedItem;
            if (ds.ReturnShift(new Shift(returnedDate, type)) == false)
            {
                ds.AddShift(new Shift(returnedDate, type));
            }
            shifts.ReadShifts();
            foreach (Shift s in shifts.ShiftList)
            {
                if (s.Type == type && s.ShiftDate == returnedDate)
                {
                    s.AddEmployeeToShift((FloorStaff)emp);
                    ds.AddAssignments(((FloorStaff)emp).Id, s.ID);
                    MessageBox.Show("Adding to shift succesfull.");
                }
            }
            ReturnShiftEmployeesLB(returnedDate);
        }
    }
}
