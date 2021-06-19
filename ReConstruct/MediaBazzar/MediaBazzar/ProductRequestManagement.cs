using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class ProductRequestManagement
    {
        private List<ProductRequest> requests;
        private DbProductRequest dr;
        public ProductRequestManagement()
        {
            requests = new List<ProductRequest>();
            dr = new DbProductRequest();
        }
        public void AddRequest(ProductRequest request)
        {
            requests.Add(request);
            dr.AddRequest(request);
        }
        public void RemoveRequest(ProductRequest request)
        {
            requests.Remove(request);
            dr.RemoveRequest(request);
        }
        public ProductRequest GetRequestByID(int id)
        {
            foreach (ProductRequest p in requests)
            {
                if (p.ProductID == id)
                {
                    return p;
                }
            }
            return null;

        }
        public void ReadRequest()
        {
            requests = dr.ReadRequest();
        }

        public List<ProductRequest> GetRequest()
        {
            ReadRequest();
            return requests;
        }
    }
}
