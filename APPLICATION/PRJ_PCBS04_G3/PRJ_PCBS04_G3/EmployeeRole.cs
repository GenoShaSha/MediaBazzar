using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_PCBS04_G3
{
    public class EmployeeRole : Person
    {
        private int workhours;
        private string contract;
        public EmployeeRole(string firstname, string lastname, string gender, DateTime birthdate, string BSN, string relationship, string email, string phonenumber, string address, string postalcode, string city, string country, int workhours, string contract, DateTime dateOfJoin) : base(firstname, lastname, gender, birthdate, BSN, relationship, email, phonenumber, address, postalcode, city, country, dateOfJoin)
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
            this.dateOfJoin = dateOfJoin;
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
    }
}
