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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
/*            try
            {
                string con = "Server=studmysql01.fhict.local;Uid=dbi450080;Database=dbi450080;Pwd=WortelSoulution;";
                string que = "INSERT INTO employees(EmployeeID,Username,Password,EmployeeType) VALUES('" + this.tbUsrname.Text + "','" + this.tbFName.Text + "','" + this.tbLName.Text + "','" + this.tbFName.Text + "','" + this.tbDoB.Text + "','" + this.tbBSN.Text + "','" + this.tbRelationship.Text + "','" + this.tbEmail.Text + "','" + this.tbPNumber.Text + "','" + this.tbAddress.Text + "','" + this.tbPostalCode.Text + "','" + this.tbCity.Text + "','" + this.tbCountry.Text + "'); ";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
