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
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                mb.AddGood(Convert.ToInt32(tbxArtNumb.Text), tbxProductName.Text, cbxCategory.SelectedItem.ToString(), Convert.ToDouble(tbxProductPrice.Text), tbxDimention.Text);
                tbxArtNumb.Text = string.Empty;
                tbxProductName.Text = string.Empty;
                tbxProductPrice.Text = string.Empty;
                tbxDimention.Text = string.Empty;
            }
            catch
            {

            }
        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            try
            {
                int newID = Convert.ToInt32(tbxRmvID.Text);
                mb.RemoveGood(newID);
                MessageBox.Show("Stock has been removed!");
            }
            catch
            {

            }
        }
    }
}
