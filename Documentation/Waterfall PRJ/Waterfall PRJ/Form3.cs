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
    public partial class Form3 : Form
    {
        SignIn newSignIn;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string newUsr = tbUsrname.Text;
            string newPass = tbPswd.Text;
            string lgnType = string.Empty;

            if (rbAdmin.Checked == true)
            {
                lgnType = "Administrator";
            }
            else
            {
                lgnType = "Manager";
            }

            newSignIn = new SignIn(newUsr, newPass, lgnType);

            if (newSignIn.GetIdentity() == true)
            {
                if (rbAdmin.Checked)
                {
                    MessageBox.Show("Ur in to Admin page");
                }
                else if (rbMgr.Checked)
                {
                    MessageBox.Show("Ur in to Manager page");
                }

            }
            else if (newSignIn.GetIdentity() == false)
            {
                MessageBox.Show("Put the right username or password!");
            }
            tbUsrname.Text = string.Empty;
            tbPswd.Text = string.Empty;
        }
    }
}
