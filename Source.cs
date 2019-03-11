using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Source
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEGIN");
            Console.WriteLine();
            Console.WriteLine();
            Control ctrl = new Control();
            ctrl.LoadFile();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("END");
        }
    }
}
