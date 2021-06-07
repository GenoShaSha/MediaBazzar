using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public abstract class Employee
    {
        protected int id;
        protected string firstName;
        protected string lastName;
        protected DateTime dateOfBirth;
        protected string bsn;
        protected string gender;
        protected string relationship;
        protected string email;
        protected string password;
        protected string phoneNumber;
        protected string address;
        protected string postalCode;
        protected string city;
        protected string country;
        protected string employeeType;
        protected DateTime dateOfJoin;
        protected string status = string.Empty;

        public Employee(string firstName, string lastName, DateTime dateOfBirth, string bsn, string gender, string relationship, string email, string password, string phoneNumber, string address, string postalCode, string city, string country)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.bsn = bsn;
            this.relationship = relationship;
            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.postalCode = postalCode;
            this.city = city;
            this.country = country;
        }
        public Employee(int id, string firstName, string lastName, DateTime dateOfBirth, string bsn, string gender, string relationship, string email, string password, string phoneNumber, string address, string postalCode, string city, string country)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.bsn = bsn;
            this.relationship = relationship;
            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.postalCode = postalCode;
            this.city = city;
            this.country = country;
        }
        public void UpdatePeople(string fName, string lName, string gender, DateTime bod, string bsn, string relationship, string email, string pswd, string pNumb, string address, string pCode, string city, string country)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.gender = gender;
            this.dateOfBirth = bod;
            this.bsn = bsn;
            this.relationship = relationship;
            this.email = email;
            this.password = pswd;
            this.phoneNumber = pNumb;
            this.address = address;
            this.postalCode = pCode;
            this.city = city;
            this.country = country;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }
        public string BSN
        {
            get { return this.bsn; }
            set { this.bsn = value; }
        }
        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
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
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
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
        public string EmployeeType
        {
            get { return this.employeeType; }
            set { this.employeeType = value; }
        }
        public override string ToString()
        {
            if (this.status == string.Empty)
            {
                return $"{firstName} {lastName} ({id})";
            }
            else if (this.status == "Terminated")
            {
                return $"Removed : {firstName} {lastName} ({id})";
            }
            else
            {
                return null;
            }
        }
    }

}
