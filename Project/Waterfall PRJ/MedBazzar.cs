﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    class MedBazzar
    {
        private EmployeeManagement em;
        private GoodManagement gm;
        private DbEmployees dc;
        private DbGoods dg;
        private ShiftManagement sm;
        private DbShift ds;
        private DbRequest dr;
        public MedBazzar()
        {
            em = new EmployeeManagement();
            gm = new GoodManagement();
            dc = new DbEmployees();
            dg = new DbGoods();
            sm = new ShiftManagement();
            dr = new DbRequest();
        }

        public void AddNewEmp(int role, string fName, string lName, string gender, DateTime bod, string bsn, string relationship, string email, string pswd, string pNumb, string address, string pCode, string city, string country)
        {
            
            if (role == 0)
            {
                em.AddPerson(new Administrator(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country));
            }
            else if (role == 1)
            {
                em.AddPerson(new FloorManager(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country));
            }
            else if (role == 3)
            {
                em.AddPerson(new WarehouseManager(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country));
            }
        }
        public void AddEmployeeRole( int role, string fName, string lName, string gender, DateTime bod, string bsn, string relationship, string email, string pswd, string pNumb, string address, string pCode, string city, string country, string contract)
        {
            if (role == 2)
            {
                if (contract == "full")
                {
                    em.AddPerson(new FloorStaff(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country, 40, "full"));
                }
                else if (contract == "middle")
                {

                    em.AddPerson(new FloorStaff(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country, 30, "middle"));
                }
                else if (contract == "part")
                {
                    em.AddPerson(new FloorStaff(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country, 30, "part"));
                }
            }
            else if(role == 4)
            {
                if (contract == "full")
                {
                    em.AddPerson(new WarehouseStaff(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country, 40, "full"));
                }
                else if (contract == "middle")
                {

                    em.AddPerson(new WarehouseStaff(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country, 30, "middle"));
                }
                else if (contract == "part")
                {
                    em.AddPerson(new WarehouseStaff(fName, lName, gender, bod, bsn, relationship, email, pswd, pNumb, address, pCode, city, country, 30, "part"));
                }

            }
        }
        public void AddGood(int articleNumbers, string productName, string category, decimal productPrice, string physicalDimensions, int quantity)
        {
            gm.AddProduct(new Good(articleNumbers, productName, category, productPrice, physicalDimensions,quantity));
        }
        public void RemoveEmployee(long id)
        {
            em.RemovePerson(id);
        }
        public void RemoveGood(int id)
        {
            gm.RemoveProduct(id);
        }
        public void UpdatePerson(Employee p, string newFName, string newLName, string newGender, DateTime newDoB, string newBSN, string newRelationship, string newEmail, string newPass, string newPNumb, string newAddress, string newPCode, string newCity, string newCountry)
        {
            p.UpdatePerson(newFName, newLName, newGender, newDoB, newBSN, newRelationship, newEmail, newPass, newPNumb, newAddress, newPCode, newCity, newCountry);
            dc.UpdateEmployee(p);
        }
        public void UpdateStock(Good g, int newArtNumb, string newPName, string newCat, decimal newPPrice, string newPDimension, int newQuantity)
        {
            g.UpdateStock(newArtNumb, newPName, newCat, newPPrice, newPDimension,newQuantity);
            dg.UpdateGood(g);
        }

        public void AddShift(DateTime date, ShiftType type)
        {
            sm.AddShiftTime(new Shift(date, type));
        }
        public void AddRequest(int amount, int gID, int empID)
        {
            dr.AddRequest(new Request(amount, gID),empID);
        }
    }
}