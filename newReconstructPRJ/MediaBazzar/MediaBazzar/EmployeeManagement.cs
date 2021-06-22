using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class EmployeeManagement : IManager
    {
        private List<Employee> employees;
        private DbEmployee de;
        private DbFiredEmployee df;
        public EmployeeManagement()
        {
            employees = new List<Employee>();
            de = new DbEmployee();
            df = new DbFiredEmployee();
        }
        public void AddObj(Object obj)
        {
            employees.Add((Employee)obj);
            de.AddEmployees((Employee)obj);
        }

        public List<Object> GetListObj()
        {
            ReadEmpoyees();
            return employees.Cast<Object>().ToList();
        }
        public void ReadEmpoyees()
        {
            employees = de.ReadEmployees();
        }
        public void RemoveObj(int id)
        {
            de.RemoveEmployees(id);
        }
        public void AddFiredEmployee(int id)
        {
            Employee em = GetEmpByID(id);
            df.AddResignEmployees(em);
        }
        public void FiredEmployee(int id)
        {
            AddFiredEmployee(id);
            RemoveObj(id);
        }
        public Employee GetEmpByID(int id)
        {
            foreach (Employee e in employees)
            {
                if(e.Id == id)
                {
                    return e;
                }
            }
            return null;
        }

        public void UpdateEmployee(Employee employee, string newFName, string newLName, string newGender, DateTime newDoB, string newBSN, string newRelationship, string newEmail, string newPass, string newPNumb, string newAddress, string newPCode, string newCity, string newCountry)
        {
            employee.UpdatePeople(newFName, newLName, newGender, newDoB, newBSN, newRelationship, newEmail, newPass, newPNumb, newAddress, newPCode, newCity, newCountry);
            de.UpdateEmployee(employee);
        }
    }
}
