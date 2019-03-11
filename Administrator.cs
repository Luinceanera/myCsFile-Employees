using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Administrator : HospitalEmployee
    {
        private string department;
        public Administrator()
        {
            SetID(0);
            SetLastName("Valdivia");
            SetFirstName("Corina");
            SetDepartment("Lawyer");
        }
        public Administrator(int theID, string theLastName, string theFirstName, string theDepartment)
        {
            SetID(theID);
            SetLastName(theLastName);
            SetFirstName(theFirstName);
            SetDepartment(theDepartment);
        }
        public string GetDepartment()
        {
            return department;
        }
        public void SetDepartment(string theDepartment)
        {
            department = theDepartment;
        }
        public override string ToString()
        {
            return ("ADM " + GetID() + " " + GetLastName() + " " + GetFirstName() + " " + GetDepartment());
        }
        public void Detail()
        {
            Console.WriteLine("  CATEGORY: ADMINISTRATOR");
            Console.WriteLine("        ID: " + GetID());
            Console.WriteLine("      NAME: " + GetFirstName() + " " + GetLastName());
            Console.WriteLine("DEPARTMENT: " + GetDepartment());
        }
    }
}
