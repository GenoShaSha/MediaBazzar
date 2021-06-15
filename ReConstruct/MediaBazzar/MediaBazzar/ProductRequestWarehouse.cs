﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class ProductRequestWarehouse
    {
        private int emp_id;
        private int amountRequest;
        private int product_id;
        private DbProductWarehouse dpw;
        private DbEmployee de;
        Product product;
        string emp_name;
        public ProductRequestWarehouse(int amount, int product_id, int emp_id)
        {
            this.emp_id = emp_id;
            this.amountRequest = amount;
            this.product_id = product_id;
            dpw = new DbProductWarehouse();
            de = new DbEmployee();
        }
        public int AmountRequest
        {
            get { return this.amountRequest; }
        }
        public int ProductID
        {
            get { return this.product_id; }
        }
        public int EmpID
        {
            get { return this.emp_id; }
        }
        private void GetProduct(int id) 
        {
            this.product = dpw.ReturnProductByID(id);
        }
        private void GetName(int id)
        {
            this.emp_name = de.GetName(id);
        }
        public override string ToString()
        {
            GetProduct(ProductID);
            GetName(EmpID);
            return $"Requested by: {emp_name} ({EmpID}), Product :{product.ProductName} ({ProductID}), Quantity :{amountRequest} units, Location :Warehouse.";
        }

    }
}
