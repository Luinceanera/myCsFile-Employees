using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Doctor : HospitalEmployee
    {
        private string specialty;
        public Doctor()
        {
            SetID(0);
            SetLastName("Valdivia");
            SetFirstName("Corina");
            SetSpecialty("Cardiology");
        }
        public Doctor(int theID, string theLastName, string theFirstName, string theSpecialty)
        {
            SetID(theID);
            SetLastName(theLastName);
            SetFirstName(theFirstName);
            SetSpecialty(theSpecialty);
        }
        public string GetSpecialty()
        {
            return specialty;
        }
        public void SetSpecialty(string theSpecialty)
        {
            specialty = theSpecialty;
        }
        public override string ToString()
        {
            return ("DOC " + GetID() + " " + GetLastName() + " " + GetFirstName() + " " + GetSpecialty());
        }
        public void Detail()
        {
            Console.WriteLine(" CATEGORY: DOCTOR");
            Console.WriteLine("       ID: " + GetID());
            Console.WriteLine("     NAME: " + GetFirstName() + " " + GetLastName());
            Console.WriteLine("SPECIALTY: " + GetSpecialty());
        }
    }
}
