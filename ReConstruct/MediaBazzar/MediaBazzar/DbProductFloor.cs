using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazzar
{
    public class DbProductFloor
    {
        private MySqlConnection con;
        public DbProductFloor()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }
        public void AddProduct(Product product)
        {
            try
            {
                string que = "INSERT INTO goodsshop(articleNumbers,productName,category,productPrice,physicalDimensions,quantity) VALUES (@artNumbs,@pName,@category,@pPrice,@pDimensions,@quantity)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@artNumbs", product.ArticleNumbers);
                cmd.Parameters.AddWithValue("@pName", product.ProductName);
                cmd.Parameters.AddWithValue("@category", product.Category);
                cmd.Parameters.AddWithValue("@pPrice", product.ProductPrice);
                cmd.Parameters.AddWithValue("@pDimensions", product.PhysicalDimensions);
                cmd.Parameters.AddWithValue("@quantity", product.Quantity);

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
        public void AddDiscontinuedProduct(Product product)
        {
            try
            {
                string que = "INSERT INTO goodsshop(articleNumbers,productName) VALUES (@artNumbs,@pName)";
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
        public bool RemoveProduct(int id)
        {
            try
            {
                string que = "DELETE FROM goodsshop WHERE goods_ID = @gID";
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
        public Product ReturnProductByID(int id)
        {
            try
            {
                Product product;
                string que = "SELECT * FROM goodsshop WHERE goods_ID = @gID";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);
                cmd.Parameters.AddWithValue("@gID", id);
                using (MySqlDataReader objReader = cmd.ExecuteReader())
                {
                    if (objReader.HasRows)
                    {
                        while (objReader.Read())
                        {
                            int productID = (int)objReader["goods_ID"];
                            int articleNumbs = (int)objReader["articleNumbers"];
                            string productName = objReader["productName"].ToString();
                            string category = objReader["category"].ToString();
                            decimal productPrice = (decimal)objReader["productPrice"];
                            string physicalDimension = objReader["physicalDimensions"].ToString();
                            int quantity = (int)objReader["quantity"];

                            product = new Product(productID, articleNumbs, productName, category, productPrice, physicalDimension, quantity);
                            return product;
                        }
                    }
                    con.Close();
                }

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
        public List<Product> ReadProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                string que = "SELECT * FROM goodsshop ORDER BY goods_ID;";
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
                            int quantity = (int)objReader["quantity"];

                            Product product = new Product(goodID, articleNumbs, productName, category, productPrice, physicalDimension, quantity);
                            products.Add(product);
                        }
                    }
                }
                con.Close();
                return products;
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
        public bool UpdateProduct(Product product)
        {
            try
            {
                string que = "UPDATE goodsshop SET articleNumbers= @artNumbs, productName= @pName, category= @category, productPrice= @pPrice, physicalDimensions= @pDimensions, quantity = @quantity WHERE goods_ID= @gID";

                MySqlCommand cmd = new MySqlCommand(que, con);
                con.Open();

                cmd.Parameters.AddWithValue("@gID", product.ID);
                cmd.Parameters.AddWithValue("@artNumbs", product.ArticleNumbers);
                cmd.Parameters.AddWithValue("@pName", product.ProductName);
                cmd.Parameters.AddWithValue("@category", product.Category);
                cmd.Parameters.AddWithValue("@pPrice", product.ProductPrice);
                cmd.Parameters.AddWithValue("@pDimensions", product.PhysicalDimensions);
                cmd.Parameters.AddWithValue("@quantity", product.Quantity);

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
