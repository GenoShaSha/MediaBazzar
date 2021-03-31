using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PRJ_PCBS04_G3
{
    public class EmployeeManager
    {
        List<Person> persons;
        public EmployeeDatabaseManager edm { get; set; }

        public EmployeeManager()
        {
            persons = new List<Person>();
            edm = new EmployeeDatabaseManager();
        }

        public void AddPerson(Person person)
        {
            edm.AddNewEmployeeToDB(person);
            persons.Add(person);
        }
        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }
        public List<Person> GetPersons()
        {
            return persons;
        }

        public Person GetPerson(long ID)
        {
            foreach (Person p in persons)
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
