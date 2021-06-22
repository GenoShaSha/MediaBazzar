using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Product
    {
        private int iD;
        private int articleNumbers;
        private string productName;
        private string category;
        private decimal productPrice;
        private string physicalDimensions;
        private int quantity;

        public Product(int articleNumbers, string productName, string category, decimal productPrice, string physicalDimensions, int quantity)
        {
            this.articleNumbers = articleNumbers;
            this.productName = productName;
            this.category = category;
            this.productPrice = productPrice;
            this.physicalDimensions = physicalDimensions;
            this.quantity = quantity;
        }
        public Product(int id, int articleNumbers, string productName, string category, decimal productPrice, string physicalDimensions, int quantity)
        {
            this.iD = id;
            this.articleNumbers = articleNumbers;
            this.productName = productName;
            this.category = category;
            this.productPrice = productPrice;
            this.physicalDimensions = physicalDimensions;
            this.quantity = quantity;
        }
        public void UpdateProductQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public void UpdateProductPrice(decimal price)
        {
            this.productPrice = price;
        }
        public int ID
        {
            get { return this.iD; }
        }
        public int ArticleNumbers
        {
            get { return this.articleNumbers; }
            set { this.articleNumbers = value; }
        }
        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }
        public string Category
        {
            get { return this.category; }
            set { this.category = value; }
        }
        public decimal ProductPrice
        {
            get { return this.productPrice; }
            set { this.productPrice = value; }
        }
        public string PhysicalDimensions
        {
            get { return this.physicalDimensions; }
            set { this.physicalDimensions = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
        }
        public override string ToString()
        {
            return $"ID :{iD}, Art. Number :{articleNumbers}, Name :{productName}, Price :{productPrice} euro, Quantity : {quantity} units.";
        }
        public virtual string GetInfo()
        {
            return $"ID :{iD}, Art. Number :{articleNumbers}, Name :{productName}, Price :{productPrice} euro";
        }
    }
}
