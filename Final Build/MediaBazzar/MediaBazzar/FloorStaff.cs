using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class FloorStaff : Staff
    {
        public FloorStaff(string firstName, string lastName, DateTime dateOfBirth, string bsn, string gender, string relationship, string email, string password, string phoneNumber, string address, string postalCode, string city, string country,string department, int workHours, string cType)
            : base(firstName, lastName, dateOfBirth, bsn, gender, relationship, email, password, phoneNumber, address, postalCode, city, country,department, workHours, cType)
        {

        }
        public FloorStaff(int id, string firstName, string lastName, DateTime dateOfBirth, string bsn, string gender, string relationship, string email, string password, string phoneNumber, string address, string postalCode, string city, string country, string department, int workHours, string cType)
            : base(id, firstName, lastName, dateOfBirth, bsn, gender, relationship, email, password, phoneNumber, address, postalCode, city, country,department, workHours, cType)
        {

        }
        public override string ToString()
        {
            string employeestring;
            if (this.status == string.Empty)
            {
                if (this.ContractType == "full")
                {
                    employeestring = $"{this.firstName} {this.lastName} ({this.id}) : Full-time Floor Staff";
                }
                else if (this.ContractType == "part")
                {
                    employeestring = $"{this.firstName} {this.lastName} ({this.id}) : Part-time Floor Staff";
                }
                else if (this.ContractType == "middle")
                {
                    employeestring = $"{this.firstName} {this.lastName} ({this.id}) : Part-time Floor Staff";
                }
                else
                {
                    employeestring = "";
                }
                return employeestring;
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
