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
            con = new MySqlConnection("Server=studmysql01.fhict.local; Uid=dbi450080;Database=dbi450080;Pwd=WortelSoulution");
        }
        public void GetUsers(Person person)
        {
            string que = "SELECT * from 'signin' WHERE 'signin'.'Username' = @usrName AND 'signin'.'Password'= @password";
            MySqlCommand cmd = new MySqlCommand(que, con);
            con.Open();
            cmd.Parameters.AddWithValue("@usrName", person.Email);
            cmd.Parameters.AddWithValue("@password", person.Password);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
