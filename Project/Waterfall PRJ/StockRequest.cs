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
    public partial class StockRequest : Form
    {
        private GoodManagement gm;
        private MedBazzar mb;
        private Good g;
        public StockRequest()
        {
            InitializeComponent();
            gm = new GoodManagement();
            mb = new MedBazzar();
            UpdateStockListbox();
        }
        public void UpdateStockListbox()
        {
            lbxStockWarehouse.Items.Clear();
            lbxStockWarehouse.HorizontalScrollbar = true;
            List<Good> goodList = gm.GetProducts();
            foreach (var item in goodList)
            {
                if (item != null)
                {
                    lbxStockWarehouse.Items.Add(item);
                }
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            mb.AddRequest(Convert.ToInt32(tbxAmount.Text), Convert.ToInt32(tbxGID.Text), Convert.ToInt32(tbxEmpId.Text));
            MessageBox.Show("The stock has been requested!");
        }

    }
}
