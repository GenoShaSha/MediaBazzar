using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_StockManagement
{
    public partial class Form1 : Form
    {
        ProductManager products;
        public Form1()
        {
            InitializeComponent();
            products = new ProductManager();
            cbxCategory.SelectedIndex = 0;
        }

        public Form1(ProductManager products)
        {
            InitializeComponent();
            products = new ProductManager();
            cbxCategory.SelectedIndex = 0;
            UpdateLbxStock();
        }
        private void UpdateLbxStock()
        {
            lbxStock.Items.Clear();
            foreach (Product p in products.GetProducts())
            {
                lbxStock.Items.Add(p);
            }
        }
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            lbxStock.Items.Clear();
            lbxStock.HorizontalScrollbar = true;
            products.AddProduct(new Product(Convert.ToInt32(tbxArtNumb.Text), tbxProductName.Text, cbxCategory.SelectedItem.ToString(), Convert.ToDouble(tbxProductPrice.Text), tbxDimention.Text));
            foreach (Product p in products.GetProducts())
            {
                lbxStock.Items.Add(p);
            }
            tbxArtNumb.Text = string.Empty;
            tbxProductName.Text = string.Empty;
            tbxProductPrice.Text = string.Empty;
            tbxDimention.Text = string.Empty;
        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            Product p = (Product)lbxStock.SelectedItem;
            lbxStock.Items.Remove(p);
            products.RemoveProduct(p);
            UpdateLbxStock();
        }

        private void btnUpdateProducts_Click_1(object sender, EventArgs e)
        {
            Product p = (Product)lbxStock.SelectedItem;
            p.ArticleNumbers = Convert.ToInt32(tbxUpdateArtNr.Text);
            p.ProductName = tbxUpdateName.Text;
            p.Category = cbxUpdateCat.SelectedItem.ToString();
            p.ProductPrice = Convert.ToDouble(tbxUpdatePrice.Text);
            p.PhysicalDimensions = tbxUpdateDim.Text;

            MessageBox.Show($"Product {p.ID} information has been updated!");
            UpdateLbxStock();
        }

        private void lbxStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p = (Product)lbxStock.SelectedItem;
            tbxUpdateArtNr.Text = p.ArticleNumbers.ToString();
            tbxUpdateName.Text = p.ProductName;
            cbxUpdateCat.SelectedItem = p.Category;
            tbxUpdatePrice.Text = p.ProductPrice.ToString();
            tbxUpdateDim.Text = p.PhysicalDimensions;

        }
    }
}
