using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class EmployeeRole : Person
    {
        private int workhours;
        private string contract;
        public EmployeeRole(string firstname, string lastname, string gender, DateTime birthdate, string BSN, string relationship, string email,string password, string phonenumber, string address, string postalcode, string city, string country, int workhours,string contract) : base(firstname, lastname, gender, birthdate, BSN, relationship, email, password, phonenumber, address, postalcode, city, country)
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
            this.workhours = workhours;
            this.contract = contract;
        }

        public int Workhours
        {
            get { return this.workhours; }
            set { this.workhours = value; }
        }

        public string Contract
        {
            get { return this.contract; }
            set { this.contract = value; }
        }
        public override string ToString()
        {
            string employeestring;
            if (this.status == string.Empty)
            {
                if (this.contract == "full")
                {
                    employeestring = $"{this.firstname} {this.lastname} ({this.employeeID}) : Full-time employee";
                }
                else if (this.contract == "part")
                {
                    employeestring = $"{this.firstname} {this.lastname} ({this.employeeID}) : Part-time employee";
                }
                else if (this.contract == "middle")
                {
                    employeestring = $"{this.firstname} {this.lastname} ({this.employeeID}) : Part-time employee";
                }
                else
                {
                    employeestring = "";
                }
                return employeestring;
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
