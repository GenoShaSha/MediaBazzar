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
        private DbGoods dg;
        private DbEmployees de;
        Good good;
        string emp_name;

        public Request(int amount, int good_id,int emp_id)
        {
            this.emp_id = emp_id;
            this.amountRequest = amount;
            this.good_id = good_id;
            dg = new DbGoods();
            de = new DbEmployees();
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

        private void GetGood(int id)
        {
            this.good = dg.ReturnGoodByID(id);
        }

        private void GetName(int id)
        {
            this.emp_name = de.GetName(id);
        }
        public override string ToString()
        {
            GetGood(GoodID);
            GetName(EmpID);
            return $"Requested by: {emp_name} ({EmpID}), Good :{good.ProductName} ({GoodID}), Quantity :{amountRequest} units.";
        }

    }
}
