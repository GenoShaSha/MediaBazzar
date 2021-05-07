using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class EmployeeManagement
    {
        List<Employee> persons;
        dbEmployees dc = new dbEmployees();

        public EmployeeManagement()
        {
            persons = new List<Employee>();
        }

        public void AddPerson(Employee person)
        {
            persons.Add(person);
            dc.AddEmployees(person);
        }
        public void RemovePerson(Employee person)
        {
            persons.Remove(person);
        }
        public List<Employee> GetPersons()
        {
            return persons;
        }
        public void ReadPersons()
        {
            List<Employee> employeeList = dc.ReadEmployees();
            foreach(var item in employeeList.ToList())
            {
                if (item != null)
                {
                    employeeList.Add(item);
                }
            }
        }

        
        public Employee GetPerson(long ID)
        {
            foreach(Employee p in persons)
            {
                if(p.EmployeeID == ID)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
