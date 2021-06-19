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
    public partial class RestockWarehouseProductManagementForm : Form
    {
        private Wrappers wrp;
        public RestockWarehouseProductManagementForm()
        {
            InitializeComponent();
            wrp = new Wrappers();
            UpdateRequestStockListbox();
        }
        public void UpdateRequestStockListbox()
        {
            lbxRequestStock.Items.Clear();
            lbxRequestStock.HorizontalScrollbar = true;
            List<ProductRequest> requestList = wrp.PRM.GetRequest();
            foreach (var item in requestList)
            {
                if (item != null)
                {
                    if (item.Location == "Warehouse")
                    {
                        lbxRequestStock.Items.Add(item);
                    }
                }
            }
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            ProductRequest r = (ProductRequest)lbxRequestStock.SelectedItem;
            wrp.PRM.RemoveRequest(r);
            MessageBox.Show("Request product has been sent to the supplier!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AddRmvProductForm arp = new AddRmvProductForm();
            arp.Show();
            this.Hide();
        }
    }
}
