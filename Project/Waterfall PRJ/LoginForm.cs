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
    public partial class LoginForm : Form
    {
        /*Login newLogin;*/
        DbEmployees dc;
        public LoginForm()
        {
            InitializeComponent();
            dc = new DbEmployees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newUsr = tbUsername.Text;
            string newPass = tbPassword.Text;
            string type;
            int id;

            /*            string lgnType = string.Empty;*/
            dc = new DbEmployees();
            if (dc.GetIdentity(newUsr, newPass, out type, out id))
            {
                if (type == "Administrator")
                {
                    MessageBox.Show("Ur in to Admin form!");
                    ManagementForm mf = new ManagementForm();
                    mf.Show();
                    this.Hide();
                }
                else if (type == "Floor Manager")
                {
                    MessageBox.Show("Ur in to Management form!");
                    ManagementForm mf = new ManagementForm(id);
                    mf.Show();
                    this.Hide();
                }
                else if (type == "Warehouse Manager")
                {
                    MessageBox.Show("Ur in to Warehouse form!");
                    StockForm sf = new StockForm();
                    sf.Show();
                    this.Hide();
                } 
                else if (type == "Warehouse Staff")
                {
                    MessageBox.Show("Ur in to Stock Request form!");
                    StockRequests srw = new StockRequests(id);
                    srw.Show();
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
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
        }
    }
    }

