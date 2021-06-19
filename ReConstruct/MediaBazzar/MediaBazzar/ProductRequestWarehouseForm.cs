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
    public partial class ProductRequestWarehouseForm : Form
    {
        private int user_id;
        private Wrappers wrp;
        private ProductManagement pm;
        public ProductRequestWarehouseForm()
        {
            InitializeComponent();
            pm = new ProductManagement();
            wrp = new Wrappers();
            EmployeeIDOutLbl.Text = user_id.ToString();
            UpdateStockListbox();
        }
        public ProductRequestWarehouseForm(int user_id)
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
            List<Object> productList = wrp.PM.GetListObj();
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
                wrp.PRM.AddRequest(new ProductRequest(Convert.ToInt32(AmountTb.Text), selectedProduct.ID, Convert.ToInt32(EmployeeIDOutLbl.Text), "Warehouse"));
                MessageBox.Show("The stock has been requested!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RestockFloorProductManagementForm rfm = new RestockFloorProductManagementForm();
            rfm.Show();
            this.Hide();
        }
    }
}
