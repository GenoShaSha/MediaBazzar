using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class ShiftManagement
    {
        private List<Shift> shifts;
        private DbShift shiftdb;


        public ShiftManagement()
        {
            shifts = new List<Shift>();
            shiftdb = new DbShift();
        }

        public List<Shift> ShiftList
        {
            get { return shifts; }
        }

        public void AddShiftTime(Shift shift)
        {
            shifts.Add(shift);
            shiftdb.AddShift(shift);
        }

        public bool AddEmployeeToShift(DateTime shifttime, ShiftType type, FloorStaff employee)
        {
            foreach (Shift s in shifts)
            {
                if (s.ShiftDate == shifttime)
                {
                    if (s.Type == type)
                    {
                        foreach (FloorStaff e in s.ReturnEmployeesFromShift())
                        {
                            if (employee == e)
                            {
                                return false;
                            }
                        }
                        s.AddEmployeeToShift(employee);
                        return true;
                    }
                }
            }
            return false;
        }

        public void AssignEmployeeToShift(Shift s, Employee employee)
        {
            s.AddEmployeeToShift((FloorStaff)employee);
        }
        public List<FloorStaff> ReturnAssignedEmployees(DateTime shifttime, ShiftType type)
        {
            foreach (Shift s in shifts)
            {
                if (s.ShiftDate == shifttime)
                {
                    if (s.Type == type)
                    {
                        return s.ReturnEmployeesFromShift();
                    }
                }
            }
            return null;
        }
        public void ReadShifts()
        {
            shifts = shiftdb.ReadShifts();
        }
        public void ReadAssignedShifts()
        {
            shifts = shiftdb.ReadAssignedShifts();
        }
        public string[,] ReturnPreference(string preference)
        {
            string[,] preferencearray = new string[3, 7];
            int i = -1;
            int j = 0;
            foreach (char c in preference)
            {
                if (c.Equals('9') == false)
                {
                    preferencearray[i, j] = c.ToString();
                    j++;
                }
                else
                {
                    i++;
                    j = 0;
                }
            }
            return preferencearray;
        }

        public bool CheckIfPreferred(string[,] preference, int i, int j)
        {
            char[] c = preference[i, j].ToCharArray();
            if (c[0].Equals('1') == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
