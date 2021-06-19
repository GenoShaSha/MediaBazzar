using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class ProductManagement : IManager
    {
        private List<Product> productsWarehouse;
        private List<Product> productsShop;
        private DbProductWarehouse dpw;
        private DbProductFloor dpf;
        private DbDiscontinuedProduct ddp;
        public ProductManagement()
        {
            productsWarehouse = new List<Product>();
            productsShop = new List<Product>();
            dpw = new DbProductWarehouse();
            dpf = new DbProductFloor();
            ddp = new DbDiscontinuedProduct();
        }
        public void AddObj(Object obj)
        {
            if(obj is Product)
            {
                productsWarehouse.Add((Product)obj);
                dpw.AddProduct((Product)obj);
            }
        }
        public void AddProductShop(Product product)
        {
            productsShop.Add(product);
            dpf.AddProduct(product);
        }

        public List<Object> GetListObj()
        {
            ReadProductsWarehouse();
            return productsWarehouse.Cast<Object>().ToList();
        }
        public List<Product> GetListProduct()
        {
            ReadProductsShop();
            return productsShop;
        }

        public void RemoveObj(int id)
        {
            dpw.RemoveProduct(id);
        }
        public void RemoveProductShop(int id)
        {
            dpf.RemoveProduct(id);
        }

        public void AddDiscontinuedProduct(int id)
        {
            Product pw = ReturnProductWarehouseByID(id);
            ddp.AddDiscontinuedProduct(pw);
        }
        public void DiscontinuedProduct(int id)
        {
            AddDiscontinuedProduct(id);
            RemoveObj(id);
            RemoveProductShop(id);
        }
        public Product ReturnProductWarehouseByID(int id)
        {
            foreach (Product p in productsWarehouse)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }
            return null;
        }
        public Product ReturnProductFloorByID(int id)
        {
            foreach (Product p in productsShop)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }
            return null;
        }
        public void ReadProductsWarehouse()
        {
            productsWarehouse = dpw.ReadProducts();
        }
        public void ReadProductsShop()
        {
            productsShop = dpf.ReadProducts();
        }
        public void UpdateWarehouseProductQuantity(Product p, int newQuantity)
        {
            p.UpdateProductQuantity(newQuantity);
            dpw.UpdateProductQuantity(p);
            dpf.UpdateProductQuantity(p);
        }
        public void UpdateWarehouseProductPrice(Product p, decimal price)
        {
            p.UpdateProductPrice(price);
            dpw.UpdateProductPrice(p);
        }
        public void UpdateFloorProductQuantity(Product p, int newQuantity)
        {
            p.UpdateProductQuantity(newQuantity);
            dpw.UpdateProductQuantity(p);
        }
        //public List<Product> GetProducts()
        //{
        //    ReadProducts();
        //    return products;
        //}
    }
}
