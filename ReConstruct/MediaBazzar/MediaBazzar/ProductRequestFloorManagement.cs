using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class ProductRequestFloorManagement 
    {
        private List<ProductRequestFloor> requests;
        private DbProductRequestFloor dr;
        public ProductRequestFloorManagement()
        {
            requests = new List<ProductRequestFloor>();
            dr = new DbProductRequestFloor();
        }
        public void AddRequest(ProductRequestFloor request)
        {
            requests.Add(request);
            dr.AddRequest(request);
        }
        public void RemoveRequest(ProductRequestFloor request)
        {
            requests.Remove(request);
            dr.RemoveRequest(request);
        }
        public void ReadRequest()
        {
            requests = dr.ReadRequest();
        }

        public List<ProductRequestFloor> GetRequest()
        {
            ReadRequest();
            return requests;
        }
    }
}
