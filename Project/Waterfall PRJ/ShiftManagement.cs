using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
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
        }

        public bool AddEmployeeToShift(DateTime shifttime, ShiftType type, FloorStaff employee)
        {
            foreach(Shift s in shifts)
            {
               if(s.ShiftDate == shifttime)
                {
                    if(s.Type == type)
                    {
                        foreach(FloorStaff e in s.ReturnEmployeesFromShift())
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
                if(s.ShiftDate == shifttime)
                {
                  if(s.Type == type)
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
    }
}
