using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_StockManagement
{
    public class ProductManager
    {
        List<Product> products;
        public ProductManager()
        {
            products = new List<Product>();
        }
        public Product GetProduct(int ID)
        {
            foreach (Product p in products)
            {
                if (p.ID == ID)
                {
                    return p;
                }
            }
            return null;
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
