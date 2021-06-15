using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazzar
{
    class DbProductRequestWarehouse
    {
        private MySqlConnection con;

        public DbProductRequestWarehouse()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }


        public void AddRequest(ProductRequestWarehouse request)
        {
            try
            {
                string que = "INSERT INTO stockrequest(goods_ID,Employee_ID,quantity) VALUES (@gID,@eID,@quantity)";
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
        public List<ProductRequestWarehouse> ReadRequest()
        {
            List<ProductRequestWarehouse> requests = new List<ProductRequestWarehouse>();
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
                            string location = objReader["location"].ToString();

                            ProductRequestWarehouse request = new ProductRequestWarehouse(quantity, goodID, empID);
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
        public bool RemoveRequest(ProductRequestWarehouse request)
        {
            try
            {
                string que = "DELETE FROM stockrequest WHERE goods_ID = @gID AND Employee_ID = @eID AND quantity = @amount";
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
