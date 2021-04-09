using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Waterfall_PRJ
{
    public class EmployeeManager
    {
        List<Person> persons;
        private MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=mediabazaar;");


        public EmployeeManager()
        {
            persons = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            persons.Add(person);

            string cmdString = "INSERT INTO `employees`(`firstName`, `lastName`, `gender`, `BSN`, `relationshipStatus`, `eMail`, `phoneNumber`, `adress`, `postalCode`, `city`, `country`, `role`, `contractType`, `DoB`, `employeeID`) " +
                "VALUES (@firstname,@lastname,@gender,@BSN,@relationshipStatus,@eMail,@phoneNumber,@adress,@postalCode,@city,@country,@role,@contractType,DoB, NULL)";
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@firstname", person.FirstName);
            cmd.Parameters.AddWithValue("@lastname", person.LastName);
            cmd.Parameters.AddWithValue("@gender", person.Gender);
            cmd.Parameters.AddWithValue("@BSN", person.BSN_Num);
            cmd.Parameters.AddWithValue("@relationshipStatus", person.Relationship);
            cmd.Parameters.AddWithValue("@eMail", person.Email);
            cmd.Parameters.AddWithValue("@phoneNumber", person.PhoneNumber);
            cmd.Parameters.AddWithValue("@adress", person.Address);
            cmd.Parameters.AddWithValue("@postalCode", person.Postal);
            cmd.Parameters.AddWithValue("@city", person.City);
            cmd.Parameters.AddWithValue("@country", person.Country);
            cmd.Parameters.AddWithValue("@role", person.Status);
            cmd.Parameters.AddWithValue("@contractType", person.Status);
            cmd.Parameters.AddWithValue("@DoB", person.Birthdate);
            cmd.Parameters.AddWithValue("@employeeID", person.EmployeeID);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void RemovePerson(Person person)
        {
            persons.Remove(person);

            string cmdString = "UPDATE `employees` SET `status`= Terminated WHERE `employees`.`firstName` = @firstName";
            MySqlCommand cmd = new MySqlCommand(cmdString, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@firstName", person.FirstName);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Person> GetPersons()
        {
            return persons;
        }
        
        public Person GetPerson(long ID)
        {
            foreach(Person p in persons)
            {
                if(p.EmployeeID == ID)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
