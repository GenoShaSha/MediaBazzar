using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public abstract class Staff : Employee
    {
        private int workHours;
        private string contactType;
        public Staff(string firstName, string lastName, DateTime dateOfBirth, string bsn, string gender, string relationship, string email, string password, string phoneNumber, string address, string postalCode, string city, string country, int workHours, string cType)
            : base(firstName,lastName,dateOfBirth,bsn,gender,relationship,email,password,phoneNumber,address,postalCode,city,country)
        {
            this.workHours = workHours;
            this.contactType = cType;
        }
        public Staff(int id, string firstName, string lastName, DateTime dateOfBirth, string bsn, string gender, string relationship, string email, string password, string phoneNumber, string address, string postalCode, string city, string country, int workHours, string cType)
            : base(id,firstName, lastName, dateOfBirth, bsn, gender, relationship, email, password, phoneNumber, address, postalCode, city, country)
        {
            this.workHours = workHours;
            this.contactType = cType;
        }

        public int WorkHours
        {
            get { return this.workHours; }
            set { this.workHours = value; }
        }
        public string ContractType
        {
            get { return this.contactType; }
            set { this.contactType = value; }
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
