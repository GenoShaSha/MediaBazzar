using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace MediaBazzar
{
    class DbDiscontinuedProduct
    {
        private MySqlConnection con;
        public DbDiscontinuedProduct()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }

        public void AddDiscontinuedProduct(Product product)
        {
            try
            {
                string que = "INSERT INTO discontinuedgoods(articleNumbers,productName) VALUES (@artNumbs,@pName)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@artNumbs", product.ArticleNumbers);
                cmd.Parameters.AddWithValue("@pName", product.ProductName);

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

    }
}
