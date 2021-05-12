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
        private RequestManagement rm;
        private MedBazzar mb;
        public StockForm()
        {
            InitializeComponent();
            dg = new DbGoods();
            gm = new GoodManagement();
            rm = new RequestManagement();
            mb = new MedBazzar();
            UpdateStockListbox();
            UpdateRequestStockListbox();
            DialogResult notification = MessageBox.Show($"You have {lbxRequestStock.Items.Count} pending requests!");
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
        public void UpdateRequestStockListbox()
        {
            lbxRequestStock.Items.Clear();
            lbxRequestStock.HorizontalScrollbar = true;
            List<Request> requestList = rm.GetRequest();
            foreach (var item in requestList)
            {
                if (item != null)
                {
                    lbxRequestStock.Items.Add(item);
                }
            }
        }
        public void UpdateStockListboxCategory(string category)
        {
            lbxStock.Items.Clear();
            lbxStock.HorizontalScrollbar = true;
            List<Good> goodList = gm.GetProducts();
            foreach (var item in goodList)
            {
                if (item != null)
                {
                    if (((Good)item).Category == category)
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
                mb.AddGood(Convert.ToInt32(tbxArtNumb.Text), tbxProductName.Text, cbxCategory.SelectedItem.ToString(), Convert.ToDecimal(tbxProductPrice.Text), tbxDimention.Text, Convert.ToInt32(tbxQuantity.Text));
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
                   Convert.ToDecimal(tbxUpdatePrice.Text), tbxUpdateDim.Text,Convert.ToInt32(tbxUpdateQuantity.Text));
                UpdateStockListbox();
                MessageBox.Show("Stock has been updated!");
                tbxUpdateArtNr.Text = string.Empty;
                tbxUpdateName.Text = string.Empty;
                tbxUpdatePrice.Text = string.Empty;
                tbxUpdateDim.Text = string.Empty;
                tbxUpdateQuantity.Text = string.Empty;
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
                lbxRequestStock.SelectedIndex = -1;
                Good g = (Good)lbxStock.SelectedItem;
                tbxUpdateArtNr.Text = g.ArticleNumbers.ToString();
                tbxUpdateName.Text = g.ProductName;
                tbxUpdatePrice.Text = g.ProductPrice.ToString();
                cbxCategory.SelectedItem = g.Category;
                tbxUpdateDim.Text = g.PhysicalDimensions;
                tbxUpdateQuantity.Text = g.Quantity.ToString();
                tbxRmvID.Text = g.ID.ToString();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Please select the Item!");
            }
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CategoryCB.SelectedIndex == 0)
            {
                UpdateStockListbox();
            }
            else if(CategoryCB.SelectedIndex ==1)
            {
                UpdateStockListboxCategory("Household");
            }
            else if (CategoryCB.SelectedIndex == 2)
            {
                UpdateStockListboxCategory("Computer & Electronics");
            }
            else if (CategoryCB.SelectedIndex == 3)
            {
                UpdateStockListboxCategory("Kitchen");
            }
            else
            {
                UpdateStockListbox();
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            if(tbxUpdateQuantity.Text != string.Empty)
            {
                int quantity = Convert.ToInt32(tbxUpdateQuantity.Text);
                quantity++;
                tbxUpdateQuantity.Text = quantity.ToString();
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (tbxUpdateQuantity.Text != string.Empty)
            {
                int quantity = Convert.ToInt32(tbxUpdateQuantity.Text);
                quantity--;
                tbxUpdateQuantity.Text = quantity.ToString();
            }
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            try
            {
                Request r = (Request)lbxRequestStock.SelectedItem;
                Good g = gm.ReturnGoodByID(r.GoodID);
                if(r.AmountRequest <= g.Quantity)
                {
                    mb.UpdateStock(g, g.ArticleNumbers, g.ProductName, g.Category, g.ProductPrice, g.PhysicalDimensions, (g.Quantity - r.AmountRequest));
                    MessageBox.Show("The request has been approved!");
                    rm.RemoveRequest(r);
                    UpdateRequestStockListbox();
                    UpdateStockListbox();
                }
                else if (r.AmountRequest > g.Quantity)
                {
                    MessageBox.Show("The request cannot be completed!(Not enough stock in warehouse.)");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a request");
            }
        }

        private void btnDisapproved_Click(object sender, EventArgs e)
        {
            try
            {
                Request r = (Request)lbxRequestStock.SelectedItem;
                MessageBox.Show("The request has been disapproved!");
                rm.RemoveRequest(r);
                UpdateRequestStockListbox();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Please select a request");
            }
            
            

        }

        private void StockIdSearchTB_TextChanged(object sender, EventArgs e)
        {
            lbxStock.Items.Clear();
            List<Good> goodList = gm.GetProducts();
            if (StockIdSearchTB.Text != string.Empty)
            {
                foreach(var item in goodList)
                {
                    if(Convert.ToInt32(StockIdSearchTB.Text) == ((Good)item).ID)
                    {
                        lbxStock.Items.Add(item);
                    }
                }
            }
            if(StockIdSearchTB.Text == string.Empty)
            {
                CategoryCB.SelectedIndex = 0;
                UpdateStockListbox();
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            lbxStock.SelectedIndex = -1;
            lbxRequestStock.SelectedIndex = -1;
            tbxUpdateArtNr.Text = string.Empty;
            tbxUpdateName.Text = string.Empty;
            tbxUpdatePrice.Text = string.Empty;
            tbxUpdateDim.Text = string.Empty;
            tbxUpdateQuantity.Text = string.Empty;
        }

        private void lbxRequestStock_Click(object sender, EventArgs e)
        {
            lbxStock.SelectedIndex = -1;
            tbxUpdateArtNr.Text = string.Empty;
            tbxUpdateName.Text = string.Empty;
            tbxUpdatePrice.Text = string.Empty;
            tbxUpdateDim.Text = string.Empty;
            tbxUpdateQuantity.Text = string.Empty;
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }
    }
}
