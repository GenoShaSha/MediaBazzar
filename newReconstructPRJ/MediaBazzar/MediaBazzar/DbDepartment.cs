using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazzar
{
    class DbDepartment
    {
        private MySqlConnection con;

        public DbDepartment()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }
        public void AddDepartement(Department department)
        {
            try
            {
                string que = "INSERT INTO departments(departmentName) VALUES (@name)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@name", department.Name);
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
        public bool RemoveDepartment(int id)
        {
            try
            {
                string que = "DELETE FROM departments WHERE departmentID = @dID";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@dID", id);

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
        public List<Department> ReadDepartments()
        {
            List<Department> products = new List<Department>();
            try
            {
                string que = "SELECT * FROM departments ORDER BY departmentID;";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                using (MySqlDataReader objReader = cmd.ExecuteReader())
                {
                    if (objReader.HasRows)
                    {
                        while (objReader.Read())
                        {
                            int departmentID = (int)objReader["departmentID"];
                            string name = objReader["departmentName"].ToString();

                            Department department = new Department(departmentID , name);
                            products.Add(department);
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
        public bool UpdateDepartment(Department department)
        {
            try
            {
                string que = "UPDATE departments SET departmentName= @name WHERE departmentID= @dID";

                MySqlCommand cmd = new MySqlCommand(que, con);
                con.Open();

                cmd.Parameters.AddWithValue("@dID", department.ID);
                cmd.Parameters.AddWithValue("@name", department.Name);

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
