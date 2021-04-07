using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PRJ_PCBS04_G3
{
    public class EmployeeDatabaseManager
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi450080;uid=dbi450080;password=WortelSoulution;");

        /*        public List<Person> ReadFromDatabase()
                {
                    string sql = "SELECT id, username FROM user;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    List<Person> users = new List<Person>();
                    while (dr.Read())
                    {
                        users.Add(new Person(Convert.ToInt32(dr[0]), dr[1].ToString()));
                    }
                    conn.Close();
                } */
        public void AddNewEmployeeToDB(Person person)
        {
            string sql = "INSERT INTO addingemployees(First Name, Last Name, Date of Birth, BSN Numbers, Gender, Relationship, Email, Phone Number, Address, Postal Code, City, Country, Date of Join, Employee Role, Contract Type) VALUES (@FName, @LName, @DoB, @BSN, @Gender, @Relationship, @Email, @PNumber, @Address, @PostalCode, @City, @Country, @DoJ, @EmployeeRole, @CType)";
            
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@FName", person.FirstName);
                    cmd.Parameters.AddWithValue("@LName", person.LastName);
                    cmd.Parameters.AddWithValue("@DoB", person.Birthdate);
                    cmd.Parameters.AddWithValue("@BSN", person.BSN_Num);
                    cmd.Parameters.AddWithValue("@Gender", person.Gender);
                    cmd.Parameters.AddWithValue("@Relationship", person.Relationship);
                    cmd.Parameters.AddWithValue("@Email", person.Email);
                    cmd.Parameters.AddWithValue("@PNumber", person.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", person.Address);
                    cmd.Parameters.AddWithValue("@PostalCode", person.Postal);
                    cmd.Parameters.AddWithValue("@City", person.City);
                    cmd.Parameters.AddWithValue("@Country", person.Country);
                    cmd.Parameters.AddWithValue("@DoJ", person.DateOfJoin);
                    cmd.Parameters.AddWithValue("@EmployeeRole", person.Role);
                    if (person is EmployeeRole)
                    {
                        cmd.Parameters.AddWithValue("@CType", ((EmployeeRole)person).Contract);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CType", "full");
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            { 

            }
            finally
            {
                conn.Close();
            }
            

           

           

        }
    }

}

