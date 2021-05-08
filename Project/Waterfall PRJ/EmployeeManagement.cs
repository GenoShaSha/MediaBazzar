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
        DbEmployees dc;

        public EmployeeManagement()
        {
            persons = new List<Employee>();
            dc = new DbEmployees();
        }

        public void AddPerson(Employee person)
        {
            persons.Add(person);
            dc.AddEmployees(person);
        }
        public void RemovePerson(long id)
        {
            dc.RemoveEmployees(id);
        }
        public List<Employee> GetPersons()
        {
            return persons;
        }
        public void ReadPersons()
        {
            persons = dc.ReadEmployees();
        }


        public Employee GetPerson(long ID)
        {
            foreach (Employee p in persons)
            {
                if (p.EmployeeID == ID)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
