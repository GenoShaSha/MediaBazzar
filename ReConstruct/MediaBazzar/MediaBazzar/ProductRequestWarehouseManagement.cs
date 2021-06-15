using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class ProductRequestWarehouseManagement
    {
        private List<ProductRequestWarehouse> requests;
        private DbProductRequestWarehouse dr;
        public ProductRequestWarehouseManagement()
        {
            requests = new List<ProductRequestWarehouse>();
            dr = new DbProductRequestWarehouse();
        }
        public void AddRequest(ProductRequestWarehouse request)
        {
            requests.Add(request);
            dr.AddRequest(request);
        }
        public void RemoveRequest(ProductRequestWarehouse request)
        {
            requests.Remove(request);
            dr.RemoveRequest(request);
        }
        public void ReadRequest()
        {
            requests = dr.ReadRequest();
        }

        public List<ProductRequestWarehouse> GetRequest()
        {
            ReadRequest();
            return requests;
        }
    }
}
