using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class GoodManagement
    {
        private List<Good> goods;
        private List<Good> goods2;
        private DbGoods dg;
        private Request rqst;
        Good g;

        public GoodManagement()
        {
            goods = new List<Good>();
            goods2 = new List<Good>();
            dg = new DbGoods();
        }
        public void AddProduct(Good good)
        {
            goods.Add(good);
            dg.AddGood(good);
        }
        public void AddProductToFloor(Good good)
        {
            if(g.ID == good.ID)
            {
                goods2.Add(good);
                goods.Remove(good);
            }
        }
        public void RemoveProduct(int id)
        {
            dg.RemoveGood(id);
        }
        public void ReadGoods()
        {
            goods = dg.ReadGoods();
        }

        public List<Good> GetProducts()
        {
            ReadGoods();
            return goods;
        }
    }
}
