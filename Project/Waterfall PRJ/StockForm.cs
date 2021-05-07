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
        private dbGoods dg;
        private GoodManagement gm;
        public StockForm()
        {
            InitializeComponent();
            dg = new dbGoods();
            gm = new GoodManagement();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            try
            {
                int newID = Convert.ToInt32(tbxRmvID.Text);
                gm.RemoveProduct(newID);
                MessageBox.Show("Stock has been removed!");
            }
            catch
            {

            }
        }
    }
}
