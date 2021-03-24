using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Waterfall_PRJ
{
    public class Login
    {
         
        private string username;
        private string password;
        private string loginType;

        public Login(string username, string password, string loginType)
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
        public bool RemoveUsers()
        {
            string paths = System.AppDomain.CurrentDomain.BaseDirectory;
            string databasePath;

            if (this.loginType == "Manager")
            {
                databasePath = "Database/Users/Manager/IdAndPass(Mgr).txt";
            }
            else
            {
                databasePath = "Database/Users/Admin/IdAndPass(Admin).txt";
            }

            string[] lines = System.IO.File.ReadAllLines(@paths + databasePath);

            var lineToList = lines.ToList();
            string flag = "DontRemove";

            for (int i = lineToList.Count - 1; i > -1; i--)
            {
                string[] line = lineToList[i].Split('#');
                if (line[0] == this.username)
                {
                    lineToList.RemoveAt(i);
                    flag = "Remove";
                    break;
                }
            }
            if (flag == "Remove")
            {
                using (StreamWriter writer = new StreamWriter(@paths + databasePath))
                {
                    int counter = 0;
                    foreach (string s in lineToList)
                    {
                        counter++;
                        if (counter == lineToList.Count())
                        {
                            writer.Write(s);
                        }
                        else
                        {
                            writer.WriteLine(s);
                        }
                        Console.WriteLine(s);
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddUsers()
        {
            string paths = System.AppDomain.CurrentDomain.BaseDirectory;
            string databasePath;

            if (this.loginType == "Manager")
            {
                databasePath = "Database/Users/Manager/IdAndPass(Mgr).txt";
            }
            else
            {
                databasePath = "Database/Users/Admin/IdAndPass(Admin).txt";
            }

            string[] lines = System.IO.File.ReadAllLines(@paths + databasePath);

            var lineToList = lines.ToList();
            string flag = "Add";

            foreach (string s in lineToList)
            {
                string[] line = s.Split('#');

                if (line[0] == this.username)
                {
                    flag = "Reject";
                    break;
                }
            }

            if (flag == "Add")
            {
                string formattedUsers = this.username + "#" + this.password;

                lineToList.Add(formattedUsers);

                using (StreamWriter writer = new StreamWriter(@paths + databasePath))
                {
                    int counter = 0;
                    foreach (string s in lineToList)
                    {
                        counter++;
                        if (counter == lineToList.Count())
                        {
                            writer.Write(s);
                        }
                        else
                        {
                            writer.WriteLine(s);
                        }
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

