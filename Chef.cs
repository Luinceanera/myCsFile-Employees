using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Chef : CafeManager
    {
        private int foodsPrepared;
        public Chef()
        {
            SetID(0);
            SetLastName("Valdivia");
            SetFirstName("Corina");
            SetCafeType("Buffet");
            SetFoodsPrepared(0);
        }
        public Chef(int theID, string theLastName, string theFirstName, string theCafeType, int theFoodsPrepared)
        {
            SetID(theID);
            SetLastName(theLastName);
            SetFirstName(theFirstName);
            SetCafeType(theCafeType);
            SetFoodsPrepared(theFoodsPrepared);
        }
        public int GetFoodsPrepared()
        {
            return foodsPrepared;
        }
        public void SetFoodsPrepared(int theFoodsPrepared)
        {
            foodsPrepared = theFoodsPrepared;
        }
        public override string ToString()
        {
            return ("CHF " + GetID() + " " + GetLastName() + " " + GetFirstName() + " " + GetCafeType() + " " + GetFoodsPrepared());
        }
        public void Detail()
        {
            Console.WriteLine("        CATEGORY: CHEF");
            Console.WriteLine("              ID: " + GetID());
            Console.WriteLine("            NAME: " + GetFirstName() + " " + GetLastName());
            Console.WriteLine("       CAFE TYPE: " + GetCafeType());
            Console.WriteLine("FOOD(S) PREPARED: " + GetFoodsPrepared());
        }
    }
}
