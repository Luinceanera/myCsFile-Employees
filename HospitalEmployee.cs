using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class HospitalEmployee
    {
        private int ID;
        private string lastName;
        private string firstName;
        public HospitalEmployee()
        {
            SetID(0);
            SetLastName("Valdivia");
            SetFirstName("Corina");
        }
        public HospitalEmployee(int theID, String theLastName, String theFirstName)
        {
            SetID(theID);
            SetLastName(theLastName);
            SetFirstName(theFirstName);
        }
        public int GetID()
        {
            return ID;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public void SetID(int theID)
        {
            ID = theID;
        }
        public void SetLastName(string theLastName)
        {
            lastName = theLastName;
        }
        public void SetFirstName(string theFirstName)
        {
            firstName = theFirstName;
        }
        public override string ToString()
        {
            return "HOS" + " " + GetID() + " " + GetLastName() + " " + GetFirstName();
        }
        public void Detail()
        {
            Console.WriteLine("CATEGORY: HOSPITAL EMPLOYEE");
            Console.WriteLine("      ID: " + GetID());
            Console.WriteLine("    NAME: " + GetFirstName() + " " + GetLastName());
        }
    }
}
