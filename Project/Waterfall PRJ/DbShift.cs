using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Waterfall_PRJ
{
    public class DbShift
    {
        private MySqlConnection con;

        public DbShift()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }
        public void AddShift(Shift shift)
        {
            try
            {
                string query = "INSERT INTO shifts (date,type) VALUES (@date,@type)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@date", shift.ShiftDate);
                cmd.Parameters.AddWithValue("@type", shift.Type.ToString());

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }
        }

    }

  
}
