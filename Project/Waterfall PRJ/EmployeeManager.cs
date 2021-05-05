using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class EmployeeManager
    {
        List<Person> persons;
        dbControler dc = new dbControler();

        public EmployeeManager()
        {
            persons = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            persons.Add(person);
            dc.AddEmployees(person);
        }
        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }
        public List<Person> GetPersons()
        {
            return persons;
        }
        public void ReadPersons()
        {
            List<Person> employeeList = dc.ReadEmployees();
            foreach(var item in employeeList.ToList())
            {
                if (item != null)
                {
                    employeeList.Add(item);
                }
            }
        }

        
        public Person GetPerson(long ID)
        {
            foreach(Person p in persons)
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
