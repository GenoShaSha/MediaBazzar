using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    class RequestManagement
    {
        private List<Request> requests;
        private DbRequest dr;

        public RequestManagement()
        {
            requests = new List<Request>();
            dr = new DbRequest();
        }
        public void AddRequest(Request request)
        {
            requests.Add(request);
            dr.AddRequest(request);
        }
        public void RemoveRequest(Request request)
        {
            requests.Remove(request);
        }
        public void ReadRequest()
        {
            requests = dr.ReadRequest();
        }

        public List<Request> GetRequest()
        {
            ReadRequest();
            return requests;
        }
    }
}
