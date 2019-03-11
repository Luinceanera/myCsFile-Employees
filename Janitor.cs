using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Janitor : Administrator
    {
        private char sweeping;
        public Janitor()
        {
            SetID(0);
            SetLastName("Valdivia");
            SetFirstName("Corina");
            SetDepartment("Lawyer");
            SetSweeping('Y');
        }
        public Janitor(int theID, string theLastName, string theFirstName, string theDepartment, char theSweeping)
        {
            SetID(theID);
            SetLastName(theLastName);
            SetFirstName(theFirstName);
            SetDepartment(theDepartment);
            SetSweeping(theSweeping);
        }
        public char GetSweeping()
        {
            return sweeping;
        }
        public void SetSweeping(char theSweeping)
        {
            sweeping = theSweeping;
        }
        public override string ToString()
        {
            return ("JAN " + GetID() + " " + GetLastName() + " " + GetFirstName() + " " + GetDepartment() + " " + GetSweeping());
        }
        public void Detail()
        {
            Console.WriteLine("  CATEGORY: JANITOR");
            Console.WriteLine("        ID: " + GetID());
            Console.WriteLine("      NAME: " + GetFirstName() + " " + GetLastName());
            Console.WriteLine("DEPARTMENT: " + GetDepartment());
            Console.Write("  SWEEPING: ");
            if (GetSweeping() == 'Y')
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
