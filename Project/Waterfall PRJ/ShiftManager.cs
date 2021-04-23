using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class ShiftManager
    {
        private List<Shift> shifts;

        public ShiftManager()
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

        public bool AddEmployeeToShift(DateTime shifttime, ShiftType type, EmployeeRole employee)
        {
            foreach(Shift s in shifts)
            {
               if(s.ShiftDate == shifttime)
                {
                    if(s.Type == type)
                    {
                        s.AddEmployeeToShift(employee);
                        return true;
                    }
                }
            }
            return false;
        }
        public List<EmployeeRole> ReturnAssignedEmployees(DateTime shifttime, ShiftType type)
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
