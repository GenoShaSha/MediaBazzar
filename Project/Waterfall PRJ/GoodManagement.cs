using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class GoodManagement
    {
        List<Good> goods;
        private dbGoods dg;

        public GoodManagement()
        {
            goods = new List<Good>();
            dg = new dbGoods();
        }
        public Good GetProduct(int ID)
        {
            foreach (Good g in goods)
            {
                if (g.ID == ID)
                {
                    return g;
                }
            }
            return null;
        }
        public void AddProduct(Good good)
        {
            goods.Add(good);
            dg.AddGood(good);
        }
        public void RemoveProduct(int id)
        {
            dg.RemoveGood(id);
        }
        public List<Good> GetProducts()
        {
            return goods;
        }
    }
}
