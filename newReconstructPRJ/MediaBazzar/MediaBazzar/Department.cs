using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Department
    {
        private int id;
        private string departmentName;

        public Department(string name)
        {
            this.departmentName = name;
        }
        public Department(int id, string name)
        {
            this.id = id;
            this.departmentName = name;
        }
        public void Update(string name)
        {
            this.departmentName = name;
        }
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.departmentName; }
            set { this.departmentName = value; }
        }
        public override string ToString()
        {
            return $"{id} : {departmentName}";
        }
    }
}
