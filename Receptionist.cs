using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Receptionist : Administrator
    {
        private char answering;
        public Receptionist()
        {
            SetID(0);
            SetLastName("Valdivia");
            SetFirstName("Corina");
            SetDepartment("Lawyer");
            SetAnswering('Y');
        }
        public Receptionist(int theID, string theLastName, string theFirstName, string theDepartment, char theAnswering)
        {
            SetID(theID);
            SetLastName(theLastName);
            SetFirstName(theFirstName);
            SetDepartment(theDepartment);
            SetAnswering(theAnswering);
        }
        public char GetAnswering()
        {
            return answering;
        }
        public void SetAnswering(char theAnswering)
        {
            answering = theAnswering;
        }
        public override string ToString()
        {
            return ("REC " + GetID() + " " + GetLastName() + " " + GetFirstName() + " " + GetDepartment() + " " + GetAnswering());
        }
        public void Detail()
        {
            Console.WriteLine("  CATEGORY: RECEPTIONIST");
            Console.WriteLine("        ID: " + GetID());
            Console.WriteLine("      NAME: " + GetFirstName() + " " + GetLastName());
            Console.WriteLine("DEPARTMENT: " + GetDepartment());
            Console.Write(" ANSWERING: ");
            if (GetAnswering() == 'Y')
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
