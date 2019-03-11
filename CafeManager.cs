using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class CafeManager : HospitalEmployee
    {
        private string cafeType;
        public CafeManager()
        {
            SetID(0);
            SetLastName("Valdivia");
            SetFirstName("Corina");
            SetCafeType("Buffet");
        }
        public CafeManager(int theID, string theLastName, string theFirstName, string theCafeType)
        {
            SetID(theID);
            SetLastName(theLastName);
            SetFirstName(theFirstName);
            SetCafeType(theCafeType);
        }
        public string GetCafeType()
        {
            return cafeType;
        }
        public void SetCafeType(string theCafeType)
        {
            cafeType = theCafeType;
        }
        public override string ToString()
        {
            return ("CFM " + GetID() + " " + GetLastName() + " " + GetFirstName() + " " + GetCafeType());
        }
        public void Detail()
        {
            Console.WriteLine(" CATEGORY: CAFE MANAGER");
            Console.WriteLine("       ID: " + GetID());
            Console.WriteLine("     NAME: " + GetFirstName() + " " + GetLastName());
            Console.WriteLine("CAFE TYPE: " + GetCafeType());
        }
    }
}
