using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class ProductRequest
    {
        private int emp_id;
        private int amountRequest;
        private int product_id;
        private string location;
        private DbProductWarehouse dpw;
        private DbProductFloor dpf;
        private DbEmployee de;
        Product product;
        string emp_name;
        public ProductRequest(int amount, int product_id, int emp_id, string location)
        {
            this.emp_id = emp_id;
            this.amountRequest = amount;
            this.product_id = product_id;
            this.location = location;
            dpw = new DbProductWarehouse();
            dpf = new DbProductFloor();
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
        public string Location
        {
            get { return this.location; }
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
            if(Location == "Warehouse")
            {
                return $"Requested by: {emp_name} ({EmpID}), Product :{product.ProductName} ({ProductID}), Quantity :{amountRequest} units, Location :Warehouse.";
            }
            else if(Location == "Floor")
            {
                return $"Requested by: {emp_name} ({EmpID}), Product :{product.ProductName} ({ProductID}), Quantity :{amountRequest} units, Location :Floor.";
            }
            return null;
        }

    }
}
