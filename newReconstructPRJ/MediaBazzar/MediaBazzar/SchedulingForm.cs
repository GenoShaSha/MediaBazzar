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
    public partial class SchedulingForm : Form
    {
        public SchedulingForm()
        {
            InitializeComponent();
        }

        private void btnProdRequest_Click(object sender, EventArgs e)
        {
            ProductRequestFloorForm prf = new ProductRequestFloorForm();
            prf.Show();
            this.Hide();
        }
    }
}
