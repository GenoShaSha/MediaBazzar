using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazzar
{
    class DbFiredEmployee
    {
        private MySqlConnection con;

        public DbFiredEmployee()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }
        public void AddResignEmployees(Employee employee)
        {
            try
            {
                string que = "INSERT INTO firedemployees(ID,FirstName,LastName,EmpType,ContractType) VALUES (@id,@fName,@lName,@role,@cType)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                cmd.Parameters.AddWithValue("@id", employee.Id);
                cmd.Parameters.AddWithValue("@fName", employee.FirstName);
                cmd.Parameters.AddWithValue("@lName", employee.LastName);

                if (employee is FloorStaff)
                {
                    employee.EmployeeType = "Floor Staff";
                    cmd.Parameters.AddWithValue("@role", employee.EmployeeType);
                    cmd.Parameters.AddWithValue("@cType", ((FloorStaff)employee).ContractType);
                }
                else if (employee is FloorManager)
                {
                    employee.EmployeeType = "Floor Manager";
                    cmd.Parameters.AddWithValue("@role", employee.EmployeeType);
                    cmd.Parameters.AddWithValue("@cType", "Full");
                }
                else if (employee is Administrator)
                {
                    employee.EmployeeType = "Administrator";
                    cmd.Parameters.AddWithValue("@role", employee.EmployeeType);
                    cmd.Parameters.AddWithValue("@cType", "Full");
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

    }
}
