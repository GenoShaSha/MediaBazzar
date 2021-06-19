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
    public partial class UpdateProductPrice : Form
    {
        private Wrappers wrp;
        public UpdateProductPrice()
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
                wrp.PM.UpdateProductPrice(p, Convert.ToInt32(tbxUpdatePrice.Text));
                UpdateStockListbox();
            }
            catch
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AddRmvProductForm arp = new AddRmvProductForm();
            arp.Show();
            this.Hide();
        }
    }
}
