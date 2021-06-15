using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Wrappers
    {
        private EmployeeManagement em;
        private ProductManagement pm;

        public Wrappers()
        {
            em = new EmployeeManagement();
            pm = new ProductManagement();
        }
        public EmployeeManagement EM
        {
            get { return this.em; }
        }
        public ProductManagement PM
        {
            get { return this.pm; }
        }
    }
}
