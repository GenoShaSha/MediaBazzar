﻿using System;
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
        EmployeeManager em = new EmployeeManager();

        public dbControler()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }
        public void AddEmployees(Person person)
        {
            try
            {
                string que = "INSERT INTO employees(Employee_ID,FirstName,LastName,DateOfBirth,BSN,Gender,Relationship,Email,Password,PhoneNumber,Address,PostalCode,City,Country,EmployeeType,ContractType) VALUES (@eID,@fName,@lName,@dob,@bsn,@gender,@relationship,@email,@pswd,@pNumber,@address,@pCode,@city,@country,@role,@cType)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

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
                if (person is EmployeeRole)
                {
                    person.Status = "Employee";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType", ((EmployeeRole)person).Contract);
                }
                else if (person is FloorManagerRole)
                {
                    person.Status = "Manager";
                    cmd.Parameters.AddWithValue("@role", person.Status);
                    cmd.Parameters.AddWithValue("@cType","full");
                }
                else if (person is Administrator)
                {
                    person.Status = "Administrator";
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
            return false;
        }
        public string ReadEmployees(out string emplyee)
        {
            emplyee = null;
            try
            {
                string que = "SELECT * FROM employees ORDER BY Employee_ID;";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    emplyee = dr[0].ToString(); dr[1].ToString(); dr[1].ToString(); dr[15].ToString();
                }

                con.Close();
                return emplyee;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public bool GetIdentity(string username, string password, out string type)
        {
            type = null;
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
                }


                con.Close();
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
