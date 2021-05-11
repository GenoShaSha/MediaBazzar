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
    public partial class StockRequests : Form
    {
        private int user_id;
        private GoodManagement gm;
        private MedBazzar mb;
        public StockRequests()
        {
            InitializeComponent();
            gm = new GoodManagement();
            mb = new MedBazzar();
            UpdateStockListbox();
        }
        public StockRequests(int user_id)
        {
            InitializeComponent();
            gm = new GoodManagement();
            mb = new MedBazzar();
            this.user_id = user_id;
            EmployeeIDOutLbl.Text = user_id.ToString();
            UpdateStockListbox();
        }
        public void UpdateStockListbox()
        {
            StockRequestLB.Items.Clear();
            StockRequestLB.HorizontalScrollbar = true;
            List<Good> goodList = gm.GetProducts();
            foreach (var item in goodList)
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
                Good selectedGood = (Good)StockRequestLB.SelectedItem;
                mb.AddRequest(Convert.ToInt32(AmountTb.Text), selectedGood.ID, Convert.ToInt32(EmployeeIDOutLbl.Text));
                MessageBox.Show("The stock has been requested!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
