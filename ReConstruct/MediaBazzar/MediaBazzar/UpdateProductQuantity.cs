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
    public partial class UpdateProductQuantity : Form
    {
        private Wrappers wrp;
        public UpdateProductQuantity()
        {
            InitializeComponent();
            wrp = new Wrappers();
            UpdateStockListbox();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product p = (Product)lbxStock.SelectedItem;
            try
            {
                wrp.PM.UpdateWarehouseProductQuantity(p, p.Quantity + Convert.ToInt32(tbxUpdateQuantity.Text));
                UpdateStockListbox();
            }
            catch
            {

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
