using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg egy számot!");
            var bevitel = Console.ReadLine();

            int x = Convert.ToInt32(bevitel);

            if (x >= 20) Console.WriteLine("Nagyobb vagy egyenlő mint 20");
            else if (x >= 10) Console.WriteLine("Nagyobb vagy egyenlő mint 10");
            else Console.WriteLine("Kisebb mint 10");

            if (((x % 2) == 0))
        }
    }
}
