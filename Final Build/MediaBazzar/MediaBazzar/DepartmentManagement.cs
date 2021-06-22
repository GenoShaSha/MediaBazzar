using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class DepartmentManagement : IManager
    {
        private List<Department> departments;
        private DbDepartment dd;
        public DepartmentManagement()
        {
            departments = new List<Department>();
            dd = new DbDepartment();
            ReadDepartments();
        }
        public void AddObj(object obj)
        {
            departments.Add((Department)obj);
            dd.AddDepartement((Department)obj);
        }

        public List<object> GetListObj()
        {
            ReadDepartments();
            return departments.Cast<Object>().ToList();
        }

        public void RemoveObj(int id)
        {
            dd.RemoveDepartment(id);
        }
        public void ReadDepartments()
        {
            departments = dd.ReadDepartments();
        }

    }
}
