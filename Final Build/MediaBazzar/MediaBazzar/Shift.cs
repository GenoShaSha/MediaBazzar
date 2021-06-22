using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Shift
    {
        private List<FloorStaff> employees;
        private DateTime shiftdate;
        private ShiftType type;
        private int id;
        public Shift(DateTime shiftdate, ShiftType type)
        {
            this.shiftdate = shiftdate;
            this.type = type;
            this.employees = new List<FloorStaff>();
        }

        public Shift(int id, DateTime date, ShiftType type)
        {
            this.shiftdate = date;
            this.type = type;
            this.employees = new List<FloorStaff>();
            this.id = id;
        }
        public DateTime ShiftDate
        {
            get { return this.shiftdate; }
        }
        public int ID
        {
            get { return this.id; }
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
