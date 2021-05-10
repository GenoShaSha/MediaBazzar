using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Waterfall_PRJ
{
    class DbGoods
    {
        private MySqlConnection con;

        public DbGoods()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }

        public void AddGood(Good good)
        {
            try
            {
                string que = "INSERT INTO goods(articleNumbers,productName,category,productPrice,physicalDimensions) VALUES (@artNumbs,@pName,@category,@pPrice,@pDimensions)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@artNumbs", good.ArticleNumbers);
                cmd.Parameters.AddWithValue("@pName", good.ProductName);
                cmd.Parameters.AddWithValue("@category", good.Category);
                cmd.Parameters.AddWithValue("@pPrice", good.ProductPrice);
                cmd.Parameters.AddWithValue("@pDimensions", good.PhysicalDimensions);

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
        public bool RemoveGood(int id)
        {
            try
            {
                string que = "DELETE FROM goods WHERE goods_ID = @gID";
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
        public List<Good> ReadGoods()
        {
            List<Good> goods = new List<Good>();
            try
            {
                string que = "SELECT * FROM goods ORDER BY goods_ID;";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                using (MySqlDataReader objReader = cmd.ExecuteReader())
                {
                    if (objReader.HasRows)
                    {
                        while (objReader.Read())
                        {
                            int goodID = (int)objReader["goods_ID"];
                            int articleNumbs = (int)objReader["articleNumbers"];
                            string productName = objReader["productName"].ToString();
                            string category = objReader["category"].ToString();
                            decimal productPrice = (decimal)objReader["productPrice"];
                            string physicalDimension = objReader["physicalDimensions"].ToString();

                            Good good = new Good(goodID, articleNumbs, productName, category, productPrice, physicalDimension);
                            goods.Add(good);
                        }
                    }
                }
                con.Close();
                return goods;
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
        public bool UpdateGood(Good good)
        {
            try
            {
                string que = "UPDATE goods SET articleNumbers= @artNumbs, productName= @pName, category= @category, productPrice= @pPrice, physicalDimensions= @pDimensions WHERE goods_ID= @gID";

                MySqlCommand cmd = new MySqlCommand(que, con);
                con.Open();

                cmd.Parameters.AddWithValue("@gID", good.ID);
                cmd.Parameters.AddWithValue("@artNumbs", good.ArticleNumbers);
                cmd.Parameters.AddWithValue("@pName", good.ProductName);
                cmd.Parameters.AddWithValue("@category", good.Category);
                cmd.Parameters.AddWithValue("@pPrice", good.ProductPrice);
                cmd.Parameters.AddWithValue("@pDimensions", good.PhysicalDimensions);

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
            return false;
        }

    }
}
