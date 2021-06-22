using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazzar
{
    public class DbEmployee
    {
        private MySqlConnection con;

        public DbEmployee()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }
        public void AddEmployees(Employee person)
        {
            try
            {
                string que = "INSERT INTO employees(FirstName,LastName,DateOfBirth,BSN,Gender,Relationship,Email,Password,PhoneNumber,Address,PostalCode,City,Country,EmployeeType,WorkHours,ContractType,Preference,Department) VALUES (@fName,@lName,@dob,@bsn,@gender,@relationship,@email,@pswd,@pNumber,@address,@pCode,@city,@country,@role,@wHours,@cType,@pref,@department)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@fName", person.FirstName);
                cmd.Parameters.AddWithValue("@lName", person.LastName);
                cmd.Parameters.AddWithValue("@dob", person.DateOfBirth);
                cmd.Parameters.AddWithValue("@bsn", person.BSN);
                cmd.Parameters.AddWithValue("@gender", person.Gender);
                cmd.Parameters.AddWithValue("@relationship", person.Relationship);
                cmd.Parameters.AddWithValue("@email", person.Email);
                cmd.Parameters.AddWithValue("@pswd", person.Password);
                cmd.Parameters.AddWithValue("@pNumber", person.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", person.Address);
                cmd.Parameters.AddWithValue("@pCode", person.PostalCode);
                cmd.Parameters.AddWithValue("@city", person.City);
                cmd.Parameters.AddWithValue("@country", person.Country);
                cmd.Parameters.AddWithValue("@pref", "900000009000000090000000");
                cmd.Parameters.AddWithValue("@department", person.Department);
                if (person is FloorStaff)
                {
                    person.EmployeeType = "Floor Staff";
                    cmd.Parameters.AddWithValue("@role", person.EmployeeType);
                    cmd.Parameters.AddWithValue("@wHours", ((FloorStaff)person).WorkHours);
                    cmd.Parameters.AddWithValue("@cType", ((FloorStaff)person).ContractType);
                }
                else if (person is FloorManager)
                {
                    person.EmployeeType = "Floor Manager";
                    cmd.Parameters.AddWithValue("@role", person.EmployeeType);
                    cmd.Parameters.AddWithValue("@wHours", 40);
                    cmd.Parameters.AddWithValue("@cType", "full");
                }
                else if (person is WarehouseStaff)
                {
                    person.EmployeeType = "Warehouse Staff";
                    cmd.Parameters.AddWithValue("@role", person.EmployeeType);
                    cmd.Parameters.AddWithValue("@wHours", ((WarehouseStaff)person).WorkHours);
                    cmd.Parameters.AddWithValue("@cType", ((WarehouseStaff)person).ContractType);
                }
                else if (person is WarehouseManager)
                {
                    person.EmployeeType = "Warehouse Manager";
                    cmd.Parameters.AddWithValue("@role", person.EmployeeType);
                    cmd.Parameters.AddWithValue("@wHours", 40);
                    cmd.Parameters.AddWithValue("@cType", "full");
                }
                else if (person is Administrator)
                {
                    person.EmployeeType = "Admininstrator";
                    cmd.Parameters.AddWithValue("@role", person.EmployeeType);
                    cmd.Parameters.AddWithValue("@wHours", 40);
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
                            int WorkHours = (int)objReader["WorkHours"];
                            string ContractType = objReader["ContractType"].ToString();
                            string Department = objReader["Department"].ToString();

                            Employee person = null;
                            if (EmployeeType == "Administrator")
                            {
                                person = new Administrator(empID, FirstName, LastName, DateOfBirth, BSN, Gender, Relationship, Email, Password, PhoneNumber, Address, PostalCode, City, Country, Department);
                            }
                            else if (EmployeeType == "Floor Manager")
                            {
                                person = new FloorManager(empID, FirstName, LastName, DateOfBirth, BSN, Gender, Relationship, Email, Password, PhoneNumber, Address, PostalCode, City, Country, Department);
                            }
                            else if (EmployeeType == "Warehouse Manager")
                            {
                                person = new FloorManager(empID, FirstName, LastName, DateOfBirth, BSN, Gender, Relationship, Email, Password, PhoneNumber, Address, PostalCode, City, Country, Department);
                            }
                            else if (EmployeeType == "Floor Staff")
                            {
                                person = new FloorStaff(empID, FirstName, LastName, DateOfBirth, BSN, Gender, Relationship, Email, Password, PhoneNumber, Address, PostalCode, City, Country, Department, WorkHours, ContractType);
                            }
                            else if (EmployeeType == "Warehouse Staff")
                            {
                                person = new FloorStaff(empID, FirstName, LastName, DateOfBirth, BSN, Gender, Relationship, Email, Password, PhoneNumber, Address, PostalCode, City, Country, Department, WorkHours, ContractType);
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
                if (con != null)
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
                if (con != null)
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
                string que = "UPDATE employees SET FirstName= @fName, LastName= @lName, DateOfBirth= @dob, BSN= @bsn, Gender= @gender, Relationship= @relationship, Email= @email, Password= @pswd, PhoneNumber= @pNumber, Address= @address, PostalCode= @pCode, City= @city, Country= @country, Department= @department, EmployeeType= @role,WorkHours= @wHours, ContractType=@cType WHERE Employee_ID= @eID";

                MySqlCommand cmd = new MySqlCommand(que, con);
                con.Open();

                cmd.Parameters.AddWithValue("@eID", person.Id);
                cmd.Parameters.AddWithValue("@fName", person.FirstName);
                cmd.Parameters.AddWithValue("@lName", person.LastName);
                cmd.Parameters.AddWithValue("@dob", person.DateOfBirth);
                cmd.Parameters.AddWithValue("@bsn", person.BSN);
                cmd.Parameters.AddWithValue("@gender", person.Gender);
                cmd.Parameters.AddWithValue("@relationship", person.Relationship);
                cmd.Parameters.AddWithValue("@email", person.Email);
                cmd.Parameters.AddWithValue("@pswd", person.Password);
                cmd.Parameters.AddWithValue("@pNumber", person.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", person.Address);
                cmd.Parameters.AddWithValue("@pCode", person.PostalCode);
                cmd.Parameters.AddWithValue("@city", person.City);
                cmd.Parameters.AddWithValue("@country", person.Country);
                cmd.Parameters.AddWithValue("@department", person.Department);
                if (person is FloorStaff)
                {
                    person.EmployeeType = "Floor Staff";
                    cmd.Parameters.AddWithValue("@role", person.EmployeeType);
                    cmd.Parameters.AddWithValue("@wHours", ((FloorStaff)person).WorkHours);
                    cmd.Parameters.AddWithValue("@cType", ((FloorStaff)person).ContractType);
                }
                else if (person is WarehouseStaff)
                {
                    person.EmployeeType = "Warehouse Staff";
                    cmd.Parameters.AddWithValue("@role", person.EmployeeType);
                    cmd.Parameters.AddWithValue("@wHours", ((WarehouseStaff)person).WorkHours);
                    cmd.Parameters.AddWithValue("@cType", ((WarehouseStaff)person).ContractType);
                }
                else if (person is FloorManager)
                {
                    person.EmployeeType = "Floor Manager";
                    cmd.Parameters.AddWithValue("@role", person.EmployeeType);
                    cmd.Parameters.AddWithValue("@wHours", 40);
                    cmd.Parameters.AddWithValue("@cType", "full");
                }
                else if (person is WarehouseManager)
                {
                    person.EmployeeType = "Warehouse Manager";
                    cmd.Parameters.AddWithValue("@role", person.EmployeeType);
                    cmd.Parameters.AddWithValue("@wHours", 40);
                    cmd.Parameters.AddWithValue("@cType", "full");
                }
                else if (person is Administrator)
                {
                    person.EmployeeType = "Administrator";
                    cmd.Parameters.AddWithValue("@role", person.EmployeeType);
                    cmd.Parameters.AddWithValue("@wHours", 40);
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
