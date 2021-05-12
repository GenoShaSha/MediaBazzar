using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Waterfall_PRJ
{
    public class DbEmployees
    {
        private MySqlConnection con;

        public DbEmployees()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }

        public void AddEmployees(Employee person)
        {
            try
            {
                string que = "INSERT INTO employees(FirstName,LastName,DateOfBirth,BSN,Gender,Relationship,Email,Password,PhoneNumber,Address,PostalCode,City,Country,EmployeeType,ContractType) VALUES (@fName,@lName,@dob,@bsn,@gender,@relationship,@email,@pswd,@pNumber,@address,@pCode,@city,@country,@role,@cType)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@fName", person.FirstName);
                cmd.Parameters.AddWithValue("@lName", person.LastName);
                cmd.Parameters.AddWithValue("@dob", person.Birthdate);
                cmd.Parameters.AddWithValue("@bsn", person.BSN_Num);
                cmd.Parameters.AddWithValue("@gender", person.Gender);
                cmd.Parameters.AddWithValue("@relationship", person.Relationship);
                cmd.Parameters.AddWithValue("@email", person.Email);
                cmd.Parameters.AddWithValue("@pswd", person.Password);
                cmd.Parameters.AddWithValue("@pNumber", person.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", person.Address);
                cmd.Parameters.AddWithValue("@pCode", person.Postal);
                cmd.Parameters.AddWithValue("@city", person.City);
                cmd.Parameters.AddWithValue("@country", person.Country);
                if (person is FloorStaff)
                {
                    person.Status = "Floor Staff";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType", ((FloorStaff)person).Contract);
                }
                else if (person is FloorManager)
                {
                    person.Status = "Floor Manager";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType","full");
                }
                else if (person is WarehouseStaff)
                {
                    person.Status = "Warehouse Staff";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType", ((WarehouseStaff)person).Contract);
                }
                else if (person is WarehouseManager)
                {
                    person.Status = "Warehouse Manager";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType", "full");
                }
                else if (person is Administrator)
                {
                    person.Status = "Admininstrator";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType", "full");
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
        public bool RemoveEmployees(long id)
        {
            try
            {
                string que = "DELETE FROM employees WHERE Employee_ID = @eID";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@eID", id);

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
        public List<Employee> ReadEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                string que = "SELECT * FROM employees ORDER BY Employee_ID;";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                using (MySqlDataReader objReader = cmd.ExecuteReader())
                {
                    if (objReader.HasRows)
                    {
                        while (objReader.Read())
                        {
                            int empID = (int)objReader["Employee_ID"];
                            string FirstName = objReader["FirstName"].ToString();
                            string LastName = objReader["LastName"].ToString();
                            DateTime DateOfBirth = (DateTime)objReader["DateOfBirth"];
                            string BSN = objReader["BSN"].ToString();
                            string Gender = objReader["Gender"].ToString();
                            string Relationship = objReader["Relationship"].ToString();
                            string Email = objReader["Email"].ToString();
                            string Password = objReader["Password"].ToString();
                            string PhoneNumber = objReader["PhoneNumber"].ToString();
                            string Address = objReader["Address"].ToString();
                            string PostalCode = objReader["PostalCode"].ToString();
                            string City = objReader["City"].ToString();
                            string Country = objReader["Country"].ToString();
                            string EmployeeType = objReader["EmployeeType"].ToString();
                            //int WorkHours = (int)objReader["WorkHours"];
                            string ContractType = objReader["ContractType"].ToString();

                            Employee person = null;
                            if(EmployeeType == "Administrator")
                            {
                                person = new Administrator(empID, FirstName, LastName, Gender, DateOfBirth, BSN, Relationship, Email, Password, PhoneNumber, Address, PostalCode, City, Country);
                            }
                            else if(EmployeeType == "Floor Manager")
                            {
                                person = new FloorManager(empID, FirstName, LastName, Gender, DateOfBirth, BSN, Relationship, Email, Password, PhoneNumber, Address, PostalCode, City, Country);
                            }
                            else if (EmployeeType == "Warehouse Manager")
                            {
                                person = new FloorManager(empID, FirstName, LastName, Gender, DateOfBirth, BSN, Relationship, Email, Password, PhoneNumber, Address, PostalCode, City, Country);
                            }
                            else if(EmployeeType == "Floor Staff")
                            {
                                person = new FloorStaff(empID, FirstName, LastName, Gender, DateOfBirth, BSN, Relationship, Email, Password, PhoneNumber, Address, PostalCode, City, Country, 0, ContractType);
                            }
                            else if (EmployeeType == "Warehouse Staff")
                            {
                                person = new FloorStaff(empID, FirstName, LastName, Gender, DateOfBirth, BSN, Relationship, Email, Password, PhoneNumber, Address, PostalCode, City, Country, 0, ContractType);
                            }
                            employees.Add(person);
                        }
                    }
                }
                con.Close();
                return employees;
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
            return null;
        }

        public string GetName(int id)
        {

            try
            {
                string namestring;
                string FirstName;
                string LastName;
                string que = "SELECT * FROM employees WHERE Employee_ID = @eID";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);
                cmd.Parameters.AddWithValue("@eID", id);

                using (MySqlDataReader objReader = cmd.ExecuteReader())
                {
                    if (objReader.HasRows)
                    {
                        while (objReader.Read())
                        {
                            FirstName = objReader["FirstName"].ToString();
                            LastName = objReader["LastName"].ToString();
                            namestring = FirstName + LastName;
                            return namestring;
                        }
                    }
                }
                con.Close();
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
            return null;
        }
        public bool UpdateEmployee(Employee person)
        {
            try
            {
                string que = "UPDATE employees SET FirstName= @fName, LastName= @lName, DateOfBirth= @dob, BSN= @bsn, Gender= @gender, Relationship= @relationship, Email= @email, Password= @pswd, PhoneNumber= @pNumber, Address= @address, PostalCode= @pCode, City= @city, Country= @country, EmployeeType= @role, ContractType=@cType WHERE Employee_ID= @eID";

                MySqlCommand cmd = new MySqlCommand(que, con);
                con.Open();

                cmd.Parameters.AddWithValue("@eID", person.EmployeeID);
                cmd.Parameters.AddWithValue("@fName", person.FirstName);
                cmd.Parameters.AddWithValue("@lName", person.LastName);
                cmd.Parameters.AddWithValue("@dob", person.Birthdate);
                cmd.Parameters.AddWithValue("@bsn", person.BSN_Num);
                cmd.Parameters.AddWithValue("@gender", person.Gender);
                cmd.Parameters.AddWithValue("@relationship", person.Relationship);
                cmd.Parameters.AddWithValue("@email", person.Email);
                cmd.Parameters.AddWithValue("@pswd", person.Password);
                cmd.Parameters.AddWithValue("@pNumber", person.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", person.Address);
                cmd.Parameters.AddWithValue("@pCode", person.Postal);
                cmd.Parameters.AddWithValue("@city", person.City);
                cmd.Parameters.AddWithValue("@country", person.Country);
                if (person is FloorStaff)
                {
                    person.Status = "Floor Staff";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType", ((FloorStaff)person).Contract);
                }
                else if (person is WarehouseStaff)
                {
                    person.Status = "Warehouse Staff";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType", ((WarehouseStaff)person).Contract);
                }
                else if (person is FloorManager)
                {
                    person.Status = "Floor Manager";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType", "full");
                }
                else if (person is WarehouseManager)
                {
                    person.Status = "Warehouse Manager";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType", "full");
                }
                else if (person is Administrator)
                {
                    person.Status = "Admininstrator";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType", "full");
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
            return false;
        }
    

        public bool GetIdentity(string username, string password, out string type, out int id)
        {
            type = null;
            id = 0;
            try
            {
                string que = "SELECT * FROM employees WHERE Email = @usrName AND Password = @password;";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);
          
                cmd.Parameters.AddWithValue("@usrName", username);
                cmd.Parameters.AddWithValue("@password", password);

               MySqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    type = dr[14].ToString();
                    id = Convert.ToInt32(dr[0]);
                }


                con.Close();
                return true;
            }
            catch(MySqlException ex)
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
            return false;
        }

    }
}
