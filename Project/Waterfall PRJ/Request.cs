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
        private int id;

        public Request(int amount, int id)
        {
            this.amountRequest = amount;
            this.id = id;
        }
        public int AmountRequest
        {
            get { return this.amountRequest; }
            set { this.amountRequest = value; }
        }
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public override string ToString()
        {
            return $"Good ID :{id}, Quantity :{amountRequest} units.";
        }

    }
}
