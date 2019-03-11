using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class View
    {
        public void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Please select an action:");
            Console.WriteLine("1 - Add Employee");
            Console.WriteLine("2 - Drop Employee");
            Console.WriteLine("3 - Edit Employee");
            Console.WriteLine("4 - Save Employee");
            Console.WriteLine("5 - View Employee");
            Console.WriteLine("0 - EXIT");
        }
        public void AddEmployee()
        {
            Console.WriteLine();
            Console.WriteLine("Add Which Employee:");
            Console.WriteLine("1 - Administrator");
            Console.WriteLine("2 - Café Manager");
            Console.WriteLine("3 - Chef");
            Console.WriteLine("4 - Doctor");
            Console.WriteLine("5 - Hospital Employee");
            Console.WriteLine("6 - Janitor");
            Console.WriteLine("7 - Nurse");
            Console.WriteLine("8 - Receptionist");
            Console.WriteLine("9 - Surgeon");
            Console.WriteLine("10 - Waiter");
            Console.WriteLine("0 - EXIT");
        }
        public void Frame(string a)
        {
            for (int index = 0; index < 50; index++)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }
    }
}
