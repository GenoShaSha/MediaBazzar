using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public abstract class Person
    {
        protected long employeeID;
        protected static long nextID = 1000;
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

        protected Person(string firstname, string lastname, string gender, DateTime birthdate, string BSN, string relationship,string email, string phonenumber, string address, string postalcode, string city, string country)
        {
            this.employeeID = Person.nextID;
            Person.nextID += 1;
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
        }

        public string FirstName
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }
        public string LastName
        {
            get { return this.lastname; }
            set { this.lastname= value; }
        }

        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public DateTime Birthdate
        {
            get { return this.birthdate; }
            set { this.birthdate= value; }
        }
        public string BSN_Num
        {
            get { return this.BSN; }
            set { this.BSN = value; }
        }
        public string Relationship
        {
            get { return this.relationship; }
            set { this.relationship= value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email= value; }
        }
        public string PhoneNumber
        {
            get { return this.phonenumber; }
            set { this.phonenumber = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address= value; }
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
        public long EmployeeID
        { get { return this.employeeID; } }
        
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
        public virtual string ShowAll()
        {
            string infostring= $"Name : {this.firstname} {this.lastname}* Gender: {this.gender}* Birthdate: {this.birthdate.ToShortDateString()}* BSN : {this.BSN}* Status : {this.relationship}* Email: {this.email}* Address: {this.address}* Postalcode: {this.postalcode}* City: {this.city}* Country: {this.country}";
            string newstring = infostring.Replace("*", "\n");
            return newstring;
        
        }
        public string RemovedString()
        {
            return $"Removed employee {this.EmployeeID} ({this.FirstName} {this.LastName})";
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
    }
}
