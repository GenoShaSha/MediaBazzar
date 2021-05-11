using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class Request
    {
        private int amountRequest;
        private Good good;
        private string status;

        public Request(int amount, string status)
        {
            this.amountRequest = amount;
            this.status = status;
        }
        
    }
}
