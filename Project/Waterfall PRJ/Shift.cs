using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class Shift
    {
        private List<EmployeeRole> morningshift;
        private List<EmployeeRole> eveningshift;
        private List<EmployeeRole> nightshift;
        private DateTime shiftdate;

       public Shift(DateTime shiftdate)
        {
            this.shiftdate = shiftdate;
            this.morningshift = new List<EmployeeRole>();
            this.eveningshift = new List<EmployeeRole>();
            this.nightshift = new List<EmployeeRole>();
        }
        public DateTime ShiftDate
        {
            get { return this.shiftdate; }
        }
            
        
        public void AddMorningShift(EmployeeRole employee)
        {
            try
            {
                this.morningshift.Add(employee);
                //employee.Workhours -= 6;
            }
            catch (NullReferenceException ex)
            {
                System.Windows.Forms.MessageBox.Show("You haven't selected a employee");

            }
        }
        public void AddEveningShift(EmployeeRole employee)
        {
            try
            {
                this.eveningshift.Add(employee);
                //employee.Workhours -= 6;
            }
            catch (NullReferenceException ex)
            {
                System.Windows.Forms.MessageBox.Show("You haven't selected a employee");

            }
        }
        public void AddNightShift(EmployeeRole employee)
        {
            try
            {
                this.nightshift.Add(employee);
                //employee.Workhours -= 6;
            }
            catch (NullReferenceException ex)
            {
                System.Windows.Forms.MessageBox.Show("You haven't selected a employee");

            }
        }
       
        public List<EmployeeRole> ReturnShifts(string shift)
        {
            if(shift == "morning")
            {
                return this.morningshift;
            }
            else if (shift == "evening")
            {
                return this.eveningshift;
            }
            else if (shift == "night")
            {
                return this.nightshift;
            }
            else
            {
                return null;
            }
        }
    }
}
