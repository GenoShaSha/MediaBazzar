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
        private ProductRequestFloorManagement prfm;
        private ProductRequestWarehouseManagement prwm;
        private ShiftManagement sm;

        public Wrappers()
        {
            em = new EmployeeManagement();
            pm = new ProductManagement();
            prfm = new ProductRequestFloorManagement();
            prwm = new ProductRequestWarehouseManagement();
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
        public ProductRequestFloorManagement PRFM
        {
            get { return this.prfm; }
        }
        public ProductRequestWarehouseManagement PRWM
        {
            get { return this.prwm; }
        }
        public ShiftManagement SM
        {
            get { return this.sm; }
        }
    }
}
