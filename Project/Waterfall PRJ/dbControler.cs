using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Waterfall_PRJ
{
    public class dbControler
    {
        private MySqlConnection con;

        public dbControler()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }
        public void AddEmployees(Person person)
        {
            try
            {
                string que = "INSERT INTO addingemployees (FirstName,LastName,DateOfBirth,BSN,Gender,Relationship,Email,PhoneNumber,Address,PostalCode,City,Country,role,cType) VALUES (@fName,@lName,@dob,@bsn,@gender,@relationship,@email,@pNumber,@address,@pCode,@city,@country,@role,@cType)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

/*                cmd.Parameters.AddWithValue("@fName", person.FirstName);
                cmd.Parameters.AddWithValue("@lName", person.LastName);
                cmd.Parameters.AddWithValue("@dob", person.Birthdate);
                cmd.Parameters.AddWithValue("@bsn", person.BSN_Num);
                cmd.Parameters.AddWithValue("@gender", person.Gender);
                cmd.Parameters.AddWithValue("@relationship", person.Relationship);
                cmd.Parameters.AddWithValue("@email", person.Email);
                cmd.Parameters.AddWithValue("@pNumber", person.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", person.Address);
                cmd.Parameters.AddWithValue("@pCode", person.Postal);
                cmd.Parameters.AddWithValue("@city", person.City);
                cmd.Parameters.AddWithValue("@country", person.Country);*/
                if(person is EmployeeRole)
                {
                    cmd.Parameters.AddWithValue("@fName", person.FirstName);
                    cmd.Parameters.AddWithValue("@lName", person.LastName);
                    cmd.Parameters.AddWithValue("@dob", person.Birthdate);
                    cmd.Parameters.AddWithValue("@bsn", person.BSN_Num);
                    cmd.Parameters.AddWithValue("@gender", person.Gender);
                    cmd.Parameters.AddWithValue("@relationship", person.Relationship);
                    cmd.Parameters.AddWithValue("@email", person.Email);
                    cmd.Parameters.AddWithValue("@pNumber", person.PhoneNumber);
                    cmd.Parameters.AddWithValue("@address", person.Address);
                    cmd.Parameters.AddWithValue("@pCode", person.Postal);
                    cmd.Parameters.AddWithValue("@city", person.City);
                    cmd.Parameters.AddWithValue("@country", person.Country);
                    person.Status = "Employee";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType", ((EmployeeRole)person).Contract);
                }
                else if (person is FloorManagerRole)
                {
                    cmd.Parameters.AddWithValue("@fName", person.FirstName);
                    cmd.Parameters.AddWithValue("@lName", person.LastName);
                    cmd.Parameters.AddWithValue("@dob", person.Birthdate);
                    cmd.Parameters.AddWithValue("@bsn", person.BSN_Num);
                    cmd.Parameters.AddWithValue("@gender", person.Gender);
                    cmd.Parameters.AddWithValue("@relationship", person.Relationship);
                    cmd.Parameters.AddWithValue("@email", person.Email);
                    cmd.Parameters.AddWithValue("@pNumber", person.PhoneNumber);
                    cmd.Parameters.AddWithValue("@address", person.Address);
                    cmd.Parameters.AddWithValue("@pCode", person.Postal);
                    cmd.Parameters.AddWithValue("@city", person.City);
                    cmd.Parameters.AddWithValue("@country", person.Country);
                    person.Status = "Manager";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType","full");
                }
                else if (person is Administrator)
                {
                    cmd.Parameters.AddWithValue("@fName", person.FirstName);
                    cmd.Parameters.AddWithValue("@lName", person.LastName);
                    cmd.Parameters.AddWithValue("@dob", person.Birthdate);
                    cmd.Parameters.AddWithValue("@bsn", person.BSN_Num);
                    cmd.Parameters.AddWithValue("@gender", person.Gender);
                    cmd.Parameters.AddWithValue("@relationship", person.Relationship);
                    cmd.Parameters.AddWithValue("@email", person.Email);
                    cmd.Parameters.AddWithValue("@pNumber", person.PhoneNumber);
                    cmd.Parameters.AddWithValue("@address", person.Address);
                    cmd.Parameters.AddWithValue("@pCode", person.Postal);
                    cmd.Parameters.AddWithValue("@city", person.City);
                    cmd.Parameters.AddWithValue("@country", person.Country);
                    person.Status = "Administrator";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType", "full");
                }

                cmd.ExecuteNonQuery();

                con.Close();
                /* Console.WriteLine(cmd.ExecuteNonQuery());*/
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public bool GetIdentity(string username, string password, out string type)
        {
            type = null;
            try
            {
                string que = "SELECT * FROM signin WHERE Username = @usrName AND Password = @password;";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);
          
                cmd.Parameters.AddWithValue("@usrName", username);
                cmd.Parameters.AddWithValue("@password", password);

               MySqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    type = dr[3].ToString();
                }


                con.Close();
               /* Console.WriteLine(cmd.ExecuteNonQuery());*/
                return true;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

    }
}
