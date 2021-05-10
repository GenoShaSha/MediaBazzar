using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterfall_PRJ
{
    public partial class StockForm : Form
    {
        private DbGoods dg;
        private GoodManagement gm;
        private MedBazzar mb;
        public StockForm()
        {
            InitializeComponent();
            dg = new DbGoods();
            gm = new GoodManagement();
            mb = new MedBazzar();
            UpdateStockListbox();
        }

        public void UpdateStockListbox()
        {
            lbxStock.Items.Clear();
            lbxStock.HorizontalScrollbar = true;
            List<Good> goodList = gm.GetProducts();
            foreach (var item in goodList)
            {
                if (item != null)
                {
                    lbxStock.Items.Add(item);
                }
            }
        }
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                mb.AddGood(Convert.ToInt32(tbxArtNumb.Text), tbxProductName.Text, cbxCategory.SelectedItem.ToString(), Convert.ToDecimal(tbxProductPrice.Text), tbxDimention.Text);
                tbxArtNumb.Text = string.Empty;
                tbxProductName.Text = string.Empty;
                tbxProductPrice.Text = string.Empty;
                tbxDimention.Text = string.Empty;
                UpdateStockListbox();
                MessageBox.Show("Stock has been Added!");
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Failed to add new Stock!");
            }
        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            try
            {
                int newID = Convert.ToInt32(tbxRmvID.Text);
                mb.RemoveGood(newID);
                UpdateStockListbox();
                MessageBox.Show("Stock has been removed!");
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Please input the ID!");
            }
        }

        private void btnUpdateProducts_Click(object sender, EventArgs e)
        {
            Good g = (Good)lbxStock.SelectedItem;
            try
            {
                mb.UpdateStock(g, Convert.ToInt32(tbxUpdateArtNr.Text), tbxUpdateName.Text, cbxCategory.SelectedItem.ToString(),
                   Convert.ToDecimal(tbxUpdatePrice.Text), tbxUpdateDim.Text);
                UpdateStockListbox();
                MessageBox.Show("Stock has been updated!");
                tbxUpdateArtNr.Text = string.Empty;
                tbxUpdateName.Text = string.Empty;
                tbxUpdatePrice.Text = string.Empty;
                tbxUpdateDim.Text = string.Empty;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Failed update a Stock!");
            }
        }

        private void lbxStock_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Good g = (Good)lbxStock.SelectedItem;
                tbxUpdateArtNr.Text = g.ArticleNumbers.ToString();
                tbxUpdateName.Text = g.ProductName;
                tbxUpdatePrice.Text = g.ProductPrice.ToString();
                cbxCategory.SelectedItem = g.Category;
                tbxUpdateDim.Text = g.PhysicalDimensions;
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Please select the Item!");
            }
        }
    }
}
