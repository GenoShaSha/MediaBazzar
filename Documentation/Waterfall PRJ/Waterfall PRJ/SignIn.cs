using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Waterfall_PRJ
{
    public class SignIn
    {
        private string username;
        private string password;
        private string loginType;

        public SignIn(string username, string password, string loginType)
        {
            this.username = username;
            this.password = password;
            this.loginType = loginType;
        }

        public bool GetIdentity()
        {
            if (this.loginType == "Manager")
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory;
                string[] lines = System.IO.File.ReadAllLines(@path + "Database/Users/Manager/IdAndPass(Mgr).txt");

                foreach (string line in lines)
                {
                    string[] steps = line.Split('#');
                    if (this.username == steps[0] && this.password == steps[1])
                    {
                        return true;
                    }
                }
            }
            else if (this.loginType == "Administrator")
            {
                string paths = System.AppDomain.CurrentDomain.BaseDirectory;
                string[] ndLines = System.IO.File.ReadAllLines(@paths + "Database/Users/Admin/IdAndPass(Admin).txt");

                foreach (string line in ndLines)
                {
                    string[] step = line.Split('#');
                    if (this.username == step[0] && this.password == step[1])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
