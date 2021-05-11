using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class Request
    {
        private int emp_id;
        private int amountRequest;
        private int good_id;

        public Request(int amount, int good_id,int emp_id)
        {
            this.emp_id = emp_id;
            this.amountRequest = amount;
            this.good_id = good_id;
        }
        public int AmountRequest
        {
            get { return this.amountRequest; }
        }
        public int GoodID
        {
            get { return this.good_id; }
        }
        public int EmpID
        {
            get { return this.emp_id; }
        }
        public override string ToString()
        {
            return $"Employeed ID: {EmpID} Good ID :{GoodID}, Quantity :{amountRequest} units.";
        }

    }
}
