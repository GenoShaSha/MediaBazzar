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
        private ProductRequestManagement prm;
        private ShiftManagement sm;

        public Wrappers()
        {
            em = new EmployeeManagement();
            pm = new ProductManagement();
            prm = new ProductRequestManagement();
            sm = new ShiftManagement();
        }
        public EmployeeManagement EM
        {
            get { return this.em; }
        }
        public ProductManagement PM
        {
            get { return this.pm; }
        }
        public ProductRequestManagement PRM
        {
            get { return this.prm; }
        }
        public ShiftManagement SM
        {
            get { return this.sm; }
        }
    }
}
