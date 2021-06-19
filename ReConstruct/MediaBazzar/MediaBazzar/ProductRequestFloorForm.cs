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
    public partial class ProductRequestFloorForm : Form
    {
        private int user_id;
        private Wrappers wrp;
        private ProductManagement pm;

        public ProductRequestFloorForm()
        {
            InitializeComponent();
            wrp = new Wrappers();
            pm = new ProductManagement();
        }
        public ProductRequestFloorForm(int user_id)
        {
            InitializeComponent();
            pm = new ProductManagement();
            wrp = new Wrappers();
            this.user_id = user_id;
            EmployeeIDOutLbl.Text = user_id.ToString();
            UpdateStockListbox();
        }
        public void UpdateStockListbox()
        {
            StockRequestLB.Items.Clear();
            StockRequestLB.HorizontalScrollbar = true;
            List<Product> productList = pm.GetListProduct();
            foreach (var item in productList)
            {
                if (item != null)
                {
                    StockRequestLB.Items.Add(item);
                }
            }
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Product selectedProduct = (Product)StockRequestLB.SelectedItem;
                wrp.PRM.AddRequest(new ProductRequest(Convert.ToInt32(AmountTb.Text), selectedProduct.ID, Convert.ToInt32(EmployeeIDOutLbl.Text),"Floor"));
                MessageBox.Show("The stock has been requested!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
