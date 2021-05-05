using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public abstract class Person
    {
        protected int employeeID;
        //protected static long nextID = 1000;
        protected string firstname;
        protected string lastname;
        protected string gender;
        protected DateTime birthdate;
        protected string BSN;
        protected string relationship;
        protected string email;
        protected string password;
        protected string phonenumber;
        protected string address;
        protected string postalcode;
        protected string city;
        protected string country;
        protected string status = string.Empty;
        protected string cType;

        protected Person(int id, string firstname, string lastname, string gender, DateTime birthdate, string BSN, string relationship, string email, string password, string phonenumber, string address, string postalcode, string city, string country)
        {
            this.employeeID = id;
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
        protected Person(string firstname, string lastname, string gender, DateTime birthdate, string BSN, string relationship, string email, string password, string phonenumber, string address, string postalcode, string city, string country)
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

        public string FirstName
        {
            get { return this.firstname; }
            set { this.FirstName = value; }
        }
        public string LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public DateTime Birthdate
        {
            get { return this.birthdate; }
            set { this.birthdate = value; }
        }
        public string BSN_Num
        {
            get { return this.BSN; }
            set { this.BSN = value; }
        }
        public string Relationship
        {
            get { return this.relationship; }
            set { this.relationship = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string PhoneNumber
        {
            get { return this.phonenumber; }
            set { this.phonenumber = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string Postal
        {
            get { return this.postalcode; }
            set { this.postalcode = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public int EmployeeID
        {
            get { return this.employeeID; }
        }

        public override string ToString()
        {
            if (this.status == string.Empty)
            {
                return $"{this.firstname} {this.lastname} ({this.employeeID})";
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

        public void UpdatePerson(string fName, string lName, string gender, DateTime bod, string bsn, string relationship, string email, string pswd, string pNumb, string address, string pCode, string city, string country)
        {
            this.firstname = fName;
            this.lastname = lName;
            this.gender = gender;
            this.birthdate = bod;
            this.BSN = bsn;
            this.relationship = relationship;
            this.email = email;
            this.password = pswd;
            this.phonenumber = pNumb;
            this.address = address;
            this.postalcode = pCode;
            this.city = city;
            this.country = country;
        }
/*        private string CType
        {
            get { return this.cType; }
        }*/
    }
}
