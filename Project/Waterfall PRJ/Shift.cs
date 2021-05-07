using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class Shift
    {
        private List<FloorStaff> employees;
        private DateTime shiftdate;
        private ShiftType type;
        public Shift(DateTime shiftdate, ShiftType type)
        {
            this.shiftdate = shiftdate;
            this.type = type;
            this.employees = new List<FloorStaff>();
        }
        public DateTime ShiftDate
        {
            get { return this.shiftdate; }
        }

        public ShiftType Type
        {
            get { return this.type; }
        }
        public void AddEmployeeToShift(FloorStaff employee)
        {
            employees.Add(employee);
        }

        public List<FloorStaff> ReturnEmployeesFromShift()
        {
            return this.employees;
        }
    }
}
