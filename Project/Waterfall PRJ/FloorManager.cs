using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class FloorManager : Employee
    {
        public FloorManager(string firstname, string lastname, string gender, DateTime birthdate, string BSN, string relationship, string email, string password, string phonenumber, string address, string postalcode, string city, string country) : base(firstname, lastname, gender, birthdate, BSN, relationship, email, password, phonenumber, address, postalcode, city, country)
        {

        }
        public FloorManager(int id, string firstname, string lastname, string gender, DateTime birthdate, string BSN, string relationship, string email, string password, string phonenumber, string address, string postalcode, string city, string country) : base(id, firstname, lastname, gender, birthdate, BSN, relationship, email, password, phonenumber, address, postalcode, city, country)
        {

        }
        public override string ToString()
        {
            if (this.status == string.Empty)
            {
                return $"{this.firstname} {this.lastname} ({this.employeeID}) : Floor Manager";
            }
            else if (this.status == "Terminated")
            {
                return $"Removed : {this.firstname} {this.lastname} ({this.employeeID})";
            }
            else
            {
                return null;
            }   
        }
    }
}
