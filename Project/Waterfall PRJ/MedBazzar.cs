using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    class MedBazzar
    {
        EmployeeManager em;
        dbControler dc;

        public MedBazzar()
        {
            em = new EmployeeManager();
            dc = new dbControler();
        }

        public void AddNewEmp(int role, string fName, string lName, string gender, DateTime bod, string bsn, string relationship, string email, string pswd, string pNumb, string address, string pCode, string city, string country)
        {
            
            if (role == 0)
            {
                em.AddPerson(new Administrator(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country));
            }
            else if (role == 1)
            {
                em.AddPerson(new FloorManagerRole(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country));
            }
        }
        public void AddEmployeeRole( string fName, string lName, string gender, DateTime bod, string bsn, string relationship, string email, string pswd, string pNumb, string address, string pCode, string city, string country, string contract)
        {
            if (contract == "full")
            {
                em.AddPerson(new EmployeeRole(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country, 40, "full"));
            }
            else if (contract == "middle")
            {

                em.AddPerson(new EmployeeRole(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country, 30, "middle"));
            }
            else if (contract == "part")
            {
                em.AddPerson(new EmployeeRole(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country, 30, "part"));
            }
        }

        public void UpdatePerson(Person p, string newFName, string newLName, string newGender, DateTime newDoB, string newBSN, string newRelationship, string newEmail, string newPass, string newPNumb, string newAddress, string newPCode, string newCity, string newCountry)
        {
            p.UpdatePerson(newFName, newLName, newGender, newDoB, newBSN, newRelationship, newEmail, newPass, newPNumb, newAddress, newPCode, newCity, newCountry);
            dc.UpdateEmployee(p);
        }
    }
}
