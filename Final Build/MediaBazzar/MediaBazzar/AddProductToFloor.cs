using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazzar
{
    public partial class AddProductToFloor : Form
    {
        private Wrappers wrp;

        public AddProductToFloor()
        {
            InitializeComponent();
            wrp = new Wrappers();
            UpdateWarehouseProductListBox();
            UpdateFloorProductListbox();
        }
        public void UpdateWarehouseProductListBox()
        {
            lbxProductWarehouse.Items.Clear();
            lbxProductWarehouse.HorizontalScrollbar = true;
            List<Object> products = wrp.PM.GetListObj();
            foreach (var item in products)
            {
                if (item != null)
                {
                    lbxProductWarehouse.Items.Add(item);
                }
            }
        }
        public void UpdateFloorProductListbox()
        {
            lbxProductFloor.Items.Clear();
            lbxProductFloor.HorizontalScrollbar = true;
            List<Product> productList = wrp.PM.GetListProduct();
            foreach (var item in productList)
            {
                if (item != null)
                {
                    lbxProductFloor.Items.Add(item);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = (Product)lbxProductWarehouse.SelectedItem;
            try
            {
                if(Convert.ToInt32(tbxQuantity.Text) <= p.Quantity)
                wrp.PM.AddProductShop(new Product(Convert.ToInt32(lblRsltArtNumb.Text), lblRsltName.Text, lblRsltCategory.Text, Convert.ToDecimal(lblRsltPrice.Text), lblRsltDimention.Text,
                    Convert.ToInt32(tbxQuantity.Text)));
                wrp.PM.UpdateWarehouseProductQuantity(p, p.Quantity - Convert.ToInt32(tbxQuantity.Text));
                MessageBox.Show("The product has been added to the Shop!");
                UpdateFloorProductListbox();
                UpdateWarehouseProductListBox();
            }
            catch
            {
                MessageBox.Show("Falied to add the product to the Shop!");
            }
        }

        private void lbxProductWarehouse_MouseClick(object sender, MouseEventArgs e)
        {
            Product p = (Product)lbxProductWarehouse.SelectedItem;
            lblRsltArtNumb.Text = Convert.ToString(p.ArticleNumbers);
            lblRsltName.Text = p.ProductName;
            lblRsltPrice.Text = Convert.ToString(p.ProductPrice);
            lblRsltCategory.Text = p.Category;
            lblRsltDimention.Text = p.PhysicalDimensions;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SchedulingForm sf = new SchedulingForm();
            sf.Show();
            this.Hide();
        }
    }
}
