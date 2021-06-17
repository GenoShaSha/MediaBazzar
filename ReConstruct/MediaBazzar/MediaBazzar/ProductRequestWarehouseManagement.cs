﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class ProductRequestWarehouseManagement
    {
        private List<ProductRequest> requests;
        private DbProductRequest dr;
        public ProductRequestWarehouseManagement()
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
