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
    public partial class RestockFloorProductManagementForm : Form
    {
        private Wrappers wrp;
        public RestockFloorProductManagementForm()
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
                    if(item.Location == "Floor")
                    {
                        lbxRequestStock.Items.Add(item);
                    }
                }
            }
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            try
            {
                ProductRequest r = (ProductRequest)lbxRequestStock.SelectedItem;
                if(r != null)
                {
                    Product pw = wrp.PM.ReturnProductWarehouseByID(r.ProductID);
                    Product pf = wrp.PM.ReturnProductFloorByID(r.ProductID);
                    if (r.AmountRequest <= pw.Quantity)
                    {
                        wrp.PM.UpdateFloorProductQuantity(pf, (pf.Quantity + r.AmountRequest));
                        wrp.PM.UpdateWarehouseProductQuantity(pw, (pw.Quantity - r.AmountRequest));
                        MessageBox.Show("The request has been approved!");
                        wrp.PRM.RemoveRequest(r);
                        UpdateRequestStockListbox();
                    }
                    else if (r.AmountRequest > pw.Quantity)
                    {
                        MessageBox.Show("The request cannot be completed!(Not enough stock in warehouse.)");
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a request");
            }
        }

        private void btnUpdateProd_Click(object sender, EventArgs e)
        {
            UpdateProductQuantity upq = new UpdateProductQuantity();
            upq.Show();
            this.Hide();
        }

        private void btnWarehouseRequest_Click(object sender, EventArgs e)
        {
            ProductRequestWarehouseForm prw = new ProductRequestWarehouseForm();
            prw.Show();
            this.Hide();
        }

        private void btnAddNewProd_Click(object sender, EventArgs e)
        {
            AddProductToFloor apf = new AddProductToFloor();
            apf.Show();
            this.Hide();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            SignInForm sf = new SignInForm();
            sf.Show();
            this.Hide();
        }
    }
}
