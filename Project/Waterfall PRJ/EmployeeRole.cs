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
        public EmployeeRole(string firstname, string lastname, string gender, DateTime birthdate, string BSN, string relationship, string email, string phonenumber, string address, string postalcode, string city, string country, int workhours) : base(firstname, lastname, gender, birthdate, BSN, relationship, email, phonenumber, address, postalcode, city, country)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.birthdate = birthdate;
            this.BSN = BSN;
            this.relationship = relationship;
            this.email = email;
            this.phonenumber = phonenumber;
            this.address = address;
            this.postalcode = postalcode;
            this.city = city;
            this.country = country;
            this.workhours = workhours;
        }

        public int Workhours
        {
            get { return this.workhours; }
            set { this.workhours = value; }
        }
        public override string ToString()
        {
            string employeestring;
            if (this.workhours == 40)
            {
                employeestring = $"{this.firstname} {this.lastname} ({this.employeeID}) : Full-time employee";
            }
            else
            {
                employeestring = $"{this.firstname} {this.lastname} ({this.employeeID}) : Part-time employee";
            }
            return employeestring;
        }
    }
}
