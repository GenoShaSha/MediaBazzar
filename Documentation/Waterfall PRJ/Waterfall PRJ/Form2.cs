using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Waterfall_PRJ
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "Server=studmysql01.fhict.local;Uid=dbi450080;Database=dbi450080;Pwd=WortelSoulution;";
                string que = "INSERT INTO employees(EmployeeID_FK,FirstName,LastName,DateOfBirth,BSN,Relationship,Email,PhoneNumber,Address,PostalCode,City,Country) VALUES('" + this.tbID.Text + "','" + this.tbFName.Text + "','" + this.tbLName.Text + "','" + this.tbDoB.Text + "','" + this.tbBSN.Text + "','" + this.tbRelationship.Text + "','" + this.tbEmail.Text + "','" + this.tbPNumber.Text + "','" + this.tbAddress.Text + "','" + this.tbPostalCode.Text + "','" + this.tbCity.Text + "','" + this.tbCountry.Text + "'); ";

                MySqlConnection myCon = new MySqlConnection(con);
                MySqlCommand myCommand = new MySqlCommand(que, myCon);
                MySqlDataReader dataReader;
                myCon.Open();

                dataReader = myCommand.ExecuteReader();
                MessageBox.Show("Data have been saved");
                while (dataReader.Read())
                {

                }
                myCon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "Server=studmysql01.fhict.local;Uid=dbi450080;Database=dbi450080;Pwd=WortelSoulution;";
                string que = "UPDATE employees SET EmployeeID_FK='" + this.tbID.Text + "',FirstName='" + this.tbFName.Text + "',LastName='" + this.tbLName.Text + "',DateOfBirth='" + this.tbDoB.Text + "',BSN='" + this.tbBSN.Text + "',Relationship='" + this.tbRelationship.Text + "',Email='" + this.tbEmail.Text + "',PhoneNumber='" + this.tbPNumber.Text + "',Address='" + this.tbAddress.Text + "',PostalCode='" + this.tbPostalCode.Text + "',City='" + this.tbCity.Text + "',Country='" + this.tbCountry.Text + "'; ";

                MySqlConnection myCon = new MySqlConnection(con);
                MySqlCommand myCommand = new MySqlCommand(que, myCon);
                MySqlDataReader dataReader;
                myCon.Open();

                dataReader = myCommand.ExecuteReader();
                MessageBox.Show("Data have been update");
                while (dataReader.Read())
                {

                }
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "Server=studmysql01.fhict.local;Uid=dbi450080;Database=dbi450080;Pwd=WortelSoulution;";
                string que = "DELETE FROM employees WHERE EmployeeID_FK='" + this.tbID.Text + "';";

                MySqlConnection myCon = new MySqlConnection(con);
                MySqlCommand myCommand = new MySqlCommand(que, myCon);
                MySqlDataReader dataReader;
                myCon.Open();

                dataReader = myCommand.ExecuteReader();
                MessageBox.Show("Data has been removed");
                while (dataReader.Read())
                {

                }
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
