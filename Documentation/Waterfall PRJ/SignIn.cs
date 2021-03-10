using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Waterfall_PRJ
{
    class SignIn
    {
        private string usrName;
        private string pswd;
        private string signinType;

        public SignIn(string usrName, string pswd, string signinType)
        {
            this.usrName = usrName;
            this.pswd = pswd;
            this.signinType = signinType;
        }

        public bool GetIdentity()
        {
            if(this.signinType == "Administrator")
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory;
                string[] lines = System.IO.File.ReadAllLines(@path + "Database/Users/Admin/IdAndPass(Admin).txt");

                foreach(string line in lines)
                {
                    string[] steps = line.Split('#');
                    if (this.usrName == steps[0] && this.pswd == steps[1])
                    {
                        return true;
                    }
                }
            }
            else if(this.signinType == "Manager")
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory;
                string[] lines = System.IO.File.ReadAllLines(@path + "Database/Users/Manager/IdAndPass(Mgr).txt");

                foreach (string line in lines)
                {
                    string[] steps = line.Split('#');
                    if (this.usrName == steps[0] && this.pswd == steps[1])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
