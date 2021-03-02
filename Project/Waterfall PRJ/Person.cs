using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public abstract class Person
    {
        protected static long ID = 999;
        protected string firstname;
        protected string lastname;
        protected string gender;
        protected DateTime birthdate;
        protected string BSN;
        protected string relationship;
        protected string email;
        protected string phonenumber;
        protected string address;
        protected string postalcode;
        protected string city;
        protected string country;

        protected Person(string firstname, string lastname, string gender, DateTime birthdate, string BSN, string relationship,string email, string phonenumber, string address, string postalcode, string city, string country)
        {
            ID += 1;
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.birthdate = birthdate;
            this.BSN = BSN;
            this.relationship = relationship;
            this.email = email;
            this.address = address;
            this.postalcode = postalcode;
            this.city = city;
            this.country = country;
        }
        public long EmployeeID
        { get { return ID; } }
        
        public override string ToString()
        {
            return $"{this.firstname} {this.lastname} ({ID})";
        }
        public virtual string ShowAll()
        {
            string infostring= $"Name : {this.firstname} {this.lastname}* Gender: {this.gender}* Birthdate: {this.birthdate}* BSN : {this.BSN}* Status : {this.relationship}* Email: {this.email}* Address: {this.address}* Postalcode: {this.postalcode}* City: {this.city}* Country: {this.country}";
            string newstring = infostring.Replace("*", "\n");
            return newstring;
        
        }


    }
}
