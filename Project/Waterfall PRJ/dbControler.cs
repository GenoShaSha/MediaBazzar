using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Waterfall_PRJ
{
    public class dbControler
    {
        private MySqlConnection con;

        public dbControler()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local; Username=dbi450080;Database=dbi450080; Password=WortelSoulution");
        }
        public bool GetIdentity(string username, string password)
        {
            try
            {
                string que = "SELECT * from 'signin' WHERE 'Username' = @usrName AND 'Password'= @password";
                MySqlCommand cmd = new MySqlCommand(que, con);
          
                con.Open();
                cmd.Parameters.AddWithValue("@usrName", username);
                cmd.Parameters.AddWithValue("@password", password);

                cmd.ExecuteNonQuery();

                con.Close();
                Console.WriteLine(cmd.ExecuteNonQuery());
                return true;
            }
            catch(Exception ex)
            {
            }
            return false;
        }
    }
}
