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
    public partial class AddRmvProductForm : Form
    {
        private Wrappers wrp;
        public AddRmvProductForm()
        {
            InitializeComponent();
            wrp = new Wrappers();
            UpdateStockListbox();
            UpdateCbxDepartment();
        }



        public void UpdateCbxDepartment()
        {
            List<Object> DepartmentList = wrp.DM.GetListObj();
            foreach (var item in DepartmentList)
            {
                cbxCategory.Items.Add(item);
                CategoryCB.Items.Add(item);
            }
        }
        public void UpdateStockListbox()
        {
            lbxStock.Items.Clear();
            lbxStock.HorizontalScrollbar = true;
            List<Object> productList = wrp.PM.GetListObj();
            foreach (var item in productList)
            {
                if (item != null)
                {
                    lbxStock.Items.Add(item);
                }
            }
        }
        public void UpdateStockListboxCategory(string category)
        {
            lbxStock.Items.Clear();
            lbxStock.HorizontalScrollbar = true;
            List<Object> productList = wrp.PM.GetListObj();
            foreach (var item in productList)
            {
                if (item != null)
                {
                    if (((Product)item).Category == category)
                    {
                        lbxStock.Items.Add(item);
                    }
                }
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                wrp.PM.AddObj(new Product(Convert.ToInt32(tbxArtNumb.Text), tbxProductName.Text, cbxCategory.SelectedItem.ToString(), Convert.ToDecimal(tbxProductPrice.Text), tbxDimention.Text, Convert.ToInt32(tbxQuantity.Text)));
                tbxArtNumb.Text = string.Empty;
                tbxProductName.Text = string.Empty;
                tbxProductPrice.Text = string.Empty;
                tbxDimention.Text = string.Empty;
                UpdateStockListbox();
                MessageBox.Show("Stock has been Added!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Failed to add new Stock!");
            }

        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            try
            {
                int newID = Convert.ToInt32(tbxRmvID.Text);
                wrp.PM.DiscontinuedProduct(newID);
                wrp.PRM.RemoveRequest(wrp.PRM.GetRequestByID(newID));
                UpdateStockListbox();
                MessageBox.Show("Stock has been discontinued!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please input the ID!");
            }

        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
                UpdateStockListboxCategory(CategoryCB.Text);
        }

        private void StockIdSearchTB_TextChanged(object sender, EventArgs e)
        {
            lbxStock.Items.Clear();
            List<Object> productList = wrp.PM.GetListObj();
            if (StockIdSearchTB.Text != string.Empty)
            {
                foreach (var item in productList)
                {
                    if (Convert.ToInt32(StockIdSearchTB.Text) == ((Product)item).ArticleNumbers)
                    {
                        lbxStock.Items.Add(item);
                    }
                }
            }
            if (StockIdSearchTB.Text == string.Empty)
            {
                CategoryCB.SelectedIndex = 0;
                UpdateStockListbox();
            }

        }

        private void btnProdRequest_Click(object sender, EventArgs e)
        {
            RestockWarehouseProductManagementForm rwp = new RestockWarehouseProductManagementForm();
            rwp.Show();
            this.Hide();
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            UpdateProductPrice upp = new UpdateProductPrice();
            upp.Show();
            this.Hide();
        }
    }
}
