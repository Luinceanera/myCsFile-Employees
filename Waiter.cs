using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Waiter : CafeManager
    {
        private int customers;
        public Waiter()
        {
            SetID(0);
            SetLastName("Valdivia");
            SetFirstName("Corina");
            SetCafeType("Buffet");
            SetCustomers(0);
        }
        public Waiter(int theID, string theLastName, string theFirstName, string theCafeType, int theCustomers)
        {
            SetID(theID);
            SetLastName(theLastName);
            SetFirstName(theFirstName);
            SetCafeType(theCafeType);
            SetCustomers(theCustomers);
        }
        public int GetCustomers()
        {
            return customers;
        }
        public void SetCustomers(int theCustomers)
        {
            customers = theCustomers;
        }
        public override string ToString()
        {
            return ("WTR " + GetID() + " " + GetLastName() + " " + GetFirstName() + " " + GetCafeType() + " " + GetCustomers());
        }
        public void Detail()
        {
            Console.WriteLine("   CATEGORY: WAITER");
            Console.WriteLine("         ID: " + GetID());
            Console.WriteLine("       NAME: " + GetFirstName() + " " + GetLastName());
            Console.WriteLine("  CAFE TYPE: " + GetCafeType());
            Console.WriteLine("CUSTOMER(S): " + GetCustomers());
        }
    }
}
