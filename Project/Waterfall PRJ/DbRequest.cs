using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Waterfall_PRJ
{
    class DbRequest
    {
        private MySqlConnection con;

        public DbRequest()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }


        public void AddRequest(Request request)
        {
            try
            {
                string que = "INSERT INTO stockrequest(goods_ID,Employee_ID,quantity) VALUES (@gID,@eID,@quantity)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@gID", request.GoodID);
                cmd.Parameters.AddWithValue("@eID", request.EmpID);
                cmd.Parameters.AddWithValue("@quantity", request.AmountRequest);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        public List<Request> ReadRequest()
        {
            List<Request> requests = new List<Request>();
            try
            {
                string que = "SELECT * FROM stockrequest ORDER BY goods_ID;";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                using (MySqlDataReader objReader = cmd.ExecuteReader())
                {
                    if (objReader.HasRows)
                    {
                        while (objReader.Read())
                        {
                            int goodID = (int)objReader["goods_ID"];
                            int empID = (int)objReader["Employee_ID"];
                            int quantity = (int)objReader["quantity"];

                            Request request = new Request(quantity, goodID,empID);
                            requests.Add(request);
                        }
                    }
                }
                con.Close();
                return requests;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return null;
        }
        public bool RemoveRequest(int id)
        {
            try
            {
                string que = "DELETE FROM stockrequest WHERE goods_ID = @gID";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@gID", id);

                cmd.ExecuteNonQuery();

                con.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return false;
        }
    }
}
