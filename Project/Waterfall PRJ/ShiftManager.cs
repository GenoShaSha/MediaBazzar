using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    class ShiftManager
    {
        List<Shift> shifts;

        public ShiftManager()
        {
            shifts = new List<Shift>();
        }

        public void AddShiftTime(DateTime shifttime)
        {
            shifts.Add(new Shift(shifttime));
        }

        public void AddShifts(DateTime shifttime, string shift, EmployeeRole employee)
        {
            foreach(Shift s in shifts)
            {
                if(s.ShiftDate == shifttime)
                {
                        if (shift == "morning")
                        {
                            s.AddMorningShift(employee);
                        }
                        else if (shift == "evening")
                        {
                            s.AddEveningShift(employee);
                        }
                        else
                        {
                            s.AddNightShift(employee);
                        }
                    
                }
            }
        }
        public List<EmployeeRole> ShiftGetter(DateTime shifttime, string shift)
        {
            foreach (Shift s in shifts)
            {
                if(s.ShiftDate == shifttime)
                {
                    if (shift == "morning")
                    {
                        return s.ReturnShifts("morning");
                    }
                    if (shift == "evening")
                    {
                        return s.ReturnShifts("evening");
                    }
                    if (shift == "night")
                    {
                        return s.ReturnShifts("night");
                    }
                }
            }
            return null;
        }
    }
}
