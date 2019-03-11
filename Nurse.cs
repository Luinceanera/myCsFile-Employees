using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Nurse : HospitalEmployee
    {
        private int patient;
        public Nurse()
        {
            SetID(0);
            SetLastName("Valdivia");
            SetFirstName("Corina");
            SetPatient(0);
        }
        public Nurse(int theID, string theLastName, string theFirstName, int thePatient)
        {
            SetID(theID);
            SetLastName(theLastName);
            SetFirstName(theFirstName);
            SetPatient(thePatient);
        }
        public int GetPatient()
        {
            return patient;
        }
        public void SetPatient(int thePatient)
        {
            patient = thePatient;
        }
        public override string ToString()
        {
            return ("NRS " + GetID() + " " + GetLastName() + " " + GetFirstName() + " " + GetPatient());
        }
        public void Detail()
        {
            Console.WriteLine("  CATEGORY: NURSE");
            Console.WriteLine("        ID: " + GetID());
            Console.WriteLine("      NAME: " + GetFirstName() + " " + GetLastName());
            Console.WriteLine("PATIENT(S): " + GetPatient());
        }
    }
}
