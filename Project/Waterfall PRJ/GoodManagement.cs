﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class GoodManagement
    {
        List<Good> goods;
        private DbGoods dg;

        public GoodManagement()
        {
            goods = new List<Good>();
            dg = new DbGoods();
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
