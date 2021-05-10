using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class Good
    {
        private int iD;
        private int articleNumbers;
        private string productName;
        private string category;
        private decimal productPrice;
        private string physicalDimensions;

        public Good(int articleNumbers, string productName, string category, decimal productPrice, string physicalDimensions)
        {
            this.articleNumbers = articleNumbers;
            this.productName = productName;
            this.category = category;
            this.productPrice = productPrice;
            this.physicalDimensions = physicalDimensions;
        }
        public Good(int id, int articleNumbers, string productName, string category, decimal productPrice, string physicalDimensions)
        {
            this.iD = id;
            this.articleNumbers = articleNumbers;
            this.productName = productName;
            this.category = category;
            this.productPrice = productPrice;
            this.physicalDimensions = physicalDimensions;
        }
        public void UpdateStock(int articleNumbers, string productName, string category, decimal productPrice, string physicalDimensions)
        {
            this.articleNumbers = articleNumbers;
            this.productName = productName;
            this.category = category;
            this.productPrice = productPrice;
            this.physicalDimensions = physicalDimensions;
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
        public override string ToString()
        {
            return $"Category :{category}, ID :{iD}, Art. Number :{articleNumbers}, Name :{productName}, Price :{productPrice} euro";
        }
        public virtual string GetInfo()
        {
            return $"Category :{category}, ID :{iD}, Art. Number :{articleNumbers}, Name :{productName}, Price :{productPrice} euro";
        }
    }
}
