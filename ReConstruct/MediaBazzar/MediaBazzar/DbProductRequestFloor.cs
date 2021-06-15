using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace MediaBazzar
{
    class DbProductRequestFloor
    {
        private MySqlConnection con;

        public DbProductRequestFloor()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }


        public void AddRequest(ProductRequestFloor request)
        {
            try
            {
                string que = "INSERT INTO stockrequestfloor(goods_ID,Employee_ID,quantity) VALUES (@gID,@eID,@quantity)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@gID", request.ProductID);
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
        public List<ProductRequestFloor> ReadRequest()
        {
            List<ProductRequestFloor> requests = new List<ProductRequestFloor>();
            try
            {
                string que = "SELECT * FROM stockrequestfloor ORDER BY goods_ID;";
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
 
                            ProductRequestFloor request = new ProductRequestFloor(quantity, goodID, empID);
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
        public bool RemoveRequest(ProductRequestFloor request)
        {
            try
            {
                string que = "DELETE FROM stockrequestfloor WHERE goods_ID = @gID AND Employee_ID = @eID AND quantity = @amount";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@gID", request.ProductID);
                cmd.Parameters.AddWithValue("@eID", request.EmpID);
                cmd.Parameters.AddWithValue("@amount", request.AmountRequest);

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
