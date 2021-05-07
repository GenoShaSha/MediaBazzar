using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class FloorStaff : Employee
    {
        private int workhours;
        private string contract;
        public FloorStaff(string firstname, string lastname, string gender, DateTime birthdate, string BSN, string relationship, string email,string password, string phonenumber, string address, string postalcode, string city, string country, int workhours,string contract) : base(firstname, lastname, gender, birthdate, BSN, relationship, email, password, phonenumber, address, postalcode, city, country)
        {
            this.workhours = workhours;
            this.contract = contract;
        }
        public FloorStaff(int id, string firstname, string lastname, string gender, DateTime birthdate, string BSN, string relationship, string email, string password, string phonenumber, string address, string postalcode, string city, string country, int workhours, string contract) : base(id, firstname, lastname, gender, birthdate, BSN, relationship, email, password, phonenumber, address, postalcode, city, country)
        {
            this.workhours = workhours;
            this.contract = contract;
        }


        public int Workhours
        {
            get { return this.workhours; }
        }

        public string Contract
        {
            get { return this.contract; }
        }
        public override string ToString()
        {
            string employeestring;
            if (this.status == string.Empty)
            {
                if (this.contract == "full")
                {
                    employeestring = $"{this.firstname} {this.lastname} ({this.employeeID}) : Full-time Floor Staff";
                }
                else if (this.contract == "part")
                {
                    employeestring = $"{this.firstname} {this.lastname} ({this.employeeID}) : Part-time Floor Staff";
                }
                else if (this.contract == "middle")
                {
                    employeestring = $"{this.firstname} {this.lastname} ({this.employeeID}) : Part-time Floor Staff";
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
        public string Name
        {
            get { return this.firstname + " " + this.lastname; }
        }
    }
}
