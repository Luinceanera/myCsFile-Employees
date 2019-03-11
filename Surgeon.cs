using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Surgeon : Doctor
    {
        private char operating;
        public Surgeon()
        {
            SetID(0);
            SetLastName("Valdivia");
            SetFirstName("Corina");
            SetSpecialty("Cardiology");
            SetOperating('Y');
        }
        public Surgeon(int theID, string theLastName, string theFirstName, string theSpecialty, char theOperating)
        {
            SetID(theID);
            SetLastName(theLastName);
            SetFirstName(theFirstName);
            SetSpecialty(theSpecialty);
            SetOperating(theOperating);
        }
        public char GetOperating()
        {
            return operating;
        }
        public void SetOperating(char theOperating)
        {
            operating = theOperating;
        }
        public override string ToString()
        {
            return ("SGT " + GetID() + " " + GetLastName() + " " + GetFirstName() + " " + GetSpecialty() + " " + GetOperating());
        }
        public void Detail()
        {
            Console.WriteLine(" CATEGORY: SURGEON");
            Console.WriteLine("       ID: " + GetID());
            Console.WriteLine("     NAME: " + GetFirstName() + " " + GetLastName());
            Console.WriteLine("SPECIALTY: " + GetSpecialty());
            Console.Write("OPERATING: ");
            if (GetOperating() == 'Y')
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
