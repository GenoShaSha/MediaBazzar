using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace Waterfall_PRJ
{
    public class Login
    {
        private string username;
        private string password;
        private string loginType;
        private MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=mediabazaar;");

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
        public int ValidateAccount(string username, string password)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `accountId` FROM `users` WHERE `accountName` = @username AND `accountPassword` = @password", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            int id;

            if (cmd.ExecuteScalar() == null)
            {
                id = 0;
            }
            else
            {
                id = Convert.ToInt32(cmd.ExecuteScalar().ToString() == "" ? 0 : cmd.ExecuteScalar());
            }
            
            conn.Close();
            return id;
        }
        public bool RemoveUsers()
        {
            string paths = System.AppDomain.CurrentDomain.BaseDirectory;
            string databasePath;

            string cmdString = "DELETE FROM `users` WHERE `users`.`userName` = @username";

            MySqlCommand cmd = new MySqlCommand(cmdString, conn);
            cmd.Parameters.AddWithValue("@username", username);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

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

            string cmdString = "INSERT INTO `users`(`userId`, `userName`, `userPass`, `userCategory`)VALUES(NULL,@username,@password,@userCategory)";
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@userCategory", loginType);

            cmd.ExecuteNonQuery();
            conn.Close();

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

