using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Waterfall_PRJ
{
    public class DbShift
    {
        private MySqlConnection con;

        public DbShift()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Username=dbi450080;Database=dbi450080;Password=WortelSoulution");
        }
        public void AddShift(Shift shift)
        {
            try
            {
                string query = "INSERT INTO shifts (date,type) VALUES (@date,@type)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@date", shift.ShiftDate);
                cmd.Parameters.AddWithValue("@type", shift.Type.ToString());

                cmd.ExecuteNonQuery();
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
        }
        public void AddAssignments(int emp_id, int work_id)
        {
            try
            {
                string query = "INSERT INTO assignedworkshifts (Employee_ID, shift_id) VALUES (@emp_id, @shift_id)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@emp_id", emp_id);
                cmd.Parameters.AddWithValue("@shift_id", work_id);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
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
        public List<Shift> ReadShifts()
        {
            List<Shift> shifts = new List<Shift>();
            string type;
            try
            {
                string que = "SELECT * FROM shifts ORDER BY shift_id;";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(que, con);

                using(MySqlDataReader objReader = cmd.ExecuteReader() )
                {
                    if(objReader.HasRows)
                    {
                        while(objReader.Read())
                        {
                            int id = (int)objReader["shift_id"];
                            DateTime date = (DateTime)objReader["date"];
                            type = (String)objReader["type"];
                            if(type == "Morning")
                            {
                                Shift shift = new Shift(id,date, ShiftType.Morning);
                                shifts.Add(shift);
                            }
                            else if (type == "Afternoon")
                            {
                                Shift shift = new Shift(id,date, ShiftType.Afternoon);
                                shifts.Add(shift);
                            }
                            else if (type == "Night")
                            {
                                Shift shift = new Shift(id,date, ShiftType.Night);
                                shifts.Add(shift);
                            }
                        }
                    }
                }
               
                con.Close();
                Console.WriteLine(shifts);
                return shifts;
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
            return null;
        }

        public bool ReturnShift(Shift shift)
        {
            try
            {
                string query = "SELECT * from shifts WHERE date = @date AND type = @type";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@date", shift.ShiftDate);
                cmd.Parameters.AddWithValue("@type", shift.Type.ToString());
                MySqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    if(dr.HasRows == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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
            return false;
        }

    }

  
}
