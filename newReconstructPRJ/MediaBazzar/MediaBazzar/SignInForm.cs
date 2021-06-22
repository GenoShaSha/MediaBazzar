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
    public partial class SignInForm : Form
    {
        DbEmployee dc;

        public SignInForm()
        {
            InitializeComponent();
            dc = new DbEmployee();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string newUsr = tbxUsername.Text;
            string newPass = tbxPassword.Text;
            string type;
            int id;

            dc = new DbEmployee();
            if (dc.GetIdentity(newUsr, newPass, out type, out id))
            {
                if (type == "Administrator")
                {
                    MessageBox.Show("Ur in to Admin form!");
                    UpdateEmployeeForm uef = new UpdateEmployeeForm();
                    uef.Show();
                    this.Hide();
                }
                else if (type == "Floor Manager")
                {
                    MessageBox.Show("Ur in to Floor Manager form!");
                    SchedulingForm sf = new SchedulingForm();
                    sf.Show();
                    this.Hide();
                }
                else if (type == "Warehouse Manager")
                {
                    MessageBox.Show("Ur in to Warehouse Manager form!");
                    AddRmvProductForm arp = new AddRmvProductForm();
                    arp.Show();
                    this.Hide();
                }
                else if (type == "Warehouse Staff")
                {
                    MessageBox.Show("Ur in to Warehouse Staff form!");
                    RestockFloorProductManagementForm rfp = new RestockFloorProductManagementForm();
                    rfp.Show();
                    this.Hide();
                }
                else if (type == null)
                {
                    MessageBox.Show("User type not defined");
                }
            }
            else
            {
                MessageBox.Show("Put the right username or password!");
            }
            tbxUsername.Text = string.Empty;
            tbxPassword.Text = string.Empty;
        }
    }
}
