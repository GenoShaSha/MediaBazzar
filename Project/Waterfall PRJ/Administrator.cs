using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class Administrator : Person
    {
        private string adminusername;
        private string adminpass;

        public Administrator(string firstname, string lastname, string gender, DateTime birthdate, string BSN, string relationship, string email,string password, string phonenumber, string address, string postalcode, string city, string country) : base(firstname,lastname,gender,birthdate,BSN,relationship,email,password,phonenumber,address,postalcode,city,country)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.birthdate = birthdate;
            this.BSN = BSN;
            this.relationship = relationship;
            this.email = email;
            this.password = password;
            this.phonenumber = phonenumber;
            this.address = address;
            this.postalcode = postalcode;
            this.city = city;
            this.country = country;
        }
        public override string ToString()
        {
            if (this.status == string.Empty)
            {
                return $"{this.firstname} {this.lastname} ({this.employeeID}) : Administrator";
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
        public string Username
        { get { return this.adminusername; } set { this.adminusername = value; } }
        public string Password
        { get { return this.adminpass; } set { this.adminpass= value; } }
    }
}
