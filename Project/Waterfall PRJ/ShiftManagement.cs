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
        

        public ShiftManagement()
        {
            shifts = new List<Shift>();
        }

        public List<Shift> ShiftList
        {
            get { return shifts; }
        }

        public void AddShiftTime(DateTime shifttime, ShiftType type)
        {
            shifts.Add(new Shift(shifttime, type));
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
    }
}
