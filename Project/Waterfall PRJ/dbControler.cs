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
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }
        public bool GetIdentity(string username, string password/*, string type*/)
        {
            try
            {
                string que = "SELECT * FROM signin WHERE Username = @usrName AND Password = @password/*, EmployeeType = @eType*/;";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);
          
                /*con.Open();*/
                cmd.Parameters.AddWithValue("@usrName", username);
                cmd.Parameters.AddWithValue("@password", password);
/*                cmd.Parameters.AddWithValue("@eType", type);*/

                cmd.ExecuteReader();

                con.Close();
               /* Console.WriteLine(cmd.ExecuteNonQuery());*/
                return true;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
