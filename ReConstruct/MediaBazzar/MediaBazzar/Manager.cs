using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public abstract class Manager : Employee
    {
        public Manager(string firstName, string lastName, DateTime dateOfBirth, string bsn, string gender, string relationship, string email, string password, string phoneNumber, string address, string postalCode, string city, string country) : base(firstName, lastName, dateOfBirth, bsn, gender, relationship, email, password, phoneNumber, address, postalCode, city, country)
        {

        }
        public Manager(int id, string firstName, string lastName, DateTime dateOfBirth, string bsn, string gender, string relationship, string email, string password, string phoneNumber, string address, string postalCode, string city, string country) : base(id, firstName, lastName, dateOfBirth, bsn, gender, relationship, email, password, phoneNumber, address, postalCode, city, country)
        {

        }
        public override string ToString()
        {
            if (this.status == string.Empty)
            {
                return $"{this.firstName} {this.lastName} ({this.id}) : Full-time employee";
            }
            else if (this.status == "Terminated")
            {
                return $"Removed : {this.firstName} {this.lastName} ({this.id})";
            }
            else
            {
                return null;
            }
        }
    }
}
