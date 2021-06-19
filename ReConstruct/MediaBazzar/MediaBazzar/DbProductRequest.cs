using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazzar
{
    class DbProductRequest
    {
        private MySqlConnection con;

        public DbProductRequest()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }


        public void AddRequest(ProductRequest request)
        {
            try
            {
                string que = "INSERT INTO stockrequest(goods_ID,Employee_ID,quantity,location) VALUES (@gID,@eID,@quantity,@location)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@gID", request.ProductID);
                cmd.Parameters.AddWithValue("@eID", request.EmpID);
                cmd.Parameters.AddWithValue("@quantity", request.AmountRequest);
                if(request.Location == "Warehouse")
                {
                    cmd.Parameters.AddWithValue("@location", "Warehouse");
                }
                else if(request.Location == "Floor")
                {
                    cmd.Parameters.AddWithValue("@location", "Floor");
                }

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
        public List<ProductRequest> ReadRequest()
        {
            List<ProductRequest> requests = new List<ProductRequest>();
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

                            ProductRequest request = new ProductRequest(quantity, goodID, empID, location);
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

        public bool RemoveRequest(ProductRequest request)
        {
            try
            {
                string que = "DELETE FROM stockrequest WHERE goods_ID = @gID AND Employee_ID = @eID AND quantity = @amount AND location = @location";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@gID", request.ProductID);
                cmd.Parameters.AddWithValue("@eID", request.EmpID);
                cmd.Parameters.AddWithValue("@amount", request.AmountRequest);
                if (request.Location == "Warehouse")
                {
                    cmd.Parameters.AddWithValue("@location", "Warehouse");
                }
                else if (request.Location == "Floor")
                {
                    cmd.Parameters.AddWithValue("@location", "Floor");
                }

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
