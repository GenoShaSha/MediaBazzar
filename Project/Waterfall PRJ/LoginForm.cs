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
        Login newLogin;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newUsr = tbUsername.Text;
            string newPass = tbPassword.Text;
            string lgnType = string.Empty;

            if (rbAdmin.Checked == true)
            {
                lgnType = "Administrator";
            }
            else
            {
                lgnType = "Manager";
            }

            newLogin = new Login(newUsr, newPass, lgnType);

            if (newLogin.GetIdentity() == true)
            {
                if (rbAdmin.Checked)
                {
                    MessageBox.Show("Ur in to Admin page");
                    ManagementForm mf = new ManagementForm();
                    mf.Show();
                    this.Hide();
                }
                else if (rbManager.Checked)
                {
                    MessageBox.Show("Ur in to Manager page");
                    ManagementForm mf = new ManagementForm();
                    mf.Show();
                    this.Hide();
                }

            }
            else if (newLogin.GetIdentity() == false)
            {
                MessageBox.Show("Put the right username or password!");
            }
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
        }
    }
    }

