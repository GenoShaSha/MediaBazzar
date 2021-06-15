using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class ProductManagement : IManager
    {
        private List<Product> products;
        private DbProductWarehouse dp;
        public ProductManagement()
        {
            products = new List<Product>();
            dp = new DbProductWarehouse();
        }
        public void AddObj(Object obj)
        {
            products.Add((Product)obj);
            dp.AddProduct((Product)obj);
        }

        public List<Object> GetListObj()
        {
            return products.Cast<Object>().ToList();
        }

        public void RemoveObj(int id)
        {
            dp.RemoveProduct(id);
        }

        public Product AddDiscontinuedProduct(int id)
        {
            foreach (Product p in products)
            {
                if (p.ID == id)
                {
                    return p;
                }
                dp.AddDiscontinuedProduct(p);
            }
            return null;
        }
        public void DiscontinuedProduct(int id)
        {
            AddDiscontinuedProduct(id);
            RemoveObj(id);
        }
        public Product ReturnProductByID(int id)
        {
            foreach (Product p in products)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }
            return null;
        }
        public void ReadProducts()
        {
            products = dp.ReadProducts();
        }

        public List<Product> GetProducts()
        {
            ReadProducts();
            return products;
        }
    }
}
